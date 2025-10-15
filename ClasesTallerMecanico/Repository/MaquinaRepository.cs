using ClasesTallerMecanico.Data;
using ClasesTallerMecanico.Models;
using Microsoft.EntityFrameworkCore;

namespace ClasesTallerMecanico.Repository
{
    public class MaquinaRepository
    {
        private readonly ApplicationDbContext _context;

        public MaquinaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void GuardarMaquina(Maquina maquina)
        {
            _context.Maquinas.Add(maquina);
            _context.SaveChanges();
        }

        public List<Maquina> ObtenerTodasLasMaquinas()
        {
            // El único filtro eliminado es el .Where(c => c.Activo == true)
            return _context.Maquinas
                           .Include(m => m.Cliente) // Seguimos incluyendo la Localidad
                           .ToList(); // Ejecuta la consulta y devuelve todos los registros
        }

        public List<Maquina> ObtenerMaquinasActivas()
        {
            // Usamos .Include() para traer el Cliente relacionado (evitar problemas de lazy loading)
            // y filtramos por Activo = true para implementar el Soft Delete.
            return _context.Maquinas
                           .Include(m => m.Cliente)
                           .Where(m => m.Activo == true)
                           .ToList(); // Ejecuta la consulta y devuelve una lista
        }

        public List<Maquina> ObtenerMaquinasActivasPorCliente(int idCliente)
        {
            return _context.Maquinas
                .Include(m => m.Cliente)
                .Where(m => m.Activo && m.IdCliente == idCliente)
                .ToList();
        }
        public Maquina ObtenerMaquinaPorPatente(string patente)
        {
            return _context.Maquinas
                           .SingleOrDefault(m => m.Patente == patente);
        }

        public Maquina ObtenerMaquinaPorNombre(string nombre)
        {
            return _context.Maquinas.FirstOrDefault(m => m.Nombre == nombre);
        }

        public bool EliminarMaquinaPorPatente(string patente)
        {
            var maquinaADesactivar = ObtenerMaquinaPorPatente(patente);

            if (maquinaADesactivar != null)
            {

                maquinaADesactivar.Activo = false;

                _context.Maquinas.Update(maquinaADesactivar);
                _context.SaveChanges();

                return true;
            }

            return false;
        }
    }
}
