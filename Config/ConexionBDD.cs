using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace _041Tienda.Config
{
    class ConexionBDD
    {
        private SqlConnection con = new SqlConnection("Server=DESKTOP-DBJKEFC\\SQLEXPRESS;database=CuartoNVL;uid=sa;pwd=12345678");

        public SqlConnection AbrirConexion()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            return con;
        }

        public SqlConnection CerrarConexion()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            return con;
        }
    }
}
