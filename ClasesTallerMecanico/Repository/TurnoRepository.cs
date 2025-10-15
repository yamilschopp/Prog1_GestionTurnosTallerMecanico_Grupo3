namespace ClasesTallerMecanico.Repository
{
    using ClasesTallerMecanico.Data;
    using ClasesTallerMecanico.Models;
    using Microsoft.EntityFrameworkCore;

    public class TurnoRepository
    {
        private readonly ApplicationDbContext _context;

        public TurnoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void GuardarTurno(Turno turno)
        {
            _context.Turnos.Add(turno);
            _context.SaveChanges();
        }

        public List<Turno> ObtenerTodosLosTurnos()
        {
            return _context.Turnos
                           .Include(t => t.Cliente)
                           .Include(t => t.Maquina)
                           .Include(t => t.Localidad)
                           .ToList();
        }

        public List<Turno> ObtenerTurnosActivos()
        {
            return _context.Turnos
                           .Include(t => t.Cliente)
                           .Include(t => t.Maquina)
                           .Include(t => t.Localidad)
                           .Where(t => t.Activo == true)
                           .ToList();
        }

        public Turno ObtenerTurnoPorId(int id)
        {
            return _context.Turnos
                           .Include(t => t.Cliente)
                           .Include(t => t.Maquina)
                           .Include(t => t.Localidad)
                           .SingleOrDefault(t => t.Id == id);
        }

        public bool EliminarTurnoPorId(int id)
        {
            var turnoADesactivar = ObtenerTurnoPorId(id);
            if (turnoADesactivar != null)
            {
                turnoADesactivar.Activo = false;
                _context.Turnos.Update(turnoADesactivar);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
