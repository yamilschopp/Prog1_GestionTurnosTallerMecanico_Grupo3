namespace WinFormsTallerMecanico
{
    public partial class FormGeneral : Form
    {
        public FormGeneral()
        {
            InitializeComponent();
        }

        private void FormGeneral_Load(object sender, EventArgs e)
        {

        }

        private void btnLocalidad_Click(object sender, EventArgs e)
        {
            FormLocalidad formLocalidad = new FormLocalidad();

            formLocalidad.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FormListaClientes formListaClientes = new FormListaClientes();

            formListaClientes.ShowDialog();
            //FormNuevoCliente formNuevoCliente = new FormNuevoCliente();

            //formNuevoCliente.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FormNuevaMaquina formNuevaMaquina = new FormNuevaMaquina();

            //formNuevaMaquina.ShowDialog();
            FormListaMaquinas formListaMaquina = new FormListaMaquinas();

            formListaMaquina.ShowDialog();
        }

        private void btnTurno_Click(object sender, EventArgs e)
        {
            //FormNuevoTurno formNuevoTurno = new FormNuevoTurno();

            //formNuevoTurno.ShowDialog();
            FormListaTurnos formListaTurnos = new FormListaTurnos();

            formListaTurnos.ShowDialog();
        }
    }
}
