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
            cadena = "Server=tcp:serverpruebasqldatabase.database.windows.net,1433;Initial Catalog=db_pruebaSQLDatabase;Persist Security Info=False;User ID=myadmin;Password=Leobbsita97;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
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
