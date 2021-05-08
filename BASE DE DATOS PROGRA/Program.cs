using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using BASE_DE_DATOS_PROGRA.clases;

namespace BASE_DE_DATOS_PROGRA
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsConexion cn = new ClsConexion();

            DataTable dt = cn.consultaTablaDirecta("SELECT *  FROM [tb_alumnos]");

            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine(dr[1]);




            }

            
            
        }


    }
}
