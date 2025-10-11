namespace WinFormsTallerMecanico
{
    partial class FormLocalidad
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
            textBoxCP = new TextBox();
            textBoxProvincia = new TextBox();
            labelNombre = new Label();
            labelCP = new Label();
            labelProvincia = new Label();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(318, 55);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(125, 27);
            textBoxNombre.TabIndex = 0;
            // 
            // textBoxCP
            // 
            textBoxCP.Location = new Point(318, 110);
            textBoxCP.Name = "textBoxCP";
            textBoxCP.Size = new Size(125, 27);
            textBoxCP.TabIndex = 1;
            // 
            // textBoxProvincia
            // 
            textBoxProvincia.Location = new Point(318, 167);
            textBoxProvincia.Name = "textBoxProvincia";
            textBoxProvincia.Size = new Size(125, 27);
            textBoxProvincia.TabIndex = 2;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(194, 62);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(64, 20);
            labelNombre.TabIndex = 3;
            labelNombre.Text = "Nombre";
            // 
            // labelCP
            // 
            labelCP.AutoSize = true;
            labelCP.Location = new Point(194, 117);
            labelCP.Name = "labelCP";
            labelCP.Size = new Size(103, 20);
            labelCP.TabIndex = 4;
            labelCP.Text = "Codigo postal";
            // 
            // labelProvincia
            // 
            labelProvincia.AutoSize = true;
            labelProvincia.Location = new Point(194, 170);
            labelProvincia.Name = "labelProvincia";
            labelProvincia.Size = new Size(69, 20);
            labelProvincia.TabIndex = 5;
            labelProvincia.Text = "Provincia";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(225, 252);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FormLocalidad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardar);
            Controls.Add(labelProvincia);
            Controls.Add(labelCP);
            Controls.Add(labelNombre);
            Controls.Add(textBoxProvincia);
            Controls.Add(textBoxCP);
            Controls.Add(textBoxNombre);
            Name = "FormLocalidad";
            Text = "FormLocalidad";
            Load += FormLocalidad_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNombre;
        private TextBox textBoxCP;
        private TextBox textBoxProvincia;
        private Label labelNombre;
        private Label labelCP;
        private Label labelProvincia;
        private Button btnGuardar;
    }
}