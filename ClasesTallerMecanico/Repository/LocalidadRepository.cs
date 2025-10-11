using ClasesTallerMecanico.Data;
using ClasesTallerMecanico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTallerMecanico.Repository
{
    public class LocalidadRepository
    {
        private readonly ApplicationDbContext _context;

        public LocalidadRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void GuardarLocalidad(Localidad localidad)
        {
            _context.Localidades.Add(localidad);
            _context.SaveChanges();
        }

        public List<Localidad> ObtenerTodas()
        {
            return _context.Localidades.ToList();
        }
    }
}
