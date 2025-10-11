namespace WinFormsTallerMecanico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLocalidad_Click(object sender, EventArgs e)
        {
            FormLocalidad formLocalidad = new FormLocalidad();

            formLocalidad.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente();

            formCliente.ShowDialog();
        }
    }
}
