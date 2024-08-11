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
    class ProveedoresModels
    {
        public int IdProveedor { get; set; }
        public string NombreEmpresa { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        private ConexionBDD conexionBDD = new ConexionBDD();
        SqlCommand cmd = new SqlCommand();

        public List<ProveedoresModels> Todos()
        {
            List<ProveedoresModels> listaProveedores = new List<ProveedoresModels>();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Proveedores", conexionBDD.AbrirConexion());
            DataTable data = new DataTable();
            adapter.Fill(data);
            foreach (DataRow fila in data.Rows)
            {
                listaProveedores.Add(new ProveedoresModels
                {
                    IdProveedor = Convert.ToInt32(fila["IdProveedor"]),
                    NombreEmpresa = fila["NombreEmpresa"].ToString(),
                    Direccion = fila["Direccion"].ToString(),
                    Telefono = fila["Telefono"].ToString()
                });
            }
            conexionBDD.CerrarConexion();
            return listaProveedores;
        }

        public string Insertar(ProveedoresModels proveedor)
        {
            try
            {
                cmd.Connection = conexionBDD.AbrirConexion();
                cmd.CommandText = $"insert into Proveedores (NombreEmpresa, Direccion, Telefono) values('{proveedor.NombreEmpresa}', '{proveedor.Direccion}', '{proveedor.Telefono}')";
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

        public string Editar(ProveedoresModels proveedor)
        {
            try
            {
                cmd.Connection = conexionBDD.AbrirConexion();
                cmd.CommandText = $"update Proveedores set NombreEmpresa='{proveedor.NombreEmpresa}', Direccion='{proveedor.Direccion}', Telefono='{proveedor.Telefono}' where IdProveedor={proveedor.IdProveedor}";
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

        public string Eliminar(int idProveedor)
        {
            try
            {
                cmd.Connection = conexionBDD.AbrirConexion();
                cmd.CommandText = $"delete from Proveedores where IdProveedor={idProveedor}";
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

