using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql;

namespace AzureDemo_UserInfo
{
    class database
    {
        //private string servidor = "midemoserver.mysql.database.azure.com";
        //private string data_base = "db_azurePrueba";
        private string cadena = "";
        public SqlConnection conexion;

        public database()
        {
            cadena = "Server=midemoserver.mysql.database.azure.com; Port=3306; Database=db_azurePrueba; Uid=myadmin@midemoserver; Pwd=Leobbsita97; SslMode=Preferred;";
            conexion = new SqlConnection(cadena);
        }

        public void open()
        {
            try
            {
                conexion.Open();
                MessageBox.Show("Conexion abierta con la base de datos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        public void close()
        {
            this.conexion.Close();
        }

        public string getSource()
        {
            return this.cadena;
        }
        public SqlConnection con()
        {
            return this.conexion;
        }


    }
}
