namespace WinFormsTallerMecanico
{
    partial class FormModificarMaquina
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
            checkBoxActivo = new CheckBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBoxCliente = new ComboBox();
            textBoxPatente = new TextBox();
            textBoxMotor = new TextBox();
            textBoxMarca = new TextBox();
            textBoxNombre = new TextBox();
            btnGuardar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // checkBoxActivo
            // 
            checkBoxActivo.AutoSize = true;
            checkBoxActivo.Location = new Point(166, 280);
            checkBoxActivo.Name = "checkBoxActivo";
            checkBoxActivo.Size = new Size(18, 17);
            checkBoxActivo.TabIndex = 23;
            checkBoxActivo.UseVisualStyleBackColor = true;
            checkBoxActivo.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 284);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 22;
            label6.Text = "Activo";
            label6.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 239);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 21;
            label5.Text = "Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 191);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 20;
            label4.Text = "Patente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 140);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 19;
            label3.Text = "Motor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 93);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 18;
            label2.Text = "Marca";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 50);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 17;
            label1.Text = "Nombre";
            // 
            // comboBoxCliente
            // 
            comboBoxCliente.FormattingEnabled = true;
            comboBoxCliente.Location = new Point(166, 231);
            comboBoxCliente.Name = "comboBoxCliente";
            comboBoxCliente.Size = new Size(287, 28);
            comboBoxCliente.TabIndex = 16;
            // 
            // textBoxPatente
            // 
            textBoxPatente.Location = new Point(166, 184);
            textBoxPatente.Name = "textBoxPatente";
            textBoxPatente.Size = new Size(287, 27);
            textBoxPatente.TabIndex = 15;
            // 
            // textBoxMotor
            // 
            textBoxMotor.Location = new Point(166, 133);
            textBoxMotor.Name = "textBoxMotor";
            textBoxMotor.Size = new Size(287, 27);
            textBoxMotor.TabIndex = 14;
            // 
            // textBoxMarca
            // 
            textBoxMarca.Location = new Point(166, 86);
            textBoxMarca.Name = "textBoxMarca";
            textBoxMarca.Size = new Size(287, 27);
            textBoxMarca.TabIndex = 13;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(166, 43);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(287, 27);
            textBoxNombre.TabIndex = 12;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(624, 50);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 24;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(624, 182);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 25;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormModificarMaquina
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
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
            Name = "FormModificarMaquina";
            Text = "FormModificarMaquina";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxActivo;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxCliente;
        private TextBox textBoxPatente;
        private TextBox textBoxMotor;
        private TextBox textBoxMarca;
        private TextBox textBoxNombre;
        private Button btnGuardar;
        private Button btnSalir;
    }
}