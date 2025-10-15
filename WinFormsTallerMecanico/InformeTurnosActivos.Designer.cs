namespace WinFormsTallerMecanico
{
    partial class InformeTurnosActivos
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            dataGridTurnosActivos = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            Maquina = new DataGridViewTextBoxColumn();
            fechaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            domicilioTrabajoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Localidad = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            turnoBindingSource = new BindingSource(components);
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridTurnosActivos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)turnoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(319, 9);
            label1.Name = "label1";
            label1.Size = new Size(332, 38);
            label1.TabIndex = 2;
            label1.Text = "Informe de turnos activos";
            // 
            // dataGridTurnosActivos
            // 
            dataGridTurnosActivos.AutoGenerateColumns = false;
            dataGridTurnosActivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTurnosActivos.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, Cliente, Maquina, fechaDataGridViewTextBoxColumn, domicilioTrabajoDataGridViewTextBoxColumn, Localidad, descripcionDataGridViewTextBoxColumn });
            dataGridTurnosActivos.DataSource = turnoBindingSource;
            dataGridTurnosActivos.Location = new Point(2, 47);
            dataGridTurnosActivos.Name = "dataGridTurnosActivos";
            dataGridTurnosActivos.RowHeadersWidth = 51;
            dataGridTurnosActivos.Size = new Size(1003, 483);
            dataGridTurnosActivos.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // Cliente
            // 
            Cliente.DataPropertyName = "Cliente";
            Cliente.HeaderText = "Cliente";
            Cliente.MinimumWidth = 6;
            Cliente.Name = "Cliente";
            Cliente.Width = 125;
            // 
            // Maquina
            // 
            Maquina.DataPropertyName = "Maquina";
            Maquina.HeaderText = "Maquina";
            Maquina.MinimumWidth = 6;
            Maquina.Name = "Maquina";
            Maquina.Width = 125;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            fechaDataGridViewTextBoxColumn.MinimumWidth = 6;
            fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            fechaDataGridViewTextBoxColumn.Width = 125;
            // 
            // domicilioTrabajoDataGridViewTextBoxColumn
            // 
            domicilioTrabajoDataGridViewTextBoxColumn.DataPropertyName = "DomicilioTrabajo";
            domicilioTrabajoDataGridViewTextBoxColumn.HeaderText = "DomicilioTrabajo";
            domicilioTrabajoDataGridViewTextBoxColumn.MinimumWidth = 6;
            domicilioTrabajoDataGridViewTextBoxColumn.Name = "domicilioTrabajoDataGridViewTextBoxColumn";
            domicilioTrabajoDataGridViewTextBoxColumn.Width = 125;
            // 
            // Localidad
            // 
            Localidad.DataPropertyName = "Localidad";
            Localidad.HeaderText = "Localidad";
            Localidad.MinimumWidth = 6;
            Localidad.Name = "Localidad";
            Localidad.Width = 125;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            descripcionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            descripcionDataGridViewTextBoxColumn.Width = 125;
            // 
            // turnoBindingSource
            // 
            turnoBindingSource.DataSource = typeof(ClasesTallerMecanico.Models.Turno);
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1011, 56);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // InformeTurnosActivos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 532);
            Controls.Add(btnSalir);
            Controls.Add(dataGridTurnosActivos);
            Controls.Add(label1);
            Name = "InformeTurnosActivos";
            Text = "InformeTurnosActivos";
            ((System.ComponentModel.ISupportInitialize)dataGridTurnosActivos).EndInit();
            ((System.ComponentModel.ISupportInitialize)turnoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridTurnosActivos;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Maquina;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn domicilioTrabajoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Localidad;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private BindingSource turnoBindingSource;
        private Button btnSalir;
    }
}