using ClasesTallerMecanico.Data;
using ClasesTallerMecanico.Repository;

namespace WinFormsTallerMecanico
{
    public partial class FormModificarCliente : Form
    {
        private readonly ApplicationDbContext _context;
        private readonly ClienteRepository _clienteRepository;
        private readonly LocalidadRepository _localidadRepository;
        private readonly string _cuilCuitCliente;

        public FormModificarCliente(string cuilCuit)
        {
            InitializeComponent();

            _cuilCuitCliente = cuilCuit;
            _context = new ApplicationDbContext();
            _clienteRepository = new ClienteRepository(_context);
            _localidadRepository = new LocalidadRepository(_context);

            CargarLocalidades();
            CargarDatosClienteParaEdicion();
        }

        private void CargarLocalidades()
        {
            var localidades = _localidadRepository.ObtenerTodas();
            comboBoxLocalidad.DataSource = localidades;
            comboBoxLocalidad.DisplayMember = "Nombre";
            comboBoxLocalidad.ValueMember = "Id";
        }

        private void CargarDatosClienteParaEdicion()
        {
            var cliente = _clienteRepository.ObtenerClientePorCuilCuit(_cuilCuitCliente);
            if (cliente != null)
            {
                textBoxNombre.Text = cliente.Nombre;
                textBoxDomicilio.Text = cliente.Domicilio;
                textBoxCuilCuit.Text = cliente.CuilCuit;
                textBoxCondFiscal.Text = cliente.CondFiscal;
                textBoxTelefono.Text = cliente.Telefono;
                textBoxCorreo.Text = cliente.Correo;
                checkBoxActivo.Checked = cliente.Activo;
                comboBoxLocalidad.SelectedValue = cliente.IdLocalidad;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var cliente = _clienteRepository.ObtenerClientePorCuilCuit(_cuilCuitCliente);
            if (cliente != null)
            {
                // Validación de CUIL/CUIT: solo números, sin espacios ni guiones, y exactamente 11 dígitos
                string cuilCuitLimpio = System.Text.RegularExpressions.Regex.Replace(textBoxCuilCuit.Text, "[^0-9]", "");
                if (cuilCuitLimpio.Length != 11)
                {
                    MessageBox.Show("El CUIL/CUIT debe tener exactamente 11 dígitos numéricos (sin letras, espacios ni guiones).", "Error de Validación",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                cliente.Nombre = textBoxNombre.Text.Trim();
                cliente.Domicilio = textBoxDomicilio.Text.Trim();
                cliente.CuilCuit = cuilCuitLimpio;
                cliente.CondFiscal = textBoxCondFiscal.Text.Trim();
                cliente.Telefono = textBoxTelefono.Text.Trim();
                cliente.Correo = textBoxCorreo.Text.Trim();
                cliente.Activo = checkBoxActivo.Checked;
                cliente.IdLocalidad = (int)comboBoxLocalidad.SelectedValue;

                _context.SaveChanges();

                MessageBox.Show("Cliente modificado con éxito.", "Modificación Exitosa",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("No se encontró el cliente a modificar.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
