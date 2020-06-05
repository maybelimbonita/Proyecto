namespace LiceoCientifico.Pantallas
{
    partial class BuscarAlumno
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
            this.dgBusquedaAlumno = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idAlumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEncargadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoEncargadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgBusquedaAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgBusquedaAlumno
            // 
            this.dgBusquedaAlumno.AllowUserToAddRows = false;
            this.dgBusquedaAlumno.AllowUserToDeleteRows = false;
            this.dgBusquedaAlumno.AutoGenerateColumns = false;
            this.dgBusquedaAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBusquedaAlumno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlumnoDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.cUIDataGridViewTextBoxColumn,
            this.fechaNacimientoDataGridViewTextBoxColumn,
            this.nombreEncargadoDataGridViewTextBoxColumn,
            this.telefonoEncargadoDataGridViewTextBoxColumn});
            this.dgBusquedaAlumno.DataSource = this.alumnoBindingSource;
            this.dgBusquedaAlumno.Location = new System.Drawing.Point(45, 117);
            this.dgBusquedaAlumno.Name = "dgBusquedaAlumno";
            this.dgBusquedaAlumno.ReadOnly = true;
            this.dgBusquedaAlumno.Size = new System.Drawing.Size(630, 190);
            this.dgBusquedaAlumno.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(228, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(289, 26);
            this.label7.TabIndex = 19;
            this.label7.Text = "BUSQUEDA DE ALUMNOS";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(488, 74);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(234, 76);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(248, 20);
            this.txtNombre.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre: ";
            // 
            // idAlumnoDataGridViewTextBoxColumn
            // 
            this.idAlumnoDataGridViewTextBoxColumn.DataPropertyName = "IdAlumno";
            this.idAlumnoDataGridViewTextBoxColumn.HeaderText = "IdAlumno";
            this.idAlumnoDataGridViewTextBoxColumn.Name = "idAlumnoDataGridViewTextBoxColumn";
            this.idAlumnoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // cUIDataGridViewTextBoxColumn
            // 
            this.cUIDataGridViewTextBoxColumn.DataPropertyName = "CUI";
            this.cUIDataGridViewTextBoxColumn.HeaderText = "CUI";
            this.cUIDataGridViewTextBoxColumn.Name = "cUIDataGridViewTextBoxColumn";
            this.cUIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            this.fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "FechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            this.fechaNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreEncargadoDataGridViewTextBoxColumn
            // 
            this.nombreEncargadoDataGridViewTextBoxColumn.DataPropertyName = "NombreEncargado";
            this.nombreEncargadoDataGridViewTextBoxColumn.HeaderText = "NombreEncargado";
            this.nombreEncargadoDataGridViewTextBoxColumn.Name = "nombreEncargadoDataGridViewTextBoxColumn";
            this.nombreEncargadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoEncargadoDataGridViewTextBoxColumn
            // 
            this.telefonoEncargadoDataGridViewTextBoxColumn.DataPropertyName = "TelefonoEncargado";
            this.telefonoEncargadoDataGridViewTextBoxColumn.HeaderText = "TelefonoEncargado";
            this.telefonoEncargadoDataGridViewTextBoxColumn.Name = "telefonoEncargadoDataGridViewTextBoxColumn";
            this.telefonoEncargadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alumnoBindingSource
            // 
            this.alumnoBindingSource.DataSource = typeof(LiceoCientifico.Data.Alumno);
            // 
            // BuscarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgBusquedaAlumno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "BuscarAlumno";
            this.Size = new System.Drawing.Size(721, 337);
            ((System.ComponentModel.ISupportInitialize)(this.dgBusquedaAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgBusquedaAlumno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource alumnoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEncargadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoEncargadoDataGridViewTextBoxColumn;
    }
}
