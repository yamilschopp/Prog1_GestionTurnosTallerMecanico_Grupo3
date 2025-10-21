namespace WinFormsTallerMecanico
{
    partial class FormListaMaquinas
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
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            marcaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            motorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            patenteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            activoDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            maquinaBindingSource = new BindingSource(components);
            BtnModificarMaquina = new Button();
            btnEliminarMaquina = new Button();
            btnNuevaMaquina = new Button();
            btnActualizar = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maquinaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nombreDataGridViewTextBoxColumn, marcaDataGridViewTextBoxColumn, motorDataGridViewTextBoxColumn, patenteDataGridViewTextBoxColumn, Cliente, activoDataGridViewCheckBoxColumn });
            dataGridView1.DataSource = maquinaBindingSource;
            dataGridView1.Location = new Point(12, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1195, 418);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            marcaDataGridViewTextBoxColumn.MinimumWidth = 6;
            marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            marcaDataGridViewTextBoxColumn.Width = 125;
            // 
            // motorDataGridViewTextBoxColumn
            // 
            motorDataGridViewTextBoxColumn.DataPropertyName = "Motor";
            motorDataGridViewTextBoxColumn.HeaderText = "Motor";
            motorDataGridViewTextBoxColumn.MinimumWidth = 6;
            motorDataGridViewTextBoxColumn.Name = "motorDataGridViewTextBoxColumn";
            motorDataGridViewTextBoxColumn.Width = 125;
            // 
            // patenteDataGridViewTextBoxColumn
            // 
            patenteDataGridViewTextBoxColumn.DataPropertyName = "Patente";
            patenteDataGridViewTextBoxColumn.HeaderText = "Patente";
            patenteDataGridViewTextBoxColumn.MinimumWidth = 6;
            patenteDataGridViewTextBoxColumn.Name = "patenteDataGridViewTextBoxColumn";
            patenteDataGridViewTextBoxColumn.Width = 125;
            // 
            // Cliente
            // 
            Cliente.DataPropertyName = "Cliente";
            Cliente.HeaderText = "Cliente";
            Cliente.MinimumWidth = 6;
            Cliente.Name = "Cliente";
            Cliente.Width = 125;
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            activoDataGridViewCheckBoxColumn.DataPropertyName = "Activo";
            activoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            activoDataGridViewCheckBoxColumn.MinimumWidth = 6;
            activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            activoDataGridViewCheckBoxColumn.Width = 125;
            // 
            // maquinaBindingSource
            // 
            maquinaBindingSource.DataSource = typeof(ClasesTallerMecanico.Models.Maquina);
            // 
            // BtnModificarMaquina
            // 
            BtnModificarMaquina.Location = new Point(1294, 211);
            BtnModificarMaquina.Name = "BtnModificarMaquina";
            BtnModificarMaquina.Size = new Size(94, 61);
            BtnModificarMaquina.TabIndex = 8;
            BtnModificarMaquina.Text = "Modificar maquina";
            BtnModificarMaquina.UseVisualStyleBackColor = true;
            BtnModificarMaquina.Click += BtnModificarMaquina_Click;
            // 
            // btnEliminarMaquina
            // 
            btnEliminarMaquina.Location = new Point(1293, 153);
            btnEliminarMaquina.Name = "btnEliminarMaquina";
            btnEliminarMaquina.Size = new Size(94, 49);
            btnEliminarMaquina.TabIndex = 7;
            btnEliminarMaquina.Text = "Eliminar Maquina";
            btnEliminarMaquina.UseVisualStyleBackColor = true;
            btnEliminarMaquina.Click += btnEliminarMaquina_Click;
            // 
            // btnNuevaMaquina
            // 
            btnNuevaMaquina.Location = new Point(1292, 83);
            btnNuevaMaquina.Name = "btnNuevaMaquina";
            btnNuevaMaquina.Size = new Size(94, 54);
            btnNuevaMaquina.TabIndex = 6;
            btnNuevaMaquina.Text = "Nueva Maquina";
            btnNuevaMaquina.UseVisualStyleBackColor = true;
            btnNuevaMaquina.Click += btnNuevaMaquina_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Enabled = false;
            btnActualizar.Location = new Point(1294, 1);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(93, 61);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar lista";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1292, 379);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 61);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormListaMaquinas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1398, 450);
            Controls.Add(btnSalir);
            Controls.Add(BtnModificarMaquina);
            Controls.Add(btnEliminarMaquina);
            Controls.Add(btnNuevaMaquina);
            Controls.Add(btnActualizar);
            Controls.Add(dataGridView1);
            Name = "FormListaMaquinas";
            Text = "FormListaMaquinas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)maquinaBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource maquinaBindingSource;
        private Button BtnModificarMaquina;
        private Button btnEliminarMaquina;
        private Button btnNuevaMaquina;
        private Button btnActualizar;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn motorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn patenteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private Button btnSalir;
    }
}