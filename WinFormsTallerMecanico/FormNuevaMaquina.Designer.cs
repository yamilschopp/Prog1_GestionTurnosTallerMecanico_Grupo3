namespace WinFormsTallerMecanico
{
    partial class FormNuevaMaquina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxNombre = new TextBox();
            textBoxMarca = new TextBox();
            textBoxMotor = new TextBox();
            textBoxPatente = new TextBox();
            comboBoxCliente = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            checkBoxActivo = new CheckBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(150, 32);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(287, 27);
            textBoxNombre.TabIndex = 0;
            // 
            // textBoxMarca
            // 
            textBoxMarca.Location = new Point(150, 75);
            textBoxMarca.Name = "textBoxMarca";
            textBoxMarca.Size = new Size(287, 27);
            textBoxMarca.TabIndex = 1;
            // 
            // textBoxMotor
            // 
            textBoxMotor.Location = new Point(150, 122);
            textBoxMotor.Name = "textBoxMotor";
            textBoxMotor.Size = new Size(287, 27);
            textBoxMotor.TabIndex = 2;
            // 
            // textBoxPatente
            // 
            textBoxPatente.Location = new Point(150, 173);
            textBoxPatente.Name = "textBoxPatente";
            textBoxPatente.Size = new Size(287, 27);
            textBoxPatente.TabIndex = 3;
            // 
            // comboBoxCliente
            // 
            comboBoxCliente.FormattingEnabled = true;
            comboBoxCliente.Location = new Point(150, 220);
            comboBoxCliente.Name = "comboBoxCliente";
            comboBoxCliente.Size = new Size(287, 28);
            comboBoxCliente.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 39);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 5;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 82);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 6;
            label2.Text = "Marca";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 129);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 7;
            label3.Text = "Motor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 180);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 8;
            label4.Text = "Patente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 228);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 9;
            label5.Text = "Cliente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 273);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 10;
            label6.Text = "Activo";
            // 
            // checkBoxActivo
            // 
            checkBoxActivo.AutoSize = true;
            checkBoxActivo.Location = new Point(150, 269);
            checkBoxActivo.Name = "checkBoxActivo";
            checkBoxActivo.Size = new Size(18, 17);
            checkBoxActivo.TabIndex = 11;
            checkBoxActivo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(640, 73);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(646, 160);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormNuevaMaquina
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(checkBoxActivo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxCliente);
            Controls.Add(textBoxPatente);
            Controls.Add(textBoxMotor);
            Controls.Add(textBoxMarca);
            Controls.Add(textBoxNombre);
            Name = "FormNuevaMaquina";
            Text = "FormNuevaMaquina";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNombre;
        private TextBox textBoxMarca;
        private TextBox textBoxMotor;
        private TextBox textBoxPatente;
        private ComboBox comboBoxCliente;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private CheckBox checkBoxActivo;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}