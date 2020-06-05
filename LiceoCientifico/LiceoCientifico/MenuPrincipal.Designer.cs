namespace LiceoCientifico
{
    partial class MenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.crearUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAlumnos = new System.Windows.Forms.ToolStripMenuItem();
            this.crearAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mMaestros = new System.Windows.Forms.ToolStripMenuItem();
            this.crearMaestrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarMaestrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mMaterias = new System.Windows.Forms.ToolStripMenuItem();
            this.crearMateriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarMateriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSecciones = new System.Windows.Forms.ToolStripMenuItem();
            this.crearSeccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarSeccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mGrados = new System.Windows.Forms.ToolStripMenuItem();
            this.crearGradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarGradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAsignaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.mAsignacionAlumnosS = new System.Windows.Forms.ToolStripMenuItem();
            this.mAsignacionAlumnosM = new System.Windows.Forms.ToolStripMenuItem();
            this.mPagos = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mUsuarios,
            this.mAlumnos,
            this.mMaestros,
            this.mMaterias,
            this.mSecciones,
            this.mGrados,
            this.mAsignaciones,
            this.mPagos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mUsuarios
            // 
            this.mUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearUsuarioToolStripMenuItem,
            this.buscarUsuarioToolStripMenuItem});
            this.mUsuarios.Name = "mUsuarios";
            this.mUsuarios.Size = new System.Drawing.Size(64, 20);
            this.mUsuarios.Text = "Usuarios";
            this.mUsuarios.Visible = false;
            // 
            // crearUsuarioToolStripMenuItem
            // 
            this.crearUsuarioToolStripMenuItem.Name = "crearUsuarioToolStripMenuItem";
            this.crearUsuarioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.crearUsuarioToolStripMenuItem.Text = "Crear Usuario";
            this.crearUsuarioToolStripMenuItem.Click += new System.EventHandler(this.crearUsuarioToolStripMenuItem_Click);
            // 
            // buscarUsuarioToolStripMenuItem
            // 
            this.buscarUsuarioToolStripMenuItem.Name = "buscarUsuarioToolStripMenuItem";
            this.buscarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.buscarUsuarioToolStripMenuItem.Text = "Buscar Usuario";
            this.buscarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.buscarUsuarioToolStripMenuItem_Click);
            // 
            // mAlumnos
            // 
            this.mAlumnos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearAlumnoToolStripMenuItem,
            this.buscarAlumnosToolStripMenuItem});
            this.mAlumnos.Name = "mAlumnos";
            this.mAlumnos.Size = new System.Drawing.Size(67, 20);
            this.mAlumnos.Text = "Alumnos";
            this.mAlumnos.Visible = false;
            // 
            // crearAlumnoToolStripMenuItem
            // 
            this.crearAlumnoToolStripMenuItem.Name = "crearAlumnoToolStripMenuItem";
            this.crearAlumnoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.crearAlumnoToolStripMenuItem.Text = "Crear Alumno";
            this.crearAlumnoToolStripMenuItem.Click += new System.EventHandler(this.crearAlumnoToolStripMenuItem_Click);
            // 
            // buscarAlumnosToolStripMenuItem
            // 
            this.buscarAlumnosToolStripMenuItem.Name = "buscarAlumnosToolStripMenuItem";
            this.buscarAlumnosToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.buscarAlumnosToolStripMenuItem.Text = "Buscar Alumnos";
            this.buscarAlumnosToolStripMenuItem.Click += new System.EventHandler(this.buscarAlumnosToolStripMenuItem_Click);
            // 
            // mMaestros
            // 
            this.mMaestros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearMaestrosToolStripMenuItem,
            this.buscarMaestrosToolStripMenuItem});
            this.mMaestros.Name = "mMaestros";
            this.mMaestros.Size = new System.Drawing.Size(67, 20);
            this.mMaestros.Text = "Maestros";
            this.mMaestros.Visible = false;
            // 
            // crearMaestrosToolStripMenuItem
            // 
            this.crearMaestrosToolStripMenuItem.Name = "crearMaestrosToolStripMenuItem";
            this.crearMaestrosToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.crearMaestrosToolStripMenuItem.Text = "Crear Maestros";
            this.crearMaestrosToolStripMenuItem.Click += new System.EventHandler(this.crearMaestrosToolStripMenuItem_Click);
            // 
            // buscarMaestrosToolStripMenuItem
            // 
            this.buscarMaestrosToolStripMenuItem.Name = "buscarMaestrosToolStripMenuItem";
            this.buscarMaestrosToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.buscarMaestrosToolStripMenuItem.Text = "Buscar Maestros";
            this.buscarMaestrosToolStripMenuItem.Click += new System.EventHandler(this.buscarMaestrosToolStripMenuItem_Click);
            // 
            // mMaterias
            // 
            this.mMaterias.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearMateriasToolStripMenuItem,
            this.buscarMateriasToolStripMenuItem});
            this.mMaterias.Name = "mMaterias";
            this.mMaterias.Size = new System.Drawing.Size(64, 20);
            this.mMaterias.Text = "Materias";
            this.mMaterias.Visible = false;
            // 
            // crearMateriasToolStripMenuItem
            // 
            this.crearMateriasToolStripMenuItem.Name = "crearMateriasToolStripMenuItem";
            this.crearMateriasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crearMateriasToolStripMenuItem.Text = "Crear Materias";
            this.crearMateriasToolStripMenuItem.Click += new System.EventHandler(this.crearMateriasToolStripMenuItem_Click);
            // 
            // buscarMateriasToolStripMenuItem
            // 
            this.buscarMateriasToolStripMenuItem.Name = "buscarMateriasToolStripMenuItem";
            this.buscarMateriasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.buscarMateriasToolStripMenuItem.Text = "Buscar Materias";
            this.buscarMateriasToolStripMenuItem.Click += new System.EventHandler(this.buscarMateriasToolStripMenuItem_Click);
            // 
            // mSecciones
            // 
            this.mSecciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearSeccionesToolStripMenuItem,
            this.buscarSeccionesToolStripMenuItem});
            this.mSecciones.Name = "mSecciones";
            this.mSecciones.Size = new System.Drawing.Size(71, 20);
            this.mSecciones.Text = "Secciones";
            this.mSecciones.Visible = false;
            // 
            // crearSeccionesToolStripMenuItem
            // 
            this.crearSeccionesToolStripMenuItem.Name = "crearSeccionesToolStripMenuItem";
            this.crearSeccionesToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.crearSeccionesToolStripMenuItem.Text = "Crear Secciones";
            // 
            // buscarSeccionesToolStripMenuItem
            // 
            this.buscarSeccionesToolStripMenuItem.Name = "buscarSeccionesToolStripMenuItem";
            this.buscarSeccionesToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.buscarSeccionesToolStripMenuItem.Text = "Buscar Secciones";
            // 
            // mGrados
            // 
            this.mGrados.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearGradoToolStripMenuItem,
            this.buscarGradosToolStripMenuItem});
            this.mGrados.Name = "mGrados";
            this.mGrados.Size = new System.Drawing.Size(56, 20);
            this.mGrados.Text = "Grados";
            this.mGrados.Visible = false;
            // 
            // crearGradoToolStripMenuItem
            // 
            this.crearGradoToolStripMenuItem.Name = "crearGradoToolStripMenuItem";
            this.crearGradoToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.crearGradoToolStripMenuItem.Text = "Crear Grado";
            // 
            // buscarGradosToolStripMenuItem
            // 
            this.buscarGradosToolStripMenuItem.Name = "buscarGradosToolStripMenuItem";
            this.buscarGradosToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.buscarGradosToolStripMenuItem.Text = "BuscarGrados";
            // 
            // mAsignaciones
            // 
            this.mAsignaciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAsignacionAlumnosS,
            this.mAsignacionAlumnosM});
            this.mAsignaciones.Name = "mAsignaciones";
            this.mAsignaciones.Size = new System.Drawing.Size(89, 20);
            this.mAsignaciones.Text = "Asignaciones";
            this.mAsignaciones.Visible = false;
            // 
            // mAsignacionAlumnosS
            // 
            this.mAsignacionAlumnosS.Name = "mAsignacionAlumnosS";
            this.mAsignacionAlumnosS.Size = new System.Drawing.Size(218, 22);
            this.mAsignacionAlumnosS.Text = "Asignar Alumnos a Seccion";
            // 
            // mAsignacionAlumnosM
            // 
            this.mAsignacionAlumnosM.Name = "mAsignacionAlumnosM";
            this.mAsignacionAlumnosM.Size = new System.Drawing.Size(218, 22);
            this.mAsignacionAlumnosM.Text = "Asignar Alumnos a Materia";
            // 
            // mPagos
            // 
            this.mPagos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarPagoToolStripMenuItem,
            this.consultarPagosToolStripMenuItem});
            this.mPagos.Name = "mPagos";
            this.mPagos.Size = new System.Drawing.Size(57, 20);
            this.mPagos.Text = "PAGOS";
            this.mPagos.Visible = false;
            // 
            // registrarPagoToolStripMenuItem
            // 
            this.registrarPagoToolStripMenuItem.Name = "registrarPagoToolStripMenuItem";
            this.registrarPagoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.registrarPagoToolStripMenuItem.Text = "Registrar Pago";
            // 
            // consultarPagosToolStripMenuItem
            // 
            this.consultarPagosToolStripMenuItem.Name = "consultarPagosToolStripMenuItem";
            this.consultarPagosToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.consultarPagosToolStripMenuItem.Text = "Consultar Pagos";
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPrincipal.Location = new System.Drawing.Point(42, 39);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(721, 337);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(674, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "CERRAR SESION";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU PRINCIPAL";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mUsuarios;
        private System.Windows.Forms.ToolStripMenuItem crearUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAlumnos;
        private System.Windows.Forms.ToolStripMenuItem crearAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mMaestros;
        private System.Windows.Forms.ToolStripMenuItem crearMaestrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarMaestrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mMaterias;
        private System.Windows.Forms.ToolStripMenuItem crearMateriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarMateriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mSecciones;
        private System.Windows.Forms.ToolStripMenuItem crearSeccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarSeccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mGrados;
        private System.Windows.Forms.ToolStripMenuItem crearGradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarGradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAsignaciones;
        private System.Windows.Forms.ToolStripMenuItem mAsignacionAlumnosS;
        private System.Windows.Forms.ToolStripMenuItem mAsignacionAlumnosM;
        private System.Windows.Forms.ToolStripMenuItem mPagos;
        private System.Windows.Forms.ToolStripMenuItem registrarPagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarPagosToolStripMenuItem;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Button button1;
    }
}