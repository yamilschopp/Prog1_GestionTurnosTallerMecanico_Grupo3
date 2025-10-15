namespace WinFormsTallerMecanico
{
    partial class FormNuevoCliente
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
            textBoxDomicilio = new TextBox();
            textBoxCuilCuit = new TextBox();
            textBoxCondFiscal = new TextBox();
            comboBoxLocalidad = new ComboBox();
            textBoxTelefono = new TextBox();
            textBoxCorreo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnGuardar = new Button();
            BtnCancelar = new Button();
            checkBoxActivo = new CheckBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(208, 16);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(195, 27);
            textBoxNombre.TabIndex = 0;
            // 
            // textBoxDomicilio
            // 
            textBoxDomicilio.Location = new Point(208, 53);
            textBoxDomicilio.Name = "textBoxDomicilio";
            textBoxDomicilio.Size = new Size(195, 27);
            textBoxDomicilio.TabIndex = 1;
            // 
            // textBoxCuilCuit
            // 
            textBoxCuilCuit.Location = new Point(208, 91);
            textBoxCuilCuit.Name = "textBoxCuilCuit";
            textBoxCuilCuit.Size = new Size(195, 27);
            textBoxCuilCuit.TabIndex = 2;
            // 
            // textBoxCondFiscal
            // 
            textBoxCondFiscal.Location = new Point(208, 135);
            textBoxCondFiscal.Name = "textBoxCondFiscal";
            textBoxCondFiscal.Size = new Size(195, 27);
            textBoxCondFiscal.TabIndex = 3;
            // 
            // comboBoxLocalidad
            // 
            comboBoxLocalidad.FormattingEnabled = true;
            comboBoxLocalidad.Location = new Point(208, 179);
            comboBoxLocalidad.Name = "comboBoxLocalidad";
            comboBoxLocalidad.Size = new Size(195, 28);
            comboBoxLocalidad.TabIndex = 4;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(208, 221);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(195, 27);
            textBoxTelefono.TabIndex = 5;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.Location = new Point(208, 262);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(195, 27);
            textBoxCorreo.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 23);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 7;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 60);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 8;
            label2.Text = "Domicilio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 98);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 9;
            label3.Text = "Cuil/Cuit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 142);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 10;
            label4.Text = "Condición fiscal";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 187);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 11;
            label5.Text = "Localidad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 228);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 12;
            label6.Text = "Teléfono";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(62, 269);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 13;
            label7.Text = "Correo";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(553, 55);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(553, 134);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(94, 29);
            BtnCancelar.TabIndex = 15;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // checkBoxActivo
            // 
            checkBoxActivo.AutoSize = true;
            checkBoxActivo.Location = new Point(208, 309);
            checkBoxActivo.Name = "checkBoxActivo";
            checkBoxActivo.Size = new Size(18, 17);
            checkBoxActivo.TabIndex = 17;
            checkBoxActivo.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(61, 309);
            label8.Name = "label8";
            label8.Size = new Size(51, 20);
            label8.TabIndex = 18;
            label8.Text = "Activo";
            // 
            // FormNuevoCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(checkBoxActivo);
            Controls.Add(BtnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxCorreo);
            Controls.Add(textBoxTelefono);
            Controls.Add(comboBoxLocalidad);
            Controls.Add(textBoxCondFiscal);
            Controls.Add(textBoxCuilCuit);
            Controls.Add(textBoxDomicilio);
            Controls.Add(textBoxNombre);
            Name = "FormNuevoCliente";
            Text = "FormNuevoCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNombre;
        private TextBox textBoxDomicilio;
        private TextBox textBoxCuilCuit;
        private TextBox textBoxCondFiscal;
        private ComboBox comboBoxLocalidad;
        private TextBox textBoxTelefono;
        private TextBox textBoxCorreo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnGuardar;
        private Button BtnCancelar;
        private CheckBox checkBoxActivo;
        private Label label8;
    }
}