namespace WinFormsTallerMecanico
{
    partial class FormListaClientes
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
            usuarioBindingSource = new BindingSource(components);
            clienteBindingSource = new BindingSource(components);
            usuarioBindingSource1 = new BindingSource(components);
            dataGridView1 = new DataGridView();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cuilCuitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            domicilioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Localidad = new DataGridViewTextBoxColumn();
            telefonoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            correoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            activoDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            btnActualizar = new Button();
            btnNuevoCliente = new Button();
            btnEliminarCliente = new Button();
            BtnModificarCliente = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // usuarioBindingSource
            // 
            usuarioBindingSource.DataSource = typeof(ClasesTallerMecanico.Models.Usuario);
            // 
            // clienteBindingSource
            // 
            clienteBindingSource.DataSource = typeof(ClasesTallerMecanico.Models.Cliente);
            // 
            // usuarioBindingSource1
            // 
            usuarioBindingSource1.DataSource = typeof(ClasesTallerMecanico.Models.Usuario);
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nombreDataGridViewTextBoxColumn, cuilCuitDataGridViewTextBoxColumn, domicilioDataGridViewTextBoxColumn, Localidad, telefonoDataGridViewTextBoxColumn, correoDataGridViewTextBoxColumn, activoDataGridViewCheckBoxColumn });
            dataGridView1.DataSource = clienteBindingSource;
            dataGridView1.Location = new Point(2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(928, 319);
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
            // cuilCuitDataGridViewTextBoxColumn
            // 
            cuilCuitDataGridViewTextBoxColumn.DataPropertyName = "CuilCuit";
            cuilCuitDataGridViewTextBoxColumn.HeaderText = "CuilCuit";
            cuilCuitDataGridViewTextBoxColumn.MinimumWidth = 6;
            cuilCuitDataGridViewTextBoxColumn.Name = "cuilCuitDataGridViewTextBoxColumn";
            cuilCuitDataGridViewTextBoxColumn.Width = 125;
            // 
            // domicilioDataGridViewTextBoxColumn
            // 
            domicilioDataGridViewTextBoxColumn.DataPropertyName = "Domicilio";
            domicilioDataGridViewTextBoxColumn.HeaderText = "Domicilio";
            domicilioDataGridViewTextBoxColumn.MinimumWidth = 6;
            domicilioDataGridViewTextBoxColumn.Name = "domicilioDataGridViewTextBoxColumn";
            domicilioDataGridViewTextBoxColumn.Width = 125;
            // 
            // Localidad
            // 
            Localidad.DataPropertyName = "Localidad";
            Localidad.HeaderText = "Localidad";
            Localidad.MinimumWidth = 6;
            Localidad.Name = "Localidad";
            Localidad.Width = 125;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            telefonoDataGridViewTextBoxColumn.MinimumWidth = 6;
            telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            telefonoDataGridViewTextBoxColumn.Width = 125;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            correoDataGridViewTextBoxColumn.MinimumWidth = 6;
            correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            correoDataGridViewTextBoxColumn.Width = 125;
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            activoDataGridViewCheckBoxColumn.DataPropertyName = "Activo";
            activoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            activoDataGridViewCheckBoxColumn.MinimumWidth = 6;
            activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            activoDataGridViewCheckBoxColumn.Width = 125;
            // 
            // btnActualizar
            // 
            btnActualizar.Enabled = false;
            btnActualizar.Location = new Point(949, 12);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(93, 61);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar lista";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.Location = new Point(947, 94);
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.Size = new Size(94, 54);
            btnNuevoCliente.TabIndex = 2;
            btnNuevoCliente.Text = "Nuevo cliente";
            btnNuevoCliente.UseVisualStyleBackColor = true;
            btnNuevoCliente.Click += btnNuevoCliente_Click;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.Location = new Point(948, 164);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(94, 49);
            btnEliminarCliente.TabIndex = 3;
            btnEliminarCliente.Text = "Eliminar cliente";
            btnEliminarCliente.UseVisualStyleBackColor = true;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // BtnModificarCliente
            // 
            BtnModificarCliente.Location = new Point(949, 222);
            BtnModificarCliente.Name = "BtnModificarCliente";
            BtnModificarCliente.Size = new Size(94, 61);
            BtnModificarCliente.TabIndex = 4;
            BtnModificarCliente.Text = "Modificar cliente";
            BtnModificarCliente.UseVisualStyleBackColor = true;
            BtnModificarCliente.Click += BtnModificarCliente_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(949, 409);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormListaClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1304, 450);
            Controls.Add(btnSalir);
            Controls.Add(BtnModificarCliente);
            Controls.Add(btnEliminarCliente);
            Controls.Add(btnNuevoCliente);
            Controls.Add(btnActualizar);
            Controls.Add(dataGridView1);
            Name = "FormListaClientes";
            Text = "FormListaClientes";
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource usuarioBindingSource1;
        private BindingSource usuarioBindingSource;
        private BindingSource clienteBindingSource;
        private DataGridView dataGridView1;
        private Button btnActualizar;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cuilCuitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn domicilioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Localidad;
        private DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private Button btnNuevoCliente;
        private Button btnEliminarCliente;
        private Button BtnModificarCliente;
        private Button btnSalir;
    }
}