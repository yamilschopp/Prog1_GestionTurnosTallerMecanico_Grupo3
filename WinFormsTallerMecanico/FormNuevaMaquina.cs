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

            var _context = new ClasesTallerMecanico.Data.ApplicationDbContext();
            var _maquinaRepository = new ClasesTallerMecanico.Repository.MaquinaRepository(_context);

            var nuevaMaquina = new ClasesTallerMecanico.Models.Maquina
            {
                Nombre = textBoxNombre.Text.Trim(),
                Marca = textBoxMarca.Text.Trim(),
                Motor = textBoxMotor.Text.Trim(),
                Patente = textBoxPatente.Text.Trim(),
                IdCliente = (int)comboBoxCliente.SelectedValue,
                Activo = checkBoxActivo.Checked
            };

            try
            {
                _maquinaRepository.GuardarMaquina(nuevaMaquina);

                MessageBox.Show("Máquina guardada con éxito.", "Guardado Exitoso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBoxNombre.Clear();
                textBoxMarca.Clear();
                textBoxMotor.Clear();
                textBoxPatente.Clear();
                if (comboBoxCliente.Items.Count > 0) comboBoxCliente.SelectedIndex = 0;
                checkBoxActivo.Checked = false;
                textBoxNombre.Focus();
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
