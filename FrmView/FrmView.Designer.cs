namespace FrmView
{
    partial class FrmView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmView));
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lstVehiculos = new System.Windows.Forms.ListBox();
            this.btnFabricar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.pcbFabrica = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFabrica)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Automovil",
            "Camioneta",
            "Moto"});
            this.cmbTipo.Location = new System.Drawing.Point(602, 56);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(176, 23);
            this.cmbTipo.TabIndex = 0;
            // 
            // lstVehiculos
            // 
            this.lstVehiculos.FormattingEnabled = true;
            this.lstVehiculos.HorizontalScrollbar = true;
            this.lstVehiculos.ItemHeight = 15;
            this.lstVehiculos.Location = new System.Drawing.Point(12, 79);
            this.lstVehiculos.Name = "lstVehiculos";
            this.lstVehiculos.Size = new System.Drawing.Size(568, 364);
            this.lstVehiculos.TabIndex = 1;
            // 
            // btnFabricar
            // 
            this.btnFabricar.Location = new System.Drawing.Point(602, 310);
            this.btnFabricar.Name = "btnFabricar";
            this.btnFabricar.Size = new System.Drawing.Size(168, 65);
            this.btnFabricar.TabIndex = 2;
            this.btnFabricar.Text = "Fabricar";
            this.btnFabricar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(602, 381);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(168, 57);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipo.Location = new System.Drawing.Point(602, 38);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(101, 15);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Tipo de Vehiculo:";
            // 
            // pcbFabrica
            // 
            this.pcbFabrica.Image = ((System.Drawing.Image)(resources.GetObject("pcbFabrica.Image")));
            this.pcbFabrica.Location = new System.Drawing.Point(633, 162);
            this.pcbFabrica.Name = "pcbFabrica";
            this.pcbFabrica.Size = new System.Drawing.Size(70, 83);
            this.pcbFabrica.TabIndex = 5;
            this.pcbFabrica.TabStop = false;
            // 
            // FrmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pcbFabrica);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnFabricar);
            this.Controls.Add(this.lstVehiculos);
            this.Controls.Add(this.cmbTipo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmView";
            this.Text = "Fabrica de Vehiculos";
            ((System.ComponentModel.ISupportInitialize)(this.pcbFabrica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbTipo;
        private ListBox lstVehiculos;
        private Button btnFabricar;
        private Button btnEliminar;
        private Label lblTipo;
        private PictureBox pcbFabrica;
    }
}