namespace Principal
{
    partial class FmPersonas
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

        private void InitializeComponent()
        {
            btnGuardar = new Button();
            tbName = new TextBox();
            tbDoc = new TextBox();
            tbTel = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnVer = new Button();
            btnCarros = new Button();
            SuspendLayout();
          
            btnGuardar.Location = new Point(227, 303);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(128, 46);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
           
            tbName.Location = new Point(253, 129);
            tbName.Name = "tbName";
            tbName.Size = new Size(206, 23);
            tbName.TabIndex = 1;
            
            tbDoc.Location = new Point(253, 187);
            tbDoc.Name = "tbDoc";
            tbDoc.Size = new Size(206, 23);
            tbDoc.TabIndex = 2;
          
            tbTel.Location = new Point(253, 251);
            tbTel.Name = "tbTel";
            tbTel.Size = new Size(206, 23);
            tbTel.TabIndex = 3;
         
            label1.AutoSize = true;
            label1.Location = new Point(253, 111);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
          
            label2.AutoSize = true;
            label2.Location = new Point(253, 169);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 5;
            label2.Text = "Documento";
           
            label3.AutoSize = true;
            label3.Location = new Point(253, 233);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 6;
            label3.Text = "Telefono";
         
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(253, 50);
            label4.Name = "label4";
            label4.Size = new Size(107, 32);
            label4.TabIndex = 7;
            label4.Text = "Personas";
            
            btnVer.Location = new Point(361, 303);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(128, 46);
            btnVer.TabIndex = 8;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
         
            btnCarros.Location = new Point(495, 303);
            btnCarros.Name = "btnCarros";
            btnCarros.Size = new Size(128, 46);
            btnCarros.TabIndex = 9;
            btnCarros.Text = "Carros";
            btnCarros.UseVisualStyleBackColor = true;
            btnCarros.Click += btnCarros_Click;
          
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCarros);
            Controls.Add(btnVer);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbTel);
            Controls.Add(tbDoc);
            Controls.Add(tbName);
            Controls.Add(btnGuardar);
            Name = "FmPersonas";
            Text = "FmPersonas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private TextBox tbName;
        private TextBox tbDoc;
        private TextBox tbTel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnVer;
        private Button btnCarros;
    }
}
