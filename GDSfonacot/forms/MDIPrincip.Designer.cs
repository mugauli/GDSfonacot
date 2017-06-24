namespace GDSfonacot
{
    partial class MDIPrincip
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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuModulos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBuscarSuperv = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSupContestSuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSupConsultaSuperv = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSupContestSeguimSuperv = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHistsupOp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFichasSuc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFichasPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuMinutas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCatalogos = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuSuc = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.menuayuda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuModulos,
            this.menuCatalogos,
            this.menuayuda});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(78, 453);
            this.menuPrincipal.TabIndex = 256;
            this.menuPrincipal.Text = "Menu";
            // 
            // menuModulos
            // 
            this.menuModulos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBuscarSuperv,
            this.menuHistsupOp,
            this.toolStripSeparator3,
            this.menuFichasSuc,
            this.menuFichasPerson,
            this.toolStripSeparator4,
            this.menuMinutas,
            this.menuReportes,
            this.toolStripSeparator5,
            this.menuSalir});
            this.menuModulos.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuModulos.Name = "menuModulos";
            this.menuModulos.Size = new System.Drawing.Size(65, 19);
            this.menuModulos.Text = "&Modulos";
            // 
            // mnuBuscarSuperv
            // 
            this.mnuBuscarSuperv.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSupContestSuc,
            this.mnuSupConsultaSuperv,
            this.mnuSupContestSeguimSuperv});
            this.mnuBuscarSuperv.Name = "mnuBuscarSuperv";
            this.mnuBuscarSuperv.Size = new System.Drawing.Size(287, 22);
            this.mnuBuscarSuperv.Text = "Buscar Supervisiones";
            // 
            // mnuSupContestSuc
            // 
            this.mnuSupContestSuc.Name = "mnuSupContestSuc";
            this.mnuSupContestSuc.Size = new System.Drawing.Size(347, 22);
            this.mnuSupContestSuc.Text = "Para Contestacion de Sucursal";
            this.mnuSupContestSuc.Click += new System.EventHandler(this.mnuSupContestSuc_Click);
            // 
            // mnuSupConsultaSuperv
            // 
            this.mnuSupConsultaSuperv.Name = "mnuSupConsultaSuperv";
            this.mnuSupConsultaSuperv.Size = new System.Drawing.Size(347, 22);
            this.mnuSupConsultaSuperv.Text = "Para Consulta de un Supervisor";
            this.mnuSupConsultaSuperv.Click += new System.EventHandler(this.mnuSupConsultaSuperv_Click);
            // 
            // mnuSupContestSeguimSuperv
            // 
            this.mnuSupContestSeguimSuperv.Name = "mnuSupContestSeguimSuperv";
            this.mnuSupContestSeguimSuperv.Size = new System.Drawing.Size(347, 22);
            this.mnuSupContestSeguimSuperv.Text = "Para Contestacion de Seguimiento de un Supervisor";
            this.mnuSupContestSeguimSuperv.Click += new System.EventHandler(this.mnuSupContestSeguimSuperv_Click);
            // 
            // menuHistsupOp
            // 
            this.menuHistsupOp.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuHistsupOp.Name = "menuHistsupOp";
            this.menuHistsupOp.Size = new System.Drawing.Size(287, 22);
            this.menuHistsupOp.Text = "Histórico de Supervisión de Operaciones";
            this.menuHistsupOp.Click += new System.EventHandler(this.menuHistsupOp_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(284, 6);
            // 
            // menuFichasSuc
            // 
            this.menuFichasSuc.Name = "menuFichasSuc";
            this.menuFichasSuc.Size = new System.Drawing.Size(287, 22);
            this.menuFichasSuc.Text = "Fichas Sucursales";
            this.menuFichasSuc.Click += new System.EventHandler(this.menuFichasSuc_Click);
            // 
            // menuFichasPerson
            // 
            this.menuFichasPerson.Name = "menuFichasPerson";
            this.menuFichasPerson.Size = new System.Drawing.Size(287, 22);
            this.menuFichasPerson.Text = "Fichas Personal";
            this.menuFichasPerson.Click += new System.EventHandler(this.menuFichasPerson_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(284, 6);
            // 
            // menuMinutas
            // 
            this.menuMinutas.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuMinutas.Name = "menuMinutas";
            this.menuMinutas.Size = new System.Drawing.Size(287, 22);
            this.menuMinutas.Text = "Minuta de Trabajo";
            this.menuMinutas.Click += new System.EventHandler(this.menuMinutas_Click);
            // 
            // menuReportes
            // 
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.Size = new System.Drawing.Size(287, 22);
            this.menuReportes.Text = "Reportes";
            this.menuReportes.Click += new System.EventHandler(this.menuReportes_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(284, 6);
            // 
            // menuSalir
            // 
            this.menuSalir.Name = "menuSalir";
            this.menuSalir.Size = new System.Drawing.Size(287, 22);
            this.menuSalir.Text = "Cerrar Aplicativo";
            this.menuSalir.Click += new System.EventHandler(this.menuSalir_Click);
            // 
            // menuCatalogos
            // 
            this.menuCatalogos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuSuc,
            this.submenuUsers,
            this.toolStripSeparator6});
            this.menuCatalogos.Name = "menuCatalogos";
            this.menuCatalogos.Size = new System.Drawing.Size(65, 19);
            this.menuCatalogos.Text = "&Catalogos";
            this.menuCatalogos.Click += new System.EventHandler(this.menuCatalogos_Click);
            // 
            // submenuSuc
            // 
            this.submenuSuc.ImageTransparentColor = System.Drawing.Color.Black;
            this.submenuSuc.Name = "submenuSuc";
            this.submenuSuc.Size = new System.Drawing.Size(129, 22);
            this.submenuSuc.Text = "Sucursales";
            this.submenuSuc.Click += new System.EventHandler(this.submenuSuc_Click);
            // 
            // submenuUsers
            // 
            this.submenuUsers.ImageTransparentColor = System.Drawing.Color.Black;
            this.submenuUsers.Name = "submenuUsers";
            this.submenuUsers.Size = new System.Drawing.Size(129, 22);
            this.submenuUsers.Text = "Usuarios";
            this.submenuUsers.Click += new System.EventHandler(this.submenuUsers_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(126, 6);
            // 
            // menuayuda
            // 
            this.menuayuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout});
            this.menuayuda.Name = "menuayuda";
            this.menuayuda.Size = new System.Drawing.Size(65, 19);
            this.menuayuda.Text = "Ay&uda";
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(147, 22);
            this.menuAbout.Text = "&Acerca de... ...";
            // 
            // MDIPrincip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 453);
            this.Controls.Add(this.menuPrincipal);
            this.IsMdiContainer = true;
            this.Name = "MDIPrincip";
            this.Text = "GDS INFONACOT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIPrincip_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuModulos;
        private System.Windows.Forms.ToolStripMenuItem menuHistsupOp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuFichasSuc;
        private System.Windows.Forms.ToolStripMenuItem menuFichasPerson;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem menuMinutas;
        private System.Windows.Forms.ToolStripMenuItem menuReportes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem menuSalir;
        private System.Windows.Forms.ToolStripMenuItem menuCatalogos;
        private System.Windows.Forms.ToolStripMenuItem submenuSuc;
        private System.Windows.Forms.ToolStripMenuItem submenuUsers;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem menuayuda;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuBuscarSuperv;
        private System.Windows.Forms.ToolStripMenuItem mnuSupContestSuc;
        private System.Windows.Forms.ToolStripMenuItem mnuSupConsultaSuperv;
        private System.Windows.Forms.ToolStripMenuItem mnuSupContestSeguimSuperv;
    }
}