namespace WinFormsTallerMecanico
{
    partial class Form1
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
            btnLocalidad = new Button();
            btnCliente = new Button();
            SuspendLayout();
            // 
            // btnLocalidad
            // 
            btnLocalidad.Location = new Point(86, 43);
            btnLocalidad.Name = "btnLocalidad";
            btnLocalidad.Size = new Size(166, 29);
            btnLocalidad.TabIndex = 0;
            btnLocalidad.Text = "Pantalla localidad";
            btnLocalidad.UseVisualStyleBackColor = true;
            btnLocalidad.Click += btnLocalidad_Click;
            // 
            // btnCliente
            // 
            btnCliente.Location = new Point(86, 105);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(166, 29);
            btnCliente.TabIndex = 1;
            btnCliente.Text = "Pantalla cliente";
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCliente);
            Controls.Add(btnLocalidad);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnLocalidad;
        private Button btnCliente;
    }
}
