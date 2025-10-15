namespace WinFormsTallerMecanico
{
    partial class FormModificarTurno
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
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxDescripcion = new TextBox();
            checkBoxActivo = new CheckBox();
            comboBoxLocalidad = new ComboBox();
            textBoxDomicilio = new TextBox();
            dateTimePickerTurno = new DateTimePicker();
            comboBoxMaquina = new ComboBox();
            comboBoxCliente = new ComboBox();
            btnGuardar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 278);
            label7.Name = "label7";
            label7.Size = new Size(87, 20);
            label7.TabIndex = 27;
            label7.Text = "Descripción";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 329);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 26;
            label6.Text = "Activo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 221);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 25;
            label5.Text = "Ciudad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 171);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 24;
            label4.Text = "Domicilio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 119);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 23;
            label3.Text = "Fecha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 72);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 22;
            label2.Text = "Maquina";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 21);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 21;
            label1.Text = "Cliente";
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Location = new Point(144, 275);
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(298, 27);
            textBoxDescripcion.TabIndex = 20;
            // 
            // checkBoxActivo
            // 
            checkBoxActivo.AutoSize = true;
            checkBoxActivo.Location = new Point(139, 328);
            checkBoxActivo.Name = "checkBoxActivo";
            checkBoxActivo.Size = new Size(18, 17);
            checkBoxActivo.TabIndex = 19;
            checkBoxActivo.UseVisualStyleBackColor = true;
            // 
            // comboBoxLocalidad
            // 
            comboBoxLocalidad.FormattingEnabled = true;
            comboBoxLocalidad.Location = new Point(139, 213);
            comboBoxLocalidad.Name = "comboBoxLocalidad";
            comboBoxLocalidad.Size = new Size(298, 28);
            comboBoxLocalidad.TabIndex = 18;
            // 
            // textBoxDomicilio
            // 
            textBoxDomicilio.Location = new Point(139, 164);
            textBoxDomicilio.Name = "textBoxDomicilio";
            textBoxDomicilio.Size = new Size(298, 27);
            textBoxDomicilio.TabIndex = 17;
            // 
            // dateTimePickerTurno
            // 
            dateTimePickerTurno.Location = new Point(139, 112);
            dateTimePickerTurno.Name = "dateTimePickerTurno";
            dateTimePickerTurno.Size = new Size(298, 27);
            dateTimePickerTurno.TabIndex = 16;
            // 
            // comboBoxMaquina
            // 
            comboBoxMaquina.FormattingEnabled = true;
            comboBoxMaquina.Location = new Point(139, 64);
            comboBoxMaquina.Name = "comboBoxMaquina";
            comboBoxMaquina.Size = new Size(298, 28);
            comboBoxMaquina.TabIndex = 15;
            // 
            // comboBoxCliente
            // 
            comboBoxCliente.FormattingEnabled = true;
            comboBoxCliente.Location = new Point(139, 13);
            comboBoxCliente.Name = "comboBoxCliente";
            comboBoxCliente.Size = new Size(298, 28);
            comboBoxCliente.TabIndex = 14;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(620, 38);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 28;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(620, 181);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 29;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormModificarTurno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnGuardar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxDescripcion);
            Controls.Add(checkBoxActivo);
            Controls.Add(comboBoxLocalidad);
            Controls.Add(textBoxDomicilio);
            Controls.Add(dateTimePickerTurno);
            Controls.Add(comboBoxMaquina);
            Controls.Add(comboBoxCliente);
            Name = "FormModificarTurno";
            Text = "FormModificarTurno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxDescripcion;
        private CheckBox checkBoxActivo;
        private ComboBox comboBoxLocalidad;
        private TextBox textBoxDomicilio;
        private DateTimePicker dateTimePickerTurno;
        private ComboBox comboBoxMaquina;
        private ComboBox comboBoxCliente;
        private Button btnGuardar;
        private Button btnSalir;
    }
}