namespace LiceoCientifico.Pantallas
{
    partial class BuscarMateria
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgBusquedaMaestro = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idMateriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMateriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maestroDeMateriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgBusquedaMaestro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgBusquedaMaestro
            // 
            this.dgBusquedaMaestro.AllowUserToAddRows = false;
            this.dgBusquedaMaestro.AllowUserToDeleteRows = false;
            this.dgBusquedaMaestro.AutoGenerateColumns = false;
            this.dgBusquedaMaestro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBusquedaMaestro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMateriaDataGridViewTextBoxColumn,
            this.nombreMateriaDataGridViewTextBoxColumn,
            this.maestroDeMateriaDataGridViewTextBoxColumn,
            this.Editar});
            this.dgBusquedaMaestro.DataSource = this.materiaBindingSource;
            this.dgBusquedaMaestro.Location = new System.Drawing.Point(36, 121);
            this.dgBusquedaMaestro.Name = "dgBusquedaMaestro";
            this.dgBusquedaMaestro.ReadOnly = true;
            this.dgBusquedaMaestro.Size = new System.Drawing.Size(648, 190);
            this.dgBusquedaMaestro.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(235, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(292, 26);
            this.label7.TabIndex = 24;
            this.label7.Text = "BUSQUEDA DE MATERIAS";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(495, 69);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 23;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(241, 71);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(248, 20);
            this.txtNombre.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre: ";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Maestro";
            this.dataGridViewTextBoxColumn1.HeaderText = "Maestro";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // materiaBindingSource
            // 
            this.materiaBindingSource.DataSource = typeof(LiceoCientifico.Data.Materia);
            // 
            // idMateriaDataGridViewTextBoxColumn
            // 
            this.idMateriaDataGridViewTextBoxColumn.DataPropertyName = "IdMateria";
            this.idMateriaDataGridViewTextBoxColumn.HeaderText = "IdMateria";
            this.idMateriaDataGridViewTextBoxColumn.Name = "idMateriaDataGridViewTextBoxColumn";
            this.idMateriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreMateriaDataGridViewTextBoxColumn
            // 
            this.nombreMateriaDataGridViewTextBoxColumn.DataPropertyName = "NombreMateria";
            this.nombreMateriaDataGridViewTextBoxColumn.HeaderText = "NombreMateria";
            this.nombreMateriaDataGridViewTextBoxColumn.Name = "nombreMateriaDataGridViewTextBoxColumn";
            this.nombreMateriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreMateriaDataGridViewTextBoxColumn.Width = 200;
            // 
            // maestroDeMateriaDataGridViewTextBoxColumn
            // 
            this.maestroDeMateriaDataGridViewTextBoxColumn.DataPropertyName = "MaestroDeMateria";
            this.maestroDeMateriaDataGridViewTextBoxColumn.HeaderText = "MaestroDeMateria";
            this.maestroDeMateriaDataGridViewTextBoxColumn.Name = "maestroDeMateriaDataGridViewTextBoxColumn";
            this.maestroDeMateriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.maestroDeMateriaDataGridViewTextBoxColumn.Width = 200;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // BuscarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgBusquedaMaestro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "BuscarMateria";
            this.Size = new System.Drawing.Size(721, 337);
            ((System.ComponentModel.ISupportInitialize)(this.dgBusquedaMaestro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgBusquedaMaestro;
        private System.Windows.Forms.BindingSource materiaBindingSource;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maestroDeMateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}
