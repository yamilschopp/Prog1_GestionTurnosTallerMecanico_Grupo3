using ClasesTallerMecanico.Data;
using ClasesTallerMecanico.Models;
using ClasesTallerMecanico.Repository;
using Microsoft.VisualBasic;


namespace WinFormsTallerMecanico
{
    public partial class FormListaMaquinas : Form
    {
        private ApplicationDbContext _context;
        private MaquinaRepository _maquinaRepository;
        public FormListaMaquinas()
        {
            InitializeComponent();

            _context = new ApplicationDbContext();
            _maquinaRepository = new MaquinaRepository(_context);

            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            CargarDatosMaquinas();
        }
        private void CargarDatosMaquinas()
        {
            // Siempre crear un nuevo contexto y repositorio para evitar caché
            using (var context = new ApplicationDbContext())
            {
                var maquinaRepository = new MaquinaRepository(context);
                var maquinas = maquinaRepository.ObtenerTodasLasMaquinas();
                dataGridView1.DataSource = maquinas.ToList();
                dataGridView1.Refresh(); // Forzar refresco visual

                if (dataGridView1.Columns["IdCliente"] != null)
                    dataGridView1.Columns["IdCliente"].Visible = false;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Cliente")
            {
                var maquina = dataGridView1.Rows[e.RowIndex].DataBoundItem as Maquina;
                if (maquina != null && maquina.Cliente != null)
                {
                    e.Value = maquina.Cliente.Nombre;
                    e.FormattingApplied = true;
                }
            }
        }

        private void btnNuevaMaquina_Click(object sender, EventArgs e)
        {
            FormNuevaMaquina formNuevaMaquina = new FormNuevaMaquina();
            if (formNuevaMaquina.ShowDialog() == DialogResult.OK)
            {
                CargarDatosMaquinas(); // Actualiza la grilla automáticamente
            }
        }

        private void btnEliminarMaquina_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Debe seleccionar una máquina de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var maquinaSeleccionada = dataGridView1.CurrentRow.DataBoundItem as Maquina;
            if (maquinaSeleccionada == null)
            {
                MessageBox.Show("No se pudo obtener la máquina seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro que desea eliminar la máquina con PATENTE: {maquinaSeleccionada.Patente}?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (confirmacion == DialogResult.No)
            {
                return;
            }
            try
            {
                bool eliminada = _maquinaRepository.EliminarMaquinaPorPatente(maquinaSeleccionada.Patente);
                if (eliminada)
                {
                    MessageBox.Show($"Máquina con PATENTE {maquinaSeleccionada.Patente} eliminada con éxito.",
                                    "Eliminación Exitosa",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatosMaquinas();
                }
                else
                {
                    MessageBox.Show($"No se encontró ninguna máquina con la patente: {maquinaSeleccionada.Patente}.",
                                    "Máquina No Encontrada",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al intentar eliminar la máquina: {ex.Message}",
                                "Error de Base de Datos",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnModificarMaquina_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Debe seleccionar una máquina de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var maquinaSeleccionada = dataGridView1.CurrentRow.DataBoundItem as Maquina;
            if (maquinaSeleccionada == null)
            {
                MessageBox.Show("No se pudo obtener la máquina seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                FormModificarMaquina formModificarMaquina = new FormModificarMaquina(maquinaSeleccionada);
                DialogResult result = formModificarMaquina.ShowDialog();
                if (result == DialogResult.OK)
                {
                    CargarDatosMaquinas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarDatosMaquinas();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
