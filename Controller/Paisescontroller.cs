using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _041Tienda.Models;

namespace _041Tienda.Controller
{
    class Paisescontroller
    {
        private PaisesModels paisesModels = new PaisesModels();

        public List<PaisesModels> Todos()
        {
            return paisesModels.Todos();
        }
        public string Insertar(PaisesModels pais)
        {
            return paisesModels.Insertar(pais);
        }
        public string Editar(PaisesModels pais)
        {
            return paisesModels.Editar(pais);
        }
        public string Eliminar(int idPais)
        {
            return paisesModels.Eliminar(idPais);
        }
    }
}
