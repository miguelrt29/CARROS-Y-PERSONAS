namespace Principal
{
    partial class FmCarros
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
        
            this.txtMarca.Location = new System.Drawing.Point(200, 100);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(200, 23);
            this.txtMarca.TabIndex = 0;
           
            this.txtModelo.Location = new System.Drawing.Point(200, 150);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(200, 23);
            this.txtModelo.TabIndex = 1;

           
            this.txtPlaca.Location = new System.Drawing.Point(200, 200);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(200, 23);
            this.txtPlaca.TabIndex = 2;
          
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.Text = "Marca:";
            
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.Text = "Modelo:";
          
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.Text = "Placa:";
           
            this.btnGuardar.Location = new System.Drawing.Point(120, 250);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 30);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            
            this.btnVer.Location = new System.Drawing.Point(230, 250);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(90, 30);
            this.btnVer.Text = "Ver";
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
           
            this.btnVolver.Location = new System.Drawing.Point(340, 250);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(90, 30);
            this.btnVolver.Text = "Volver";
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
         
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Name = "FmCarros";
            this.Text = "Gestión de Carros";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnVolver;
    }
}
