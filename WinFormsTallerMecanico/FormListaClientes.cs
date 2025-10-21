using ClasesTallerMecanico.Data;
using ClasesTallerMecanico.Models;
using ClasesTallerMecanico.Repository;
using Microsoft.VisualBasic;

namespace WinFormsTallerMecanico
{
    public partial class FormListaClientes : Form
    {
        private ApplicationDbContext _context;
        private ClienteRepository _clienteRepository;
        private LocalidadRepository _localidadRepository;
        public FormListaClientes()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            _clienteRepository = new ClienteRepository(_context);
            _localidadRepository = new LocalidadRepository(_context);
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            CargarDatosClientes();
        }
        private void CargarDatosClientes()
        {
            // Siempre crear un nuevo contexto y repositorio para evitar caché
            using (var context = new ApplicationDbContext())
            {
                var clienteRepository = new ClienteRepository(context);
                var clientes = clienteRepository.ObtenerTodosLosClientes();
                dataGridView1.DataSource = clientes.ToList();
                dataGridView1.Refresh(); // Forzar refresco visual

                if (dataGridView1.Columns["IdLocalidad"] != null)
                    dataGridView1.Columns["IdLocalidad"].Visible = false;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Localidad")
            {
                var cliente = dataGridView1.Rows[e.RowIndex].DataBoundItem as Cliente;
                if (cliente != null && cliente.Localidad != null)
                {
                    e.Value = cliente.Localidad.Nombre;
                    e.FormattingApplied = true;
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarDatosClientes();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            var localidades = _localidadRepository.ObtenerTodas();
            if (localidades == null || localidades.Count == 0)
            {
                MessageBox.Show("Debe cargar al menos una localidad antes de poder dar de alta un cliente.", "Localidad requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FormNuevoCliente formNuevoCliente = new FormNuevoCliente();
            if (formNuevoCliente.ShowDialog() == DialogResult.OK)
            {
                CargarDatosClientes(); // Actualiza la grilla automáticamente
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Debe seleccionar un cliente de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var clienteSeleccionado = dataGridView1.CurrentRow.DataBoundItem as Cliente;
            if (clienteSeleccionado == null)
            {
                MessageBox.Show("No se pudo obtener el cliente seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro que desea DESACTIVAR al cliente con CUIL/CUIT: {clienteSeleccionado.CuilCuit}?",
                "Confirmar Desactivación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (confirmacion == DialogResult.No)
            {
                return;
            }
            try
            {
                bool desactivado = _clienteRepository.EliminarClientePorCuilCuit(clienteSeleccionado.CuilCuit);
                if (desactivado)
                {
                    MessageBox.Show($"Cliente con CUIL/CUIT {clienteSeleccionado.CuilCuit} DESACTIVADO con éxito.",
                                    "Desactivación Exitosa",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatosClientes();
                }
                else
                {
                    MessageBox.Show($"No se encontró ningún cliente activo o inactivo con el CUIL/CUIT: {clienteSeleccionado.CuilCuit}.",
                                    "Cliente No Encontrado",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al intentar desactivar el Cliente: {ex.Message}",
                                "Error de Base de Datos",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnModificarCliente_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Debe seleccionar un cliente de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var clienteSeleccionado = dataGridView1.CurrentRow.DataBoundItem as Cliente;
            if (clienteSeleccionado == null)
            {
                MessageBox.Show("No se pudo obtener el cliente seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                FormModificarCliente formModificarCliente = new FormModificarCliente(clienteSeleccionado.CuilCuit);
                DialogResult result = formModificarCliente.ShowDialog();
                if (result == DialogResult.OK)
                {
                    CargarDatosClientes();
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
