using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _041Tienda.Models;

namespace _041Tienda.Controller
{
    class Proveedorescontroller
    {
        private ProveedoresModels proveedoresModels = new ProveedoresModels();

        public List<ProveedoresModels> Todos()
        {
            return proveedoresModels.Todos();
        }
        public string Insertar(ProveedoresModels proveedor)
        {
            return proveedoresModels.Insertar(proveedor);
        }
        public string Editar(ProveedoresModels proveedor)
        {
            return proveedoresModels.Editar(proveedor);
        }
        public string Eliminar(int idProveedor)
        {
            return proveedoresModels.Eliminar(idProveedor);
        }
    }
}

