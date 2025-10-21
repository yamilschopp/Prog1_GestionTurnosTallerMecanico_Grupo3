namespace WinFormsTallerMecanico
{
    partial class FormNuevoTurno
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
            comboBoxCliente = new ComboBox();
            comboBoxMaquina = new ComboBox();
            dateTimePickerTurno = new DateTimePicker();
            textBoxDomicilio = new TextBox();
            comboBoxLocalidad = new ComboBox();
            checkBoxActivo = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            textBoxDescripcion = new TextBox();
            SuspendLayout();
            // 
            // comboBoxCliente
            // 
            comboBoxCliente.FormattingEnabled = true;
            comboBoxCliente.Location = new Point(132, 18);
            comboBoxCliente.Name = "comboBoxCliente";
            comboBoxCliente.Size = new Size(298, 28);
            comboBoxCliente.TabIndex = 0;
            // 
            // comboBoxMaquina
            // 
            comboBoxMaquina.FormattingEnabled = true;
            comboBoxMaquina.Location = new Point(132, 69);
            comboBoxMaquina.Name = "comboBoxMaquina";
            comboBoxMaquina.Size = new Size(298, 28);
            comboBoxMaquina.TabIndex = 1;
            // 
            // dateTimePickerTurno
            // 
            dateTimePickerTurno.Location = new Point(132, 117);
            dateTimePickerTurno.Name = "dateTimePickerTurno";
            dateTimePickerTurno.Size = new Size(298, 27);
            dateTimePickerTurno.TabIndex = 2;
            // 
            // textBoxDomicilio
            // 
            textBoxDomicilio.Location = new Point(132, 169);
            textBoxDomicilio.Name = "textBoxDomicilio";
            textBoxDomicilio.Size = new Size(298, 27);
            textBoxDomicilio.TabIndex = 3;
            // 
            // comboBoxLocalidad
            // 
            comboBoxLocalidad.FormattingEnabled = true;
            comboBoxLocalidad.Location = new Point(132, 218);
            comboBoxLocalidad.Name = "comboBoxLocalidad";
            comboBoxLocalidad.Size = new Size(298, 28);
            comboBoxLocalidad.TabIndex = 4;
            // 
            // checkBoxActivo
            // 
            checkBoxActivo.AutoSize = true;
            checkBoxActivo.Location = new Point(132, 333);
            checkBoxActivo.Name = "checkBoxActivo";
            checkBoxActivo.Size = new Size(18, 17);
            checkBoxActivo.TabIndex = 5;
            checkBoxActivo.UseVisualStyleBackColor = true;
            checkBoxActivo.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 26);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 7;
            label1.Text = "Cliente";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 77);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 8;
            label2.Text = "Maquina";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 124);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 9;
            label3.Text = "Fecha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 176);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 10;
            label4.Text = "Domicilio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 226);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 11;
            label5.Text = "Ciudad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 334);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 12;
            label6.Text = "Activo";
            label6.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 283);
            label7.Name = "label7";
            label7.Size = new Size(87, 20);
            label7.TabIndex = 13;
            label7.Text = "Descripción";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(603, 62);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(603, 153);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Location = new Point(137, 280);
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(298, 27);
            textBoxDescripcion.TabIndex = 6;
            // 
            // FormNuevoTurno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxDescripcion);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBoxActivo);
            Controls.Add(comboBoxLocalidad);
            Controls.Add(textBoxDomicilio);
            Controls.Add(dateTimePickerTurno);
            Controls.Add(comboBoxMaquina);
            Controls.Add(comboBoxCliente);
            Name = "FormNuevoTurno";
            Text = "FormNuevoTurno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxCliente;
        private ComboBox comboBoxMaquina;
        private DateTimePicker dateTimePickerTurno;
        private TextBox textBoxDomicilio;
        private ComboBox comboBoxLocalidad;
        private CheckBox checkBoxActivo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnGuardar;
        private Button btnCancelar;
        private TextBox textBoxDescripcion;
    }
}