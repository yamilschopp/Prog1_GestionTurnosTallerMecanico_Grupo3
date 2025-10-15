namespace WinFormsTallerMecanico
{
    partial class FormListaTurnos
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
            dataGridView1 = new DataGridView();
            Cliente = new DataGridViewTextBoxColumn();
            Maquina = new DataGridViewTextBoxColumn();
            fechaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            domicilioTrabajoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Localidad = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            turnoBindingSource = new BindingSource(components);
            BtnModificarTurno = new Button();
            btnEliminarTurno = new Button();
            btnNuevoTurno = new Button();
            btnActualizar = new Button();
            Activo = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)turnoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Cliente, Maquina, fechaDataGridViewTextBoxColumn, domicilioTrabajoDataGridViewTextBoxColumn, Localidad, descripcionDataGridViewTextBoxColumn, Activo });
            dataGridView1.DataSource = turnoBindingSource;
            dataGridView1.Location = new Point(5, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(987, 393);
            dataGridView1.TabIndex = 0;
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
            // BtnModificarTurno
            // 
            BtnModificarTurno.Location = new Point(1000, 222);
            BtnModificarTurno.Name = "BtnModificarTurno";
            BtnModificarTurno.Size = new Size(94, 61);
            BtnModificarTurno.TabIndex = 8;
            BtnModificarTurno.Text = "Modificar turno";
            BtnModificarTurno.UseVisualStyleBackColor = true;
            BtnModificarTurno.Click += BtnModificarTurno_Click;
            // 
            // btnEliminarTurno
            // 
            btnEliminarTurno.Location = new Point(999, 164);
            btnEliminarTurno.Name = "btnEliminarTurno";
            btnEliminarTurno.Size = new Size(94, 49);
            btnEliminarTurno.TabIndex = 7;
            btnEliminarTurno.Text = "Eliminar turno";
            btnEliminarTurno.UseVisualStyleBackColor = true;
            btnEliminarTurno.Click += btnEliminarTurno_Click;
            // 
            // btnNuevoTurno
            // 
            btnNuevoTurno.Location = new Point(998, 94);
            btnNuevoTurno.Name = "btnNuevoTurno";
            btnNuevoTurno.Size = new Size(94, 54);
            btnNuevoTurno.TabIndex = 6;
            btnNuevoTurno.Text = "Nuevo Turno";
            btnNuevoTurno.UseVisualStyleBackColor = true;
            btnNuevoTurno.Click += btnNuevoTurno_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(1000, 12);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(93, 61);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar lista";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // Activo
            // 
            Activo.DataPropertyName = "Activo";
            Activo.HeaderText = "Activo";
            Activo.MinimumWidth = 6;
            Activo.Name = "Activo";
            Activo.Width = 125;
            // 
            // FormListaTurnos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 450);
            Controls.Add(BtnModificarTurno);
            Controls.Add(btnEliminarTurno);
            Controls.Add(btnNuevoTurno);
            Controls.Add(btnActualizar);
            Controls.Add(dataGridView1);
            Name = "FormListaTurnos";
            Text = "FormListaTurnos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)turnoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource turnoBindingSource;
        private Button BtnModificarTurno;
        private Button btnEliminarTurno;
        private Button btnNuevoTurno;
        private Button btnActualizar;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Maquina;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn domicilioTrabajoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Localidad;
        private DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn Activo;
    }
}