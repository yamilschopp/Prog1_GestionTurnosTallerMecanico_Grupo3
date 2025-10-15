namespace WinFormsTallerMecanico
{
    partial class FormGeneral
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
            btnMaquina = new Button();
            btnTurno = new Button();
            SuspendLayout();
            // 
            // btnLocalidad
            // 
            btnLocalidad.Location = new Point(246, 84);
            btnLocalidad.Name = "btnLocalidad";
            btnLocalidad.Size = new Size(224, 29);
            btnLocalidad.TabIndex = 0;
            btnLocalidad.Text = "Formulario localidad";
            btnLocalidad.UseVisualStyleBackColor = true;
            btnLocalidad.Click += btnLocalidad_Click;
            // 
            // btnCliente
            // 
            btnCliente.Location = new Point(246, 154);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(224, 29);
            btnCliente.TabIndex = 1;
            btnCliente.Text = "Formulario cliente";
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnMaquina
            // 
            btnMaquina.Location = new Point(246, 228);
            btnMaquina.Name = "btnMaquina";
            btnMaquina.Size = new Size(224, 29);
            btnMaquina.TabIndex = 2;
            btnMaquina.Text = "Formulario Maquinas";
            btnMaquina.UseVisualStyleBackColor = true;
            btnMaquina.Click += button1_Click;
            // 
            // btnTurno
            // 
            btnTurno.Location = new Point(246, 304);
            btnTurno.Name = "btnTurno";
            btnTurno.Size = new Size(224, 29);
            btnTurno.TabIndex = 3;
            btnTurno.Text = "Formulario turnos";
            btnTurno.UseVisualStyleBackColor = true;
            btnTurno.Click += btnTurno_Click;
            // 
            // FormGeneral
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTurno);
            Controls.Add(btnMaquina);
            Controls.Add(btnCliente);
            Controls.Add(btnLocalidad);
            Name = "FormGeneral";
            Text = "FormGeneral";
            Load += FormGeneral_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnLocalidad;
        private Button btnCliente;
        private Button btnMaquina;
        private Button btnTurno;
    }
}
