using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using _041Tienda.Config;


namespace _041Tienda.Models
{
    class PaisesModels
    {
        public int IdPais { get; set; }
        public string Detalle { get; set; }
        private ConexionBDD conexionBDD = new ConexionBDD();
        SqlCommand cmd = new SqlCommand();

        public List<PaisesModels> Todos()
        {
            List<PaisesModels> listaPaises = new List<PaisesModels>();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Paises", conexionBDD.AbrirConexion());
            DataTable data = new DataTable();
            adapter.Fill(data);
            foreach (DataRow fila in data.Rows)
            {
                listaPaises.Add(new PaisesModels
                {
                    IdPais = Convert.ToInt32(fila["IdPais"]),
                    Detalle = fila["Detalle"].ToString()
                });
            }
            conexionBDD.CerrarConexion();
            return listaPaises;
        }

        public string Insertar(PaisesModels pais)
        {
            try
            {
                cmd.Connection = conexionBDD.AbrirConexion();
                cmd.CommandText = $"insert into Paises (Detalle) values('{pais.Detalle}')";
                cmd.ExecuteNonQuery();
                return "ok";
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                conexionBDD.CerrarConexion();
            }
        }

        public string Editar(PaisesModels pais)
        {
            try
            {
                cmd.Connection = conexionBDD.AbrirConexion();
                cmd.CommandText = $"update Paises set Detalle='{pais.Detalle}' where IdPais={pais.IdPais}";
                cmd.ExecuteNonQuery();
                return "ok";
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                conexionBDD.CerrarConexion();
            }
        }

        public string Eliminar(int idPais)
        {
            try
            {
                cmd.Connection = conexionBDD.AbrirConexion();
                cmd.CommandText = $"delete from Paises where IdPais={idPais}";
                cmd.ExecuteNonQuery();
                return "ok";
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                conexionBDD.CerrarConexion();
            }
        }
    }
}
