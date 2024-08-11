using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _041Tienda.Models;

namespace _041Tienda.Controller
{
    class Clientescontroller
    {
        private ClientesModels clientesModels = new ClientesModels();

        public List<ClientesModels> Todos()
        {
            return clientesModels.Todos();
        }
        public string Insertar(ClientesModels cliente)
        {
            return clientesModels.Insertar(cliente);
        }
        public string Editar(ClientesModels cliente)
        {
            return clientesModels.Editar(cliente);
        }
        public string Eliminar(int idCliente)
        {
            return clientesModels.Eliminar(idCliente);
        }
    }
}
