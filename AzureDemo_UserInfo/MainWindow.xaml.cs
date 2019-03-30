using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AzureDemo_UserInfo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtP1.Clear();
            txtP2.Clear();
            txtP3.Clear();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            database bd = new database();
            bd.conexion.Open();
            MessageBox.Show("Conexion exitosa");

            SqlCommand cmd = bd.conexion.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM tb_usuarios WHERE codigo='" + txtCodigo.Text + "'";

            cmd.ExecuteNonQuery();

            SqlDataReader leer = cmd.ExecuteReader();

      

            while (leer.Read() == true)
            {
                txtNombre.Text = leer["nombres"].ToString();
                txtApellido.Text = leer["apellidos"].ToString();
                txtDNI.Text = leer["dni"].ToString();
                txtP1.Text = leer["perfil1"].ToString();
                txtP2.Text = leer["perfil2"].ToString();
                txtP3.Text = leer["perfil3"].ToString();
     
            }

            bd.conexion.Close();

        }

        private void txtCodigo_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void txtCodigo_MouseEnter(object sender, MouseEventArgs e)
        {
            txtCodigo.Text = "";
        }

        private void txtCodigo_MouseLeave(object sender, MouseEventArgs e)
        {
            if(txtCodigo.Text == "")
            {
                txtCodigo.Text = "Buscar";
            }
        }
    }
          
}
