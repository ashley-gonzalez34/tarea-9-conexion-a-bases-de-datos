using Grpc.Core;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BASE_DE_DATOS_PROGRA.clases
{
    class ClsConexionMySQL
    {
        public static MySqlConnection conexionmysql()
        {
            string servidor = "localhost"; //Nombre o ip del servidor de MySQL

            string bd = "bdalumnos"; //Nombre de la base de datos

            string usuario = "root"; //Usuario de acceso a MySQL

            string password = "Umg$2019"; //Contraseña de usuario de acceso a MySQL




            //Crearemos la cadena de conexión concatenando las variables
            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";
            //Instancia para conexión a MySQL, recibe la cadena de conexión

            try
            {

                MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
                return conexionBD;

            }
            catch
            {
                Console.WriteLine("Error: ");
                MessageBox.Show("error");
                return null;
            }




        }
    }
}