using _041Tienda.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _041Tienda.Models;
namespace _041Tienda.Views
{
    public partial class fmr_Clientes : Form
    {
        Clientescontroller clientesController = new Clientescontroller();
        public string IdCliente = null;
        public fmr_Clientes()
        {
            InitializeComponent();
            CargaLista();
        }
        private void CargaLista()
        {
           // lstClientes.Items.Clear();
            lstClientes.DataSource = clientesController.Todos();
            lstClientes.DisplayMember = "Nombres";
            lstClientes.ValueMember = "IdCliente";
        }
        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fmr_Clientes_Load(object sender, EventArgs e)
        {
            CargaLista();
        }

        private void lstClientes_DoubleClick(object sender, EventArgs e)
        {
            IdCliente = lstClientes.SelectedValue.ToString();
            var cliente = (ClientesModels)lstClientes.SelectedItem;
            txt_nombres.Text = cliente.Nombres;
            txt_apellidos.Text = cliente.Apellidos;
            txt_direccion.Text = cliente.Direccion;
            txt_telefono.Text = cliente.Telefono;
            txt_correo.Text = cliente.Correo;
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            string respuesta = "";
            ClientesModels cliente = new ClientesModels
            {
                IdCliente = string.IsNullOrEmpty(IdCliente) ? 0 : Convert.ToInt32(IdCliente),
                Nombres = txt_nombres.Text,
                Apellidos = txt_apellidos.Text,
                Direccion = txt_direccion.Text,
                Telefono = txt_telefono.Text,
                Correo = txt_correo.Text
            }; 
            if (cliente.IdCliente > 0)
            {
                respuesta = clientesController.Editar(cliente);
            }
            else
            {
                respuesta = clientesController.Insertar(cliente);
            }

            if (respuesta == "ok")
            {
                IdCliente = null;
                CargaLista();
                MessageBox.Show("Se guardó con éxito");
            }
            else
            {
                MessageBox.Show("Error al guardar");
            }


        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(IdCliente))
            {
                clientesController.Eliminar(Convert.ToInt32(IdCliente));
                CargaLista();
                MessageBox.Show("Cliente eliminado");
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para eliminar");
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (lstClientes.SelectedItem != null)
            {
                IdCliente = lstClientes.SelectedValue.ToString();
                var cliente = (ClientesModels)lstClientes.SelectedItem;

                txt_nombres.Text = cliente.Nombres;
                txt_apellidos.Text = cliente.Apellidos;
                txt_direccion.Text = cliente.Direccion;
                txt_telefono.Text = cliente.Telefono;
                txt_correo.Text = cliente.Correo;
            }
                else
                {
                MessageBox.Show("Seleccione un cliente de la lista para modificar.");
                }


        }
    }
}
