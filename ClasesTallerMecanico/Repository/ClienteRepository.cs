using ClasesTallerMecanico.Data;
using ClasesTallerMecanico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTallerMecanico.Repository
{
    public class ClienteRepository
    {
        private readonly ApplicationDbContext _context;

        public ClienteRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void GuardarCliente(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public Cliente ObtenerClientePorCuilCuit(string cuilCuit)
        {
            return _context.Clientes
                           .SingleOrDefault(c => c.CuilCuit == cuilCuit);
        }
        public bool EliminarClientePorCuilCuit(string cuilCuit)
        {
            var clienteAEliminar = ObtenerClientePorCuilCuit(cuilCuit);

            if (clienteAEliminar != null)
            {
                _context.Clientes.Remove(clienteAEliminar);
                _context.SaveChanges();

                return true;
            }

            return false;
        }
    }
}
