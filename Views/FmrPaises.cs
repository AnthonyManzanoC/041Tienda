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

namespace _041Tienda
{
    public partial class FmrPaises : Form
    {
        Paisescontroller paisescontroller = new Paisescontroller();
        public string IdPais = null;

        public FmrPaises()
        {
            InitializeComponent();
        }

        private void FmrPaises_Load(object sender, EventArgs e)
        {
            cargaLista();
        }
        public void cargaLista()
        {
            
            lstPaises.DataSource = paisescontroller.Todos();
            lstPaises.DisplayMember = "Detalle";
            lstPaises.ValueMember = "IdPais";
        }

        private void lstPaises_DoubleClick(object sender, EventArgs e)
        {
            IdPais = lstPaises.SelectedValue.ToString();
            txt_detalle.Text = lstPaises.GetItemText(lstPaises.SelectedItem);
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (lstPaises.SelectedItem != null)
            {
                IdPais = lstPaises.SelectedValue.ToString();
                txt_detalle.Text = lstPaises.GetItemText(lstPaises.SelectedItem);
            }
            else
            {
                MessageBox.Show("Seleccione un país de la lista");
            }
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            string respuesta = "";
            PaisesModels pais = new PaisesModels
            {
                IdPais = string.IsNullOrEmpty(IdPais) ? 0 : Convert.ToInt32(IdPais),
                Detalle = txt_detalle.Text
            };

            if (pais.IdPais > 0)
            {
                respuesta = paisescontroller.Editar(pais);
            }
            else
            {
                respuesta = paisescontroller.Insertar(pais);
            }

            if (respuesta == "ok")
            {
                IdPais = null;
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
            if (lstPaises.SelectedItem != null)
            {
                int idPais = Convert.ToInt32(lstPaises.SelectedValue);
                paisescontroller.Eliminar(idPais);
                cargaLista();
            }
            else
            {
                MessageBox.Show("Seleccione un país de la lista");
            }
        }
    }
    
}
