using ClasesTallerMecanico.Data;
using ClasesTallerMecanico.Models;
using ClasesTallerMecanico.Repository;

namespace WinFormsTallerMecanico
{
    public partial class FormLocalidad : Form
    {
        private ApplicationDbContext _context;
        private LocalidadRepository _localidadRepository;
        public FormLocalidad()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            _localidadRepository = new LocalidadRepository(_context);
        }

        private void FormLocalidad_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text) ||
                string.IsNullOrWhiteSpace(textBoxCP.Text) ||
                string.IsNullOrWhiteSpace(textBoxProvincia.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios (Not Null).", "Error de Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nuevaLocalidad = new Localidad
            {
                Nombre = textBoxNombre.Text.Trim(),
                CodigoPostal = textBoxCP.Text.Trim(),
                Provincia = textBoxProvincia.Text.Trim()
            };

            try
            {
                _localidadRepository.GuardarLocalidad(nuevaLocalidad);

                MessageBox.Show("Localidad guardada con éxito.", "Guardado Exitoso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBoxNombre.Clear();
                textBoxCP.Clear();
                textBoxProvincia.Clear();
                textBoxNombre.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar la Localidad: {ex.Message}", "Error de Base de Datos",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
