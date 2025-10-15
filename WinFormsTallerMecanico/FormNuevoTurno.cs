using ClasesTallerMecanico.Data;
using ClasesTallerMecanico.Repository;

namespace WinFormsTallerMecanico
{
    public partial class FormNuevoTurno : Form
    {
        private ApplicationDbContext _context;
        private ClienteRepository _clienteRepository;
        private MaquinaRepository _maquinaRepository;
        private LocalidadRepository _localidadRepository;
        public FormNuevoTurno()
        {
            InitializeComponent();
            checkBoxActivo.Checked = true;
            _context = new ApplicationDbContext();
            _clienteRepository = new ClienteRepository(_context);
            _maquinaRepository = new MaquinaRepository(_context);
            _localidadRepository = new LocalidadRepository(_context);

            CargarClientesActivos();
            //CargarMaquinasActivas();
            CargarLocalidades();
            comboBoxCliente.SelectedIndexChanged += comboBoxCliente_SelectedIndexChanged;
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

        //private void CargarMaquinasActivas()
        //{
        //    var maquinasActivas = _maquinaRepository.ObtenerMaquinasActivas();
        //    comboBoxMaquina.DataSource = maquinasActivas;
        //    comboBoxMaquina.DisplayMember = "Nombre";
        //    comboBoxMaquina.ValueMember = "Id";
        //    if (maquinasActivas.Any())
        //    {
        //        comboBoxCliente.SelectedIndex = 0;
        //    }
        //}

        private void CargarLocalidades()
        {
            try
            {
                var localidades = _localidadRepository.ObtenerTodas();

                comboBoxLocalidad.DataSource = localidades;
                comboBoxLocalidad.DisplayMember = "Nombre";
                comboBoxLocalidad.ValueMember = "Id";

                if (localidades.Any())
                {
                    comboBoxLocalidad.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar Localidades: {ex.Message}", "Error de Carga",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

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

            var nuevoTurno = new ClasesTallerMecanico.Models.Turno
            {
                IdCliente = (int)comboBoxCliente.SelectedValue,
                IdMaquina = (int)comboBoxMaquina.SelectedValue,
                Fecha = dateTimePickerTurno.Value,
                DomicilioTrabajo = textBoxDomicilio.Text.Trim(),
                IdLocalidad = (int)comboBoxLocalidad.SelectedValue,
                Activo = checkBoxActivo.Checked,
                Descripcion = textBoxDescripcion.Text.Trim()
            };

            try
            {
                var turnoRepository = new ClasesTallerMecanico.Repository.TurnoRepository(_context);
                turnoRepository.GuardarTurno(nuevoTurno);

                MessageBox.Show("Turno guardado con éxito.", "Guardado Exitoso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar campos
                comboBoxCliente.SelectedIndex = 0;
                comboBoxMaquina.SelectedIndex = 0;
                dateTimePickerTurno.Value = DateTime.Now;
                textBoxDomicilio.Clear();
                comboBoxLocalidad.SelectedIndex = 0;
                checkBoxActivo.Checked = true;
                textBoxDescripcion.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar el Turno: {ex.Message}", "Error de Base de Datos",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void comboBoxMaquina_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (comboBoxCliente.SelectedValue is int idCliente)
        //    {
        //        var maquinas = _maquinaRepository.ObtenerMaquinasActivasPorCliente(idCliente);
        //        comboBoxMaquina.DataSource = maquinas;
        //        comboBoxMaquina.DisplayMember = "Nombre";
        //        comboBoxMaquina.ValueMember = "Id";
        //    }
        //}

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
    }
}
