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
        public FormListaClientes()
        {
            InitializeComponent();

            _context = new ApplicationDbContext();
            _clienteRepository = new ClienteRepository(_context);

            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            CargarDatosClientes();
        }
        private void CargarDatosClientes()
        {
            var clientes = _clienteRepository.ObtenerTodosLosClientes();
            dataGridView1.DataSource = clientes.ToList();

            if (dataGridView1.Columns["IdLocalidad"] != null)
                dataGridView1.Columns["IdLocalidad"].Visible = false;
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
            FormNuevoCliente formNuevoCliente = new FormNuevoCliente();
            formNuevoCliente.ShowDialog();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {

            string cuilCuit = Interaction.InputBox(
                "Ingrese el CUIL/CUIT del cliente que desea desactivar (Eliminación Lógica):",
                "Desactivar Cliente",
                ""
            );


            if (string.IsNullOrWhiteSpace(cuilCuit))
            {

                MessageBox.Show("Operación cancelada o CUIL/CUIT no proporcionado.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string cuilCuitTrimmed = cuilCuit.Trim();


            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro que desea DESACTIVAR al cliente con CUIL/CUIT: {cuilCuitTrimmed}?",
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

                bool desactivado = _clienteRepository.EliminarClientePorCuilCuit(cuilCuitTrimmed);

                if (desactivado)
                {
                    MessageBox.Show($"Cliente con CUIL/CUIT {cuilCuitTrimmed} DESACTIVADO con éxito.",
                                    "Desactivación Exitosa",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);


                    // CargarDatosClientes(); 
                }
                else
                {
                    MessageBox.Show($"No se encontró ningún cliente activo o inactivo con el CUIL/CUIT: {cuilCuitTrimmed}.",
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
            string cuilCuit = Interaction.InputBox(
                "Ingrese el CUIL/CUIT del cliente que desea MODIFICAR:",
                "Modificar Cliente",
                ""
            );

            if (string.IsNullOrWhiteSpace(cuilCuit))
            {
                MessageBox.Show("Operación cancelada o CUIL/CUIT no proporcionado.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string cuilCuitTrimmed = cuilCuit.Trim();

            try
            {

                Cliente clienteExistente = _clienteRepository.ObtenerClientePorCuilCuit(cuilCuitTrimmed);
                if (clienteExistente == null)
                {
                    MessageBox.Show($"No se encontró ningún cliente con el CUIL/CUIT: {cuilCuitTrimmed}.",
                                    "Cliente No Encontrado",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                FormModificarCliente formModificarCliente = new FormModificarCliente(cuilCuitTrimmed);
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
