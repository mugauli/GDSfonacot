﻿namespace GDSfonacot
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuModulos,
            this.menuCatalogos,
            this.menuayuda});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(1480, 24);
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
            this.menuModulos.Size = new System.Drawing.Size(66, 20);
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
            this.menuCatalogos.Size = new System.Drawing.Size(72, 20);
            this.menuCatalogos.Text = "&Catalogos";
            this.menuCatalogos.Click += new System.EventHandler(this.menuCatalogos_Click);
            // 
            // submenuSuc
            // 
            this.submenuSuc.ImageTransparentColor = System.Drawing.Color.Black;
            this.submenuSuc.Name = "submenuSuc";
            this.submenuSuc.Size = new System.Drawing.Size(152, 22);
            this.submenuSuc.Text = "Sucursales";
            this.submenuSuc.Click += new System.EventHandler(this.submenuSuc_Click);
            // 
            // submenuUsers
            // 
            this.submenuUsers.ImageTransparentColor = System.Drawing.Color.Black;
            this.submenuUsers.Name = "submenuUsers";
            this.submenuUsers.Size = new System.Drawing.Size(152, 22);
            this.submenuUsers.Text = "Usuarios";
            this.submenuUsers.Click += new System.EventHandler(this.submenuUsers_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(149, 6);
            // 
            // menuayuda
            // 
            this.menuayuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout});
            this.menuayuda.Name = "menuayuda";
            this.menuayuda.Size = new System.Drawing.Size(53, 20);
            this.menuayuda.Text = "Ay&uda";
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(152, 22);
            this.menuAbout.Text = "&Acerca de... ...";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1480, 108);
            this.panel1.TabIndex = 275;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GDSfonacot.Properties.Resources.ggg;
            this.pictureBox3.Location = new System.Drawing.Point(1403, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(168, 89);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GDSfonacot.Properties.Resources.ffff;
            this.pictureBox2.Location = new System.Drawing.Point(23, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(241, 89);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(677, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(407, 96);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dirección General Adjunta Comercial\r\nSubdirección General Comercial\r\nDirección de" +
    " Supervisión de Operaciones \r\n\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MDIPrincip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuPrincipal);
            this.IsMdiContainer = true;
            this.Name = "MDIPrincip";
            this.Text = "GDS INFONACOT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIPrincip_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}