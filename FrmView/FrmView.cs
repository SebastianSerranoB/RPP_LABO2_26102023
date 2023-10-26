namespace FrmView
{
    public partial class FrmView : Form
    {
        public FrmView()
        {
            InitializeComponent();
        }

        private void FrmView_Load(object sender, EventArgs e)
        {
            this.cmbTipo.Items.Add("Automovil");
            this.cmbTipo.Items.Add("Camioneta");
            this.cmbTipo.Items.Add("Moto");

        }

       
    }
}