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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnLocalidad
            // 
            btnLocalidad.Location = new Point(72, 102);
            btnLocalidad.Name = "btnLocalidad";
            btnLocalidad.Size = new Size(224, 29);
            btnLocalidad.TabIndex = 0;
            btnLocalidad.Text = "Formulario localidad";
            btnLocalidad.UseVisualStyleBackColor = true;
            btnLocalidad.Click += btnLocalidad_Click;
            // 
            // btnCliente
            // 
            btnCliente.Location = new Point(72, 172);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(224, 29);
            btnCliente.TabIndex = 1;
            btnCliente.Text = "Formulario cliente";
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnMaquina
            // 
            btnMaquina.Location = new Point(72, 246);
            btnMaquina.Name = "btnMaquina";
            btnMaquina.Size = new Size(224, 29);
            btnMaquina.TabIndex = 2;
            btnMaquina.Text = "Formulario Maquinas";
            btnMaquina.UseVisualStyleBackColor = true;
            btnMaquina.Click += button1_Click;
            // 
            // btnTurno
            // 
            btnTurno.Location = new Point(72, 322);
            btnTurno.Name = "btnTurno";
            btnTurno.Size = new Size(224, 29);
            btnTurno.TabIndex = 3;
            btnTurno.Text = "Formulario turnos";
            btnTurno.UseVisualStyleBackColor = true;
            btnTurno.Click += btnTurno_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 43);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 4;
            label1.Text = "Ingreso de datos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(565, 43);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 5;
            label2.Text = "Informes";
            // 
            // button1
            // 
            button1.Location = new Point(502, 102);
            button1.Name = "button1";
            button1.Size = new Size(198, 74);
            button1.TabIndex = 6;
            button1.Text = "Informe de maquinas activas";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(502, 232);
            button2.Name = "button2";
            button2.Size = new Size(198, 74);
            button2.TabIndex = 7;
            button2.Text = "Informe de Turnos activos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(673, 409);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormGeneral
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnTurno);
            Controls.Add(btnMaquina);
            Controls.Add(btnCliente);
            Controls.Add(btnLocalidad);
            Name = "FormGeneral";
            Text = "FormGeneral";
            Load += FormGeneral_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLocalidad;
        private Button btnCliente;
        private Button btnMaquina;
        private Button btnTurno;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button btnSalir;
    }
}
