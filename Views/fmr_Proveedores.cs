using _041Tienda.Controller;
using _041Tienda.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _041Tienda.Views
{
    public partial class fmr_Proveedores : Form
    {
        Proveedorescontroller proveedorescontroller = new Proveedorescontroller();
        public string IdProveedor = null;

        public fmr_Proveedores()
        {
            InitializeComponent();
        }

        private void fmr_Proveedores_Load(object sender, EventArgs e)
        {
            cargaLista();
        }
        public void cargaLista()
        {
          //  lstProveedores.Items.Clear();
            lstProveedores.DataSource = proveedorescontroller.Todos();
            lstProveedores.DisplayMember = "NombreEmpresa";
            lstProveedores.ValueMember = "IdProveedor";
        }

        private void lstProveedores_DoubleClick(object sender, EventArgs e)
        {
            IdProveedor = lstProveedores.SelectedValue.ToString();
            txt_nombreEmpresa.Text = lstProveedores.GetItemText(lstProveedores.SelectedItem);
            txt_direccion.Text = ((ProveedoresModels)lstProveedores.SelectedItem).Direccion;
            txt_telefono.Text = ((ProveedoresModels)lstProveedores.SelectedItem).Telefono;
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (lstProveedores.SelectedItem != null)
            {
                IdProveedor = lstProveedores.SelectedValue.ToString();
                txt_nombreEmpresa.Text = lstProveedores.GetItemText(lstProveedores.SelectedItem);
                txt_direccion.Text = ((ProveedoresModels)lstProveedores.SelectedItem).Direccion;
                txt_telefono.Text = ((ProveedoresModels)lstProveedores.SelectedItem).Telefono;
            }
            else
            {
                MessageBox.Show("Seleccione un proveedor de la lista");
            }
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            string respuesta = "";
            ProveedoresModels proveedor = new ProveedoresModels
            {
                IdProveedor = string.IsNullOrEmpty(IdProveedor) ? 0 : Convert.ToInt32(IdProveedor),
                NombreEmpresa = txt_nombreEmpresa.Text,
                Direccion = txt_direccion.Text,
                Telefono = txt_telefono.Text
            };

            if (proveedor.IdProveedor > 0)
            {
                respuesta = proveedorescontroller.Editar(proveedor);
            }
            else
            {
                respuesta = proveedorescontroller.Insertar(proveedor);
            }

            if (respuesta == "ok")
            {
                IdProveedor = null;
                cargaLista();
                MessageBox.Show("Se guardó con éxito");
            }
            else
            {
                MessageBox.Show("Error al guardar: " + respuesta);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (lstProveedores.SelectedItem != null)
            {
                int idProveedor = Convert.ToInt32(lstProveedores.SelectedValue);
                proveedorescontroller.Eliminar(idProveedor);
                cargaLista();
            }
            else
            {
                MessageBox.Show("Seleccione un proveedor de la lista");
            }
        }
    }
}
