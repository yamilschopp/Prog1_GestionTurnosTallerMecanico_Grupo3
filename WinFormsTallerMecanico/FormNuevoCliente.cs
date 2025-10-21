using ClasesTallerMecanico.Data;
using ClasesTallerMecanico.Models;
using ClasesTallerMecanico.Repository;

namespace WinFormsTallerMecanico
{
    public partial class FormNuevoCliente : Form
    {
        private ApplicationDbContext _context;
        private ClienteRepository _clienteRepository;
        private LocalidadRepository _localidadRepository;
        public FormNuevoCliente()
        {
            InitializeComponent();
            checkBoxActivo.Checked = true;
            checkBoxActivo.Visible = false;
            label8.Visible = false;
            _context = new ApplicationDbContext();
            _clienteRepository = new ClienteRepository(_context);
            _localidadRepository = new LocalidadRepository(_context);

            CargarLocalidades();
        }

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
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text) ||
                string.IsNullOrWhiteSpace(textBoxDomicilio.Text) ||
                string.IsNullOrWhiteSpace(textBoxCuilCuit.Text) ||
                comboBoxLocalidad.SelectedValue == null)
            {
                MessageBox.Show("Los campos Nombre, Domicilio, CUIL/CUIT y Localidad son obligatorios.", "Error de Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validación de CUIL/CUIT: solo números, sin espacios ni guiones, y exactamente 11 dígitos
            string cuilCuitLimpio = System.Text.RegularExpressions.Regex.Replace(textBoxCuilCuit.Text, "[^0-9]", "");
            if (cuilCuitLimpio.Length != 11)
            {
                MessageBox.Show("El CUIL/CUIT debe tener exactamente 11 dígitos numéricos (sin letras, espacios ni guiones).", "Error de Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nuevoCliente = new Cliente
            {
                Nombre = textBoxNombre.Text.Trim(),
                Domicilio = textBoxDomicilio.Text.Trim(),
                Telefono = textBoxTelefono.Text.Trim(),
                Correo = textBoxCorreo.Text.Trim(),
                IdLocalidad = (int)comboBoxLocalidad.SelectedValue,
                Activo = true, // Siempre activo al crear
                CuilCuit = cuilCuitLimpio,
                CondFiscal = textBoxCondFiscal.Text.Trim()
            };

            try
            {
                _clienteRepository.GuardarCliente(nuevoCliente);
                MessageBox.Show("Cliente guardado con éxito.", "Guardado Exitoso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Para actualizar la lista automáticamente
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar el Cliente: {ex.Message}", "Error de Base de Datos",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //FormListaClientes formListaClientes = new FormListaClientes();
            //formListaClientes.ShowDialog();

            this.Close();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxCuilCuit.Text))
            {
                MessageBox.Show("Debe ingresar el CUIL/CUIT del cliente a eliminar.", "Error de Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cuilCuit = textBoxCuilCuit.Text.Trim();

            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro que desea eliminar al cliente con CUIL/CUIT: {cuilCuit}?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion == DialogResult.No)
            {
                return;
            }

            try
            {
                bool eliminado = _clienteRepository.EliminarClientePorCuilCuit(cuilCuit);

                if (eliminado)
                {
                    MessageBox.Show("Cliente eliminado con éxito.", "Eliminación Exitosa",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBoxNombre.Clear();
                    textBoxDomicilio.Clear();
                    textBoxCuilCuit.Clear();
                    textBoxCondFiscal.Clear();
                    textBoxTelefono.Clear();
                    textBoxCorreo.Clear();
                    if (comboBoxLocalidad.Items.Count > 0) comboBoxLocalidad.SelectedIndex = 0;
                    textBoxNombre.Focus();
                }
                else
                {
                    MessageBox.Show("No se encontró ningún cliente con ese CUIL/CUIT.", "Cliente No Encontrado",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al intentar eliminar el Cliente: {ex.Message}", "Error de Base de Datos",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
