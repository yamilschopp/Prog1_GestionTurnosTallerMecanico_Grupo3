namespace WinFormsTallerMecanico
{
    partial class InformeMaquinasActivas
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
            dataGridMaquinasActivas = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            marcaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            motorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            patenteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            maquinaBindingSource = new BindingSource(components);
            label1 = new Label();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridMaquinasActivas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maquinaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridMaquinasActivas
            // 
            dataGridMaquinasActivas.AutoGenerateColumns = false;
            dataGridMaquinasActivas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMaquinasActivas.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, marcaDataGridViewTextBoxColumn, motorDataGridViewTextBoxColumn, patenteDataGridViewTextBoxColumn, Cliente });
            dataGridMaquinasActivas.DataSource = maquinaBindingSource;
            dataGridMaquinasActivas.Location = new Point(12, 46);
            dataGridMaquinasActivas.Name = "dataGridMaquinasActivas";
            dataGridMaquinasActivas.RowHeadersWidth = 51;
            dataGridMaquinasActivas.Size = new Size(1000, 477);
            dataGridMaquinasActivas.TabIndex = 0;
            dataGridMaquinasActivas.CellContentClick += dataGridMaquinasActivas_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
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
            // maquinaBindingSource
            // 
            maquinaBindingSource.DataSource = typeof(ClasesTallerMecanico.Models.Maquina);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(366, 5);
            label1.Name = "label1";
            label1.Size = new Size(370, 38);
            label1.TabIndex = 1;
            label1.Text = "Informe de maquinas activas";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1019, 46);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // InformeMaquinasActivas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 531);
            Controls.Add(btnSalir);
            Controls.Add(label1);
            Controls.Add(dataGridMaquinasActivas);
            Name = "InformeMaquinasActivas";
            Text = "InformeMaquinasActivas";
            ((System.ComponentModel.ISupportInitialize)dataGridMaquinasActivas).EndInit();
            ((System.ComponentModel.ISupportInitialize)maquinaBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridMaquinasActivas;
        private Label label1;
        private BindingSource maquinaBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn motorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn patenteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Cliente;
        private Button btnSalir;
    }
}