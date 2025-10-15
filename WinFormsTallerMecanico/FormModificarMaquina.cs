using ClasesTallerMecanico.Data;
using ClasesTallerMecanico.Models;
using ClasesTallerMecanico.Repository;

namespace WinFormsTallerMecanico
{
    public partial class FormModificarMaquina : Form
    {
        private readonly ApplicationDbContext _context;
        private readonly MaquinaRepository _maquinaRepository;
        private readonly ClienteRepository _clienteRepository;
        private readonly int _idMaquina;
        private Maquina _maquina;

        public FormModificarMaquina(Maquina maquina)
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            _maquinaRepository = new MaquinaRepository(_context);
            _clienteRepository = new ClienteRepository(_context);
            _idMaquina = maquina.Id;
            _maquina = maquina;
            CargarClientesActivos();
            CargarDatosMaquinaParaEdicion();
        }

        private void CargarClientesActivos()
        {
            var clientesActivos = _clienteRepository.ObtenerClientesActivos();
            comboBoxCliente.DataSource = clientesActivos;
            comboBoxCliente.DisplayMember = "Nombre";
            comboBoxCliente.ValueMember = "Id";
        }

        private void CargarDatosMaquinaParaEdicion()
        {
            if (_maquina != null)
            {
                textBoxNombre.Text = _maquina.Nombre;
                textBoxMarca.Text = _maquina.Marca;
                textBoxMotor.Text = _maquina.Motor;
                textBoxPatente.Text = _maquina.Patente;
                checkBoxActivo.Checked = _maquina.Activo;
                comboBoxCliente.SelectedValue = _maquina.IdCliente;
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

            var maquina = _maquinaRepository.ObtenerMaquinaPorPatente(_maquina.Patente);
            if (maquina != null)
            {
                maquina.Nombre = textBoxNombre.Text.Trim();
                maquina.Marca = textBoxMarca.Text.Trim();
                maquina.Motor = textBoxMotor.Text.Trim();
                maquina.Patente = textBoxPatente.Text.Trim();
                maquina.IdCliente = (int)comboBoxCliente.SelectedValue;
                maquina.Activo = checkBoxActivo.Checked;

                _context.SaveChanges();

                MessageBox.Show("Máquina modificada con éxito.", "Modificación Exitosa",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("No se encontró la máquina a modificar.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
