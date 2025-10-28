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
        private LocalidadRepository _localidadRepository;
        private MaquinaRepository _maquinaRepository;
        public FormListaTurnos()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            _turnoRepository = new TurnoRepository(_context);
            _localidadRepository = new LocalidadRepository(_context);
            _maquinaRepository = new MaquinaRepository(_context); // Inicializar repositorio de máquinas
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            CargarDatosTurnos();
        }

        private void CargarDatosTurnos()
        {
            // Siempre crear un nuevo contexto y repositorio para evitar caché
            using (var context = new ApplicationDbContext())
            {
                var turnoRepository = new TurnoRepository(context);
                var turnos = turnoRepository.ObtenerTodosLosTurnos();
                dataGridView1.DataSource = turnos.ToList();
                dataGridView1.Refresh(); // Forzar refresco visual
            }
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
            var maquinas = _maquinaRepository.ObtenerTodasLasMaquinas();
            if (maquinas == null || maquinas.Count == 0)
            {
                MessageBox.Show("Debe cargar al menos una máquina antes de poder dar de alta un turno.", "Máquina requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var localidades = _localidadRepository.ObtenerTodas();
            if (localidades == null || localidades.Count == 0)
            {
                MessageBox.Show("Debe cargar al menos una localidad antes de poder dar de alta un turno.", "Localidad requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FormNuevoTurno formNuevoTurno = new FormNuevoTurno();
            if (formNuevoTurno.ShowDialog() == DialogResult.OK)
            {
                CargarDatosTurnos(); // Actualiza la grilla automáticamente
            }
        }

        private void btnEliminarTurno_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Debe seleccionar un turno de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var turnoSeleccionado = dataGridView1.CurrentRow.DataBoundItem as Turno;
            if (turnoSeleccionado == null)
            {
                MessageBox.Show("No se pudo obtener el turno seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro que desea eliminar el turno del cliente: {turnoSeleccionado.Cliente?.Nombre} para la máquina: {turnoSeleccionado.Maquina?.Nombre}?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (confirmacion == DialogResult.No)
            {
                return;
            }
            var eliminado = _turnoRepository.EliminarTurnoPorId(turnoSeleccionado.Id);
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
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Debe seleccionar un turno de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var turnoSeleccionado = dataGridView1.CurrentRow.DataBoundItem as Turno;
            if (turnoSeleccionado == null)
            {
                MessageBox.Show("No se pudo obtener el turno seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FormModificarTurno formModificarTurno = new FormModificarTurno(turnoSeleccionado);
            DialogResult result = formModificarTurno.ShowDialog();
            if (result == DialogResult.OK)
                CargarDatosTurnos();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            CargarDatosTurnos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
