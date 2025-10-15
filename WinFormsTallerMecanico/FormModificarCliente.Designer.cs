namespace WinFormsTallerMecanico
{
    partial class FormModificarCliente
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
            label8 = new Label();
            checkBoxActivo = new CheckBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxCorreo = new TextBox();
            textBoxTelefono = new TextBox();
            comboBoxLocalidad = new ComboBox();
            textBoxCondFiscal = new TextBox();
            textBoxCuilCuit = new TextBox();
            textBoxDomicilio = new TextBox();
            textBoxNombre = new TextBox();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(58, 324);
            label8.Name = "label8";
            label8.Size = new Size(51, 20);
            label8.TabIndex = 34;
            label8.Text = "Activo";
            // 
            // checkBoxActivo
            // 
            checkBoxActivo.AutoSize = true;
            checkBoxActivo.Location = new Point(205, 324);
            checkBoxActivo.Name = "checkBoxActivo";
            checkBoxActivo.Size = new Size(18, 17);
            checkBoxActivo.TabIndex = 33;
            checkBoxActivo.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(59, 284);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 32;
            label7.Text = "Correo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 243);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 31;
            label6.Text = "Teléfono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 202);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 30;
            label5.Text = "Localidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 157);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 29;
            label4.Text = "Condición fiscal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 113);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 28;
            label3.Text = "Cuil/Cuit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 75);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 27;
            label2.Text = "Domicilio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 38);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 26;
            label1.Text = "Nombre";
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.Location = new Point(205, 277);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(195, 27);
            textBoxCorreo.TabIndex = 25;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(205, 236);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(195, 27);
            textBoxTelefono.TabIndex = 24;
            // 
            // comboBoxLocalidad
            // 
            comboBoxLocalidad.FormattingEnabled = true;
            comboBoxLocalidad.Location = new Point(205, 194);
            comboBoxLocalidad.Name = "comboBoxLocalidad";
            comboBoxLocalidad.Size = new Size(195, 28);
            comboBoxLocalidad.TabIndex = 23;
            // 
            // textBoxCondFiscal
            // 
            textBoxCondFiscal.Location = new Point(205, 150);
            textBoxCondFiscal.Name = "textBoxCondFiscal";
            textBoxCondFiscal.Size = new Size(195, 27);
            textBoxCondFiscal.TabIndex = 22;
            // 
            // textBoxCuilCuit
            // 
            textBoxCuilCuit.Location = new Point(205, 106);
            textBoxCuilCuit.Name = "textBoxCuilCuit";
            textBoxCuilCuit.Size = new Size(195, 27);
            textBoxCuilCuit.TabIndex = 21;
            // 
            // textBoxDomicilio
            // 
            textBoxDomicilio.Location = new Point(205, 68);
            textBoxDomicilio.Name = "textBoxDomicilio";
            textBoxDomicilio.Size = new Size(195, 27);
            textBoxDomicilio.TabIndex = 20;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(205, 31);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(195, 27);
            textBoxNombre.TabIndex = 19;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(614, 34);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 35;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FormModificarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardar);
            Controls.Add(label8);
            Controls.Add(checkBoxActivo);
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
            Name = "FormModificarCliente";
            Text = "FormModificarCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private CheckBox checkBoxActivo;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxCorreo;
        private TextBox textBoxTelefono;
        private ComboBox comboBoxLocalidad;
        private TextBox textBoxCondFiscal;
        private TextBox textBoxCuilCuit;
        private TextBox textBoxDomicilio;
        private TextBox textBoxNombre;
        private Button btnGuardar;
    }
}