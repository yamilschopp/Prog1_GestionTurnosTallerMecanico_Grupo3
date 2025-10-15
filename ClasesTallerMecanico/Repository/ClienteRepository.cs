using ClasesTallerMecanico.Data;
using ClasesTallerMecanico.Models;
using Microsoft.EntityFrameworkCore;

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

        public List<Cliente> ObtenerTodosLosClientes()
        {
            // El único filtro eliminado es el .Where(c => c.Activo == true)
            return _context.Clientes
                           .Include(c => c.Localidad) // Seguimos incluyendo la Localidad
                           .ToList(); // Ejecuta la consulta y devuelve todos los registros
        }

        public List<Cliente> ObtenerClientesActivos()
        {
            // Usamos .Include() para traer la Localidad relacionada (evitar problemas de lazy loading)
            // y filtramos por Activo = true para implementar el Soft Delete.
            return _context.Clientes
                           .Include(c => c.Localidad) // Trae el objeto Localidad completo
                           .Where(c => c.Activo == true)
                           .ToList(); // Ejecuta la consulta y devuelve una lista
        }
        public Cliente ObtenerClientePorCuilCuit(string cuilCuit)
        {
            return _context.Clientes
                           .SingleOrDefault(c => c.CuilCuit == cuilCuit);
        }
        public bool EliminarClientePorCuilCuit(string cuilCuit)
        {
            //var clienteAEliminar = ObtenerClientePorCuilCuit(cuilCuit);

            //if (clienteAEliminar != null)
            //{
            //    _context.Clientes.Remove(clienteAEliminar);
            //    _context.SaveChanges();

            //    return true;
            //}

            //return false;

            var clienteADesactivar = ObtenerClientePorCuilCuit(cuilCuit);

            if (clienteADesactivar != null)
            {

                clienteADesactivar.Activo = false;

                _context.Clientes.Update(clienteADesactivar);
                _context.SaveChanges();

                return true;
            }

            return false;
        }
    }
}
