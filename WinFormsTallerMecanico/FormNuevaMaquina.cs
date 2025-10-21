using ClasesTallerMecanico.Data;
using ClasesTallerMecanico.Repository;

namespace WinFormsTallerMecanico
{
    public partial class FormNuevaMaquina : Form
    {
        private ApplicationDbContext _context;
        private MaquinaRepository _maquinaRepository;

        private ClienteRepository _clienteRepository;

        public FormNuevaMaquina()
        {
            InitializeComponent();
            checkBoxActivo.Checked = true;
            checkBoxActivo.Visible = false;
            label6.Visible = false;
            _context = new ApplicationDbContext();
            _maquinaRepository = new MaquinaRepository(_context);
            _clienteRepository = new ClienteRepository(_context);
            CargarClientesActivos();
        }

        private void CargarClientesActivos()
        {
            var clientesActivos = _clienteRepository.ObtenerClientesActivos();
            comboBoxCliente.DataSource = clientesActivos;
            comboBoxCliente.DisplayMember = "Nombre";
            comboBoxCliente.ValueMember = "Id";
            if (clientesActivos.Any())
            {
                comboBoxCliente.SelectedIndex = 0;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text) ||
                string.IsNullOrWhiteSpace(textBoxMarca.Text) ||
                string.IsNullOrWhiteSpace(textBoxMotor.Text) ||
                string.IsNullOrWhiteSpace(textBoxPatente.Text) ||
                comboBoxCliente.SelectedValue == null)
            {
                MessageBox.Show("Los campos Nombre, Marca, Motor, Patente y Cliente son obligatorios.", "Error de Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nuevaMaquina = new ClasesTallerMecanico.Models.Maquina
            {
                Nombre = textBoxNombre.Text.Trim(),
                Marca = textBoxMarca.Text.Trim(),
                Motor = textBoxMotor.Text.Trim(),
                Patente = textBoxPatente.Text.Trim(),
                IdCliente = (int)comboBoxCliente.SelectedValue,
                Activo = true // Siempre activo al crear
            };

            try
            {
                _maquinaRepository.GuardarMaquina(nuevaMaquina);
                MessageBox.Show("Máquina guardada con éxito.", "Guardado Exitoso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Para actualizar la lista automáticamente
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar la Máquina: {ex.Message}", "Error de Base de Datos",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
