using ClasesTallerMecanico.Data;
using ClasesTallerMecanico.Models;
using ClasesTallerMecanico.Repository;

namespace WinFormsTallerMecanico
{
    public partial class FormModificarTurno : Form
    {
        private readonly ApplicationDbContext _context;
        private readonly TurnoRepository _turnoRepository;
        private readonly ClienteRepository _clienteRepository;
        private readonly MaquinaRepository _maquinaRepository;
        private readonly LocalidadRepository _localidadRepository;
        private readonly int _idTurno;
        private Turno _turno;

        public FormModificarTurno(Turno turno)
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            _turnoRepository = new TurnoRepository(_context);
            _clienteRepository = new ClienteRepository(_context);
            _maquinaRepository = new MaquinaRepository(_context);
            _localidadRepository = new LocalidadRepository(_context);
            _idTurno = turno.Id;
            _turno = turno;
            CargarClientes();
            CargarMaquinas();
            CargarLocalidades();
            CargarDatosTurnoParaEdicion();
            btnGuardar.Click += btnGuardar_Click;
            comboBoxCliente.SelectedIndexChanged += comboBoxCliente_SelectedIndexChanged;
        }

        private void CargarClientes()
        {
            var clientes = _clienteRepository.ObtenerClientesActivos();
            comboBoxCliente.DataSource = clientes;
            comboBoxCliente.DisplayMember = "Nombre";
            comboBoxCliente.ValueMember = "Id";
        }

        private void CargarMaquinas()
        {
            var maquinas = _maquinaRepository.ObtenerMaquinasActivas();
            comboBoxMaquina.DataSource = maquinas;
            comboBoxMaquina.DisplayMember = "Nombre";
            comboBoxMaquina.ValueMember = "Id";
        }

        private void CargarLocalidades()
        {
            var localidades = _localidadRepository.ObtenerTodas();
            comboBoxLocalidad.DataSource = localidades;
            comboBoxLocalidad.DisplayMember = "Nombre";
            comboBoxLocalidad.ValueMember = "Id";
        }

        private void CargarDatosTurnoParaEdicion()
        {
            if (_turno != null)
            {
                comboBoxCliente.SelectedValue = _turno.IdCliente;
                comboBoxMaquina.SelectedValue = _turno.IdMaquina;
                dateTimePickerTurno.Value = _turno.Fecha;
                textBoxDomicilio.Text = _turno.DomicilioTrabajo;
                comboBoxLocalidad.SelectedValue = _turno.IdLocalidad;
                // checkBoxActivo.Checked = _turno.Activo; // Oculto, no editable
                textBoxDescripcion.Text = _turno.Descripcion;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (comboBoxCliente.SelectedValue == null ||
                comboBoxMaquina.SelectedValue == null ||
                string.IsNullOrWhiteSpace(textBoxDomicilio.Text) ||
                comboBoxLocalidad.SelectedValue == null ||
                string.IsNullOrWhiteSpace(textBoxDescripcion.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error de Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var turno = _turnoRepository.ObtenerTurnoPorId(_idTurno);
            if (turno != null)
            {
                turno.IdCliente = (int)comboBoxCliente.SelectedValue;
                turno.IdMaquina = (int)comboBoxMaquina.SelectedValue;
                turno.Fecha = dateTimePickerTurno.Value;
                turno.DomicilioTrabajo = textBoxDomicilio.Text.Trim();
                turno.IdLocalidad = (int)comboBoxLocalidad.SelectedValue;
                // turno.Activo = checkBoxActivo.Checked; // Oculto, no editable
                turno.Descripcion = textBoxDescripcion.Text.Trim();
                _context.SaveChanges();
                MessageBox.Show("Turno modificado con éxito.", "Modificación Exitosa",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("No se encontró el turno a modificar.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void comboBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCliente.SelectedValue is int idCliente)
            {
                var maquinas = _maquinaRepository.ObtenerMaquinasActivasPorCliente(idCliente);
                comboBoxMaquina.DataSource = maquinas;
                comboBoxMaquina.DisplayMember = "Nombre";
                comboBoxMaquina.ValueMember = "Id";
                if (maquinas.Any())
                    comboBoxMaquina.SelectedIndex = 0;
            }
            else
            {
                comboBoxMaquina.DataSource = null;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
