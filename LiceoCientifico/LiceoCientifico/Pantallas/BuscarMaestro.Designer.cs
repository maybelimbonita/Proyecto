namespace LiceoCientifico.Pantallas
{
    partial class BuscarMaestro
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
            this.maestroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idMaestroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelAcademicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especializacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgBusquedaMaestro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maestroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgBusquedaMaestro
            // 
            this.dgBusquedaMaestro.AllowUserToAddRows = false;
            this.dgBusquedaMaestro.AllowUserToDeleteRows = false;
            this.dgBusquedaMaestro.AutoGenerateColumns = false;
            this.dgBusquedaMaestro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBusquedaMaestro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMaestroDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.nivelAcademicoDataGridViewTextBoxColumn,
            this.especializacionDataGridViewTextBoxColumn,
            this.Editar});
            this.dgBusquedaMaestro.DataSource = this.maestroBindingSource;
            this.dgBusquedaMaestro.Location = new System.Drawing.Point(31, 121);
            this.dgBusquedaMaestro.Name = "dgBusquedaMaestro";
            this.dgBusquedaMaestro.ReadOnly = true;
            this.dgBusquedaMaestro.Size = new System.Drawing.Size(648, 190);
            this.dgBusquedaMaestro.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(230, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(303, 26);
            this.label7.TabIndex = 19;
            this.label7.Text = "BUSQUEDA DE MAESTROS";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(490, 69);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(236, 71);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(248, 20);
            this.txtNombre.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre: ";
            // 
            // maestroBindingSource
            // 
            this.maestroBindingSource.DataSource = typeof(LiceoCientifico.Data.Maestro);
            // 
            // idMaestroDataGridViewTextBoxColumn
            // 
            this.idMaestroDataGridViewTextBoxColumn.DataPropertyName = "IdMaestro";
            this.idMaestroDataGridViewTextBoxColumn.HeaderText = "IdMaestro";
            this.idMaestroDataGridViewTextBoxColumn.Name = "idMaestroDataGridViewTextBoxColumn";
            this.idMaestroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            this.nombresDataGridViewTextBoxColumn.DataPropertyName = "Nombres";
            this.nombresDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            this.nombresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nivelAcademicoDataGridViewTextBoxColumn
            // 
            this.nivelAcademicoDataGridViewTextBoxColumn.DataPropertyName = "NivelAcademico";
            this.nivelAcademicoDataGridViewTextBoxColumn.HeaderText = "NivelAcademico";
            this.nivelAcademicoDataGridViewTextBoxColumn.Name = "nivelAcademicoDataGridViewTextBoxColumn";
            this.nivelAcademicoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // especializacionDataGridViewTextBoxColumn
            // 
            this.especializacionDataGridViewTextBoxColumn.DataPropertyName = "Especializacion";
            this.especializacionDataGridViewTextBoxColumn.HeaderText = "Especializacion";
            this.especializacionDataGridViewTextBoxColumn.Name = "especializacionDataGridViewTextBoxColumn";
            this.especializacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // BuscarMaestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgBusquedaMaestro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "BuscarMaestro";
            this.Size = new System.Drawing.Size(721, 337);
            ((System.ComponentModel.ISupportInitialize)(this.dgBusquedaMaestro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maestroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgBusquedaMaestro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource maestroBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMaestroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelAcademicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn especializacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editar;
    }
}
