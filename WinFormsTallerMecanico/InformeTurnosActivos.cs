using ClasesTallerMecanico.Data;
using ClasesTallerMecanico.Models;
using ClasesTallerMecanico.Repository;

namespace WinFormsTallerMecanico
{
    public partial class InformeTurnosActivos : Form
    {
        private ApplicationDbContext _context;
        private TurnoRepository _turnoRepository;
        public InformeTurnosActivos()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            _turnoRepository = new TurnoRepository(_context);
            dataGridTurnosActivos.CellFormatting += dataGridTurnosActivos_CellFormatting;
            CargarDatosTurnos();
        }

        private void CargarDatosTurnos()
        {
            var turnos = _turnoRepository.ObtenerTurnosActivos();
            dataGridTurnosActivos.DataSource = turnos.ToList();
        }

        private void dataGridTurnosActivos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridTurnosActivos.Columns[e.ColumnIndex].Name == "Cliente")
            {
                var turno = dataGridTurnosActivos.Rows[e.RowIndex].DataBoundItem as Turno;
                if (turno != null && turno.Cliente != null)
                {
                    e.Value = turno.Cliente.Nombre;
                    e.FormattingApplied = true;
                }
            }
            else if (dataGridTurnosActivos.Columns[e.ColumnIndex].Name == "Maquina")
            {
                var turno = dataGridTurnosActivos.Rows[e.RowIndex].DataBoundItem as Turno;
                if (turno != null && turno.Maquina != null)
                {
                    e.Value = turno.Maquina.Nombre;
                    e.FormattingApplied = true;
                }
            }
            else if (dataGridTurnosActivos.Columns[e.ColumnIndex].Name == "Localidad")
            {
                var turno = dataGridTurnosActivos.Rows[e.RowIndex].DataBoundItem as Turno;
                if (turno != null && turno.Localidad != null)
                {
                    e.Value = turno.Localidad.Nombre;
                    e.FormattingApplied = true;
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
