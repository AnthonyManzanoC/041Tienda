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
    class ClientesModels
    {
        public int IdCliente { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        private ConexionBDD conexionBDD = new ConexionBDD();
        SqlCommand cmd = new SqlCommand();

        public List<ClientesModels> Todos()
        {
            List<ClientesModels> listaClientes = new List<ClientesModels>();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Clientes", conexionBDD.AbrirConexion());
            DataTable data = new DataTable();
            adapter.Fill(data);
            foreach (DataRow fila in data.Rows)
            {
                listaClientes.Add(new ClientesModels
                {
                    IdCliente = Convert.ToInt32(fila["IdCliente"]),
                    Nombres = fila["Nombres"].ToString(),
                    Apellidos = fila["Apellidos"].ToString(),
                    Direccion = fila["Direccion"].ToString(),
                    Telefono = fila["Telefono"].ToString(),
                    Correo = fila["Correo"].ToString()
                });
            }
            conexionBDD.CerrarConexion();
            return listaClientes;
        }

        public string Insertar(ClientesModels cliente)
        {
            try
            {
                cmd.Connection = conexionBDD.AbrirConexion();
                cmd.CommandText = $"insert into Clientes (Nombres, Apellidos, Direccion, Telefono, Correo) values('{cliente.Nombres}', '{cliente.Apellidos}', '{cliente.Direccion}', '{cliente.Telefono}', '{cliente.Correo}')";
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

        public string Editar(ClientesModels cliente)
        {
            try
            {
                cmd.Connection = conexionBDD.AbrirConexion();
                cmd.CommandText = $"update Clientes set Nombres='{cliente.Nombres}', Apellidos='{cliente.Apellidos}', Direccion='{cliente.Direccion}', Telefono='{cliente.Telefono}', Correo='{cliente.Correo}' where IdCliente={cliente.IdCliente}";
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

        public string Eliminar(int idCliente)
        {
            try
            {
                cmd.Connection = conexionBDD.AbrirConexion();
                cmd.CommandText = $"delete from Clientes where IdCliente={idCliente}";
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

