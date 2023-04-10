using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mundial.DATOS
{
    internal class conexion_Class
    {

        SqlConnection conexion; //declaracion de variable

        public conexion_Class() //constructor 
        {

            conexion = new SqlConnection("server=.\\SQLEXPRESS ; database= TP_Mundial_En_Cero ; integrated security=true");//arreglar aqui

        }

        public SqlConnection Conectar() //metodo para conectarse
        {
            try
            {
                conexion.Open();
                return conexion;

            }
            catch (Exception e)
            {   
                MessageBox.Show(e.Message);
                return null;
            }
            

        }
        public SqlConnection desconectar() //metodo para desconectarse
        {
            try
            {
                conexion.Close();
                return conexion;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            
        }



    }
}
