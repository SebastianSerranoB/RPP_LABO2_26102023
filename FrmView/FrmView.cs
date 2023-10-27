using Entidades;

namespace FrmView
{
    public partial class FrmView : Form
    {
        private Fabrica fabrica;
        public FrmView()
        {
            InitializeComponent();
            this.InicializarFabrica();
            
        }

        private void FrmView_Load(object sender, EventArgs e)
        {
            this.cmbTipo.Items.Add("Automovil");
            this.cmbTipo.Items.Add("Camioneta");
            this.cmbTipo.Items.Add("Moto");

        }

        private void btnFabricar_Click(object sender, EventArgs e)
        {
            this.fabrica = this.fabrica + this.CrearVehiculo();
            this.Refrescar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lstVehiculos.SelectedItem != null)
            {
                Vehiculo vehiculoSeleccionado = (Vehiculo)this.lstVehiculos.SelectedItem;
                this.fabrica = this.fabrica - (Vehiculo)this.lstVehiculos.SelectedItem;
            }
            
            this.Refrescar();

        }


        private void InicializarFabrica()
        {
            this.fabrica = new Fabrica(10);
            Camioneta camioneta = new Camioneta(EPropulsion.Electrica, true);
            this.fabrica = this.fabrica + camioneta;
    
        }
        private void Refrescar()
        {
            this.cmbTipo.DataSource = null;
            this.cmbTipo.DataSource = this.fabrica.Vehiculos;
        }

        private Vehiculo CrearVehiculo()
        {

            if (this.cmbTipo.SelectedItem.ToString() == "Camioneta")
            { 
   
                    return new Camioneta(EPropulsion.Hibrida, false);
            }
            else if  (this.cmbTipo.SelectedItem.ToString() == "Moto")
            {
                return new Moto(EPropulsion.Electrica);
            }
            else
            {
                return new Automovil();
            }



            /*    switch (cmbTipo.SelectedItem.ToString())
            {
                case "Automovil":
                  
                    return new Automovil();

              
                case "Camioneta":
                    return new Camioneta(EPropulsion.Hibrida, false);
                   
              
                case "Moto":
                    return new Moto(EPropulsion.Electrica);

                
                  
            }

            return new Automovil();*/
        }


    }
}