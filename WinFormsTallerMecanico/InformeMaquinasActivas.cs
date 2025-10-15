using ClasesTallerMecanico.Data;
using ClasesTallerMecanico.Models;
using ClasesTallerMecanico.Repository;

namespace WinFormsTallerMecanico
{
    public partial class InformeMaquinasActivas : Form
    {
        private ApplicationDbContext _context;
        private MaquinaRepository _maquinaRepository;

        public InformeMaquinasActivas()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            _maquinaRepository = new MaquinaRepository(_context);
            dataGridMaquinasActivas.CellFormatting += dataGridView1_CellFormatting;
            CargarMaquinasActivas();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridMaquinasActivas.Columns[e.ColumnIndex].Name == "Cliente")
            {
                var maquina = dataGridMaquinasActivas.Rows[e.RowIndex].DataBoundItem as Maquina;
                if (maquina != null && maquina.Cliente != null)
                {
                    e.Value = maquina.Cliente.Nombre;
                    e.FormattingApplied = true;
                }
            }
        }
        private void CargarMaquinasActivas()
        {
            var maquinasActivas = _maquinaRepository.ObtenerMaquinasActivas();
            dataGridMaquinasActivas.DataSource = maquinasActivas;
            if (dataGridMaquinasActivas.Columns["IdCliente"] != null)
                dataGridMaquinasActivas.Columns["IdCliente"].Visible = false;
        }
        private void dataGridMaquinasActivas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
