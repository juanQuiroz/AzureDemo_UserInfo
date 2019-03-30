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
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            database bd = new database();
            bd.conexion.Open();

            SqlCommand cmd = bd.conexion.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM db_azureprueba.tb_usuarios WHERE codigo='" + txtCodigo.Text + "'";

            cmd.ExecuteNonQuery();

            SqlDataReader leer = cmd.ExecuteReader();

            MessageBox.Show(leer["cNOMTIT"].ToString());

            while (leer.Read() == true)
            {
                txtNombre.Text = leer["cNOMTIT"].ToString();
                txtApellido.Text = leer["cAPPATIT"].ToString();

            }

            bd.conexion.Close();

        }
            

    }
          
}
