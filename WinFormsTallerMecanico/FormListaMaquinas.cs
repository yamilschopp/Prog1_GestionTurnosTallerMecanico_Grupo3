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
            var maquinas = _maquinaRepository.ObtenerTodasLasMaquinas();
            dataGridView1.DataSource = maquinas.ToList();

            if (dataGridView1.Columns["IdCliente"] != null)
                dataGridView1.Columns["IdCliente"].Visible = false;

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
            formNuevaMaquina.ShowDialog();
        }

        private void btnEliminarMaquina_Click(object sender, EventArgs e)
        {
            string patente = Interaction.InputBox(
                "Ingrese la PATENTE de la máquina que desea eliminar:",
                "Eliminar Máquina",
                ""
            );

            if (string.IsNullOrWhiteSpace(patente))
            {
                MessageBox.Show("Operación cancelada o patente no proporcionada.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string patenteTrimmed = patente.Trim();

            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro que desea eliminar la máquina con PATENTE: {patenteTrimmed}?",
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
                bool eliminada = _maquinaRepository.EliminarMaquinaPorPatente(patenteTrimmed);

                if (eliminada)
                {
                    MessageBox.Show($"Máquina con PATENTE {patenteTrimmed} eliminada con éxito.",
                                    "Eliminación Exitosa",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatosMaquinas();
                }
                else
                {
                    MessageBox.Show($"No se encontró ninguna máquina con la patente: {patenteTrimmed}.",
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
            string patente = Interaction.InputBox(
                "Ingrese la PATENTE de la máquina que desea MODIFICAR:",
                "Modificar Máquina",
                ""
            );

            if (string.IsNullOrWhiteSpace(patente))
            {
                MessageBox.Show("Operación cancelada o patente no proporcionada.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string patenteTrimmed = patente.Trim();

            try
            {
                Maquina maquinaExistente = _maquinaRepository.ObtenerMaquinaPorPatente(patenteTrimmed);
                if (maquinaExistente == null)
                {
                    MessageBox.Show($"No se encontró ninguna máquina con la patente: {patenteTrimmed}.",
                                    "Máquina No Encontrada",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                FormModificarMaquina formModificarMaquina = new FormModificarMaquina(maquinaExistente);
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
