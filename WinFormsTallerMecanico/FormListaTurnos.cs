using ClasesTallerMecanico.Data;
using ClasesTallerMecanico.Models;
using ClasesTallerMecanico.Repository;
using Microsoft.VisualBasic;

namespace WinFormsTallerMecanico
{
    public partial class FormListaTurnos : Form
    {
        private ApplicationDbContext _context;
        private TurnoRepository _turnoRepository;
        public FormListaTurnos()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            _turnoRepository = new TurnoRepository(_context);
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            CargarDatosTurnos();
        }

        private void CargarDatosTurnos()
        {
            var turnos = _turnoRepository.ObtenerTodosLosTurnos();
            dataGridView1.DataSource = turnos.ToList();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Cliente")
            {
                var turno = dataGridView1.Rows[e.RowIndex].DataBoundItem as Turno;
                if (turno != null && turno.Cliente != null)
                {
                    e.Value = turno.Cliente.Nombre;
                    e.FormattingApplied = true;
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Maquina")
            {
                var turno = dataGridView1.Rows[e.RowIndex].DataBoundItem as Turno;
                if (turno != null && turno.Maquina != null)
                {
                    e.Value = turno.Maquina.Nombre;
                    e.FormattingApplied = true;
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Localidad")
            {
                var turno = dataGridView1.Rows[e.RowIndex].DataBoundItem as Turno;
                if (turno != null && turno.Localidad != null)
                {
                    e.Value = turno.Localidad.Nombre;
                    e.FormattingApplied = true;
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarDatosTurnos();
        }

        private void btnNuevoTurno_Click(object sender, EventArgs e)
        {
            FormNuevoTurno formNuevoTurno = new FormNuevoTurno();
            formNuevoTurno.ShowDialog();
            CargarDatosTurnos();
        }

        private void btnEliminarTurno_Click(object sender, EventArgs e)
        {
            string nombreMaquina = Interaction.InputBox(
                "Ingrese el NOMBRE de la máquina cuyo turno desea eliminar:",
                "Eliminar Turno",
                ""
            );

            if (string.IsNullOrWhiteSpace(nombreMaquina))
            {
                MessageBox.Show("Operación cancelada o nombre no proporcionado.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var maquinaRepository = new MaquinaRepository(_context);
            var maquina = maquinaRepository.ObtenerMaquinaPorNombre(nombreMaquina.Trim());
            if (maquina == null)
            {
                MessageBox.Show("No se encontró ninguna máquina con ese nombre.", "Máquina No Encontrada",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var turnos = _turnoRepository.ObtenerTodosLosTurnos()
                .Where(t => t.IdMaquina == maquina.Id)
                .OrderByDescending(t => t.Fecha)
                .ToList();

            if (!turnos.Any())
            {
                MessageBox.Show("No se encontró ningún turno para esa máquina.", "Turno No Encontrado",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var turnoAEliminar = turnos.First();
            DialogResult confirmacion = MessageBox.Show($"¿Está seguro que desea eliminar el turno más reciente para la máquina: {maquina.Nombre} (Cliente: {turnoAEliminar.Cliente?.Nombre})?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.No)
                return;

            // Lógica de eliminación lógica
            var eliminado = _turnoRepository.EliminarTurnoPorId(turnoAEliminar.Id);
            if (eliminado)
            {
                MessageBox.Show("Turno eliminado con éxito.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatosTurnos();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el turno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnModificarTurno_Click(object sender, EventArgs e)
        {
            string nombreMaquina = Interaction.InputBox(
                "Ingrese el NOMBRE de la máquina cuyo turno desea modificar:",
                "Modificar Turno",
                ""
            );

            if (string.IsNullOrWhiteSpace(nombreMaquina))
            {
                MessageBox.Show("Operación cancelada o nombre no proporcionado.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var maquinaRepository = new MaquinaRepository(_context);
            var maquina = maquinaRepository.ObtenerMaquinaPorNombre(nombreMaquina.Trim());
            if (maquina == null)
            {
                MessageBox.Show("No se encontró ninguna máquina con ese nombre.", "Máquina No Encontrada",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var turnos = _turnoRepository.ObtenerTodosLosTurnos()
                .Where(t => t.IdMaquina == maquina.Id)
                .OrderByDescending(t => t.Fecha)
                .ToList();

            if (!turnos.Any())
            {
                MessageBox.Show("No se encontró ningún turno para esa máquina.", "Turno No Encontrado",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var turnoAModificar = turnos.First();
            FormModificarTurno formModificarTurno = new FormModificarTurno(turnoAModificar);
            DialogResult result = formModificarTurno.ShowDialog();
            if (result == DialogResult.OK)
                CargarDatosTurnos();
        }
    }
}
