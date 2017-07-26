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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIPrincip));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuModulos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInicioSup = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConstSupSuc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSegSup = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCerrarSup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menubuscSup = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBuscarConst = new System.Windows.Forms.ToolStripMenuItem();
            this.menubuscSeguim = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHistsupOp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuConsulUsu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsulSucur = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsulEmp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCatalogos = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuSuc = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.menucatEmp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.menuayuda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.timesup = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.timerreasig = new System.Windows.Forms.Timer(this.components);
            this.notifySupCreadas = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifySupReasignadas = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuPrincipal.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuModulos,
            this.toolStripMenuItem4,
            this.menuCatalogos,
            this.menuayuda});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(878, 24);
            this.menuPrincipal.TabIndex = 256;
            this.menuPrincipal.Text = "Menu";
            // 
            // menuModulos
            // 
            this.menuModulos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuInicioSup,
            this.menuConstSupSuc,
            this.menuSegSup,
            this.menuCerrarSup,
            this.toolStripSeparator3,
            this.menuSalir});
            this.menuModulos.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuModulos.Name = "menuModulos";
            this.menuModulos.Size = new System.Drawing.Size(66, 20);
            this.menuModulos.Text = "&Modulos";
            // 
            // menuInicioSup
            // 
            this.menuInicioSup.Name = "menuInicioSup";
            this.menuInicioSup.Size = new System.Drawing.Size(314, 22);
            this.menuInicioSup.Text = "Crear una Supervisión";
            this.menuInicioSup.Click += new System.EventHandler(this.menuInicioSup_Click);
            // 
            // menuConstSupSuc
            // 
            this.menuConstSupSuc.Name = "menuConstSupSuc";
            this.menuConstSupSuc.Size = new System.Drawing.Size(314, 22);
            this.menuConstSupSuc.Text = "Crear Contestación para Supervisión";
            this.menuConstSupSuc.Click += new System.EventHandler(this.menuConstSupSuc_Click);
            // 
            // menuSegSup
            // 
            this.menuSegSup.Name = "menuSegSup";
            this.menuSegSup.Size = new System.Drawing.Size(314, 22);
            this.menuSegSup.Text = "Crear Seguimiento a Supervisión";
            this.menuSegSup.Click += new System.EventHandler(this.menuSegSup_Click);
            // 
            // menuCerrarSup
            // 
            this.menuCerrarSup.Name = "menuCerrarSup";
            this.menuCerrarSup.Size = new System.Drawing.Size(314, 22);
            this.menuCerrarSup.Text = "Crear Cierre/Reasignacion de una Supervisión";
            this.menuCerrarSup.Click += new System.EventHandler(this.menuCerrarSup_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(311, 6);
            // 
            // menuSalir
            // 
            this.menuSalir.Name = "menuSalir";
            this.menuSalir.Size = new System.Drawing.Size(314, 22);
            this.menuSalir.Text = "Cerrar Aplicativo";
            this.menuSalir.Click += new System.EventHandler(this.menuSalir_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menubuscSup,
            this.menuBuscarConst,
            this.menubuscSeguim,
            this.menuHistsupOp,
            this.toolStripSeparator1,
            this.menuConsulUsu,
            this.menuConsulSucur,
            this.menuConsulEmp});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.ShowShortcutKeys = false;
            this.toolStripMenuItem4.Size = new System.Drawing.Size(70, 20);
            this.toolStripMenuItem4.Text = "Consultar";
            // 
            // menubuscSup
            // 
            this.menubuscSup.Name = "menubuscSup";
            this.menubuscSup.Size = new System.Drawing.Size(235, 22);
            this.menubuscSup.Text = "Supervisiones";
            this.menubuscSup.Click += new System.EventHandler(this.menubuscSup_Click);
            // 
            // menuBuscarConst
            // 
            this.menuBuscarConst.Name = "menuBuscarConst";
            this.menuBuscarConst.Size = new System.Drawing.Size(235, 22);
            this.menuBuscarConst.Text = "Contestaciones de Supervision";
            this.menuBuscarConst.Click += new System.EventHandler(this.menuBuscarConst_Click);
            // 
            // menubuscSeguim
            // 
            this.menubuscSeguim.Name = "menubuscSeguim";
            this.menubuscSeguim.Size = new System.Drawing.Size(235, 22);
            this.menubuscSeguim.Text = "Seguimientos de Supervision";
            this.menubuscSeguim.Click += new System.EventHandler(this.menubuscSeguim_Click);
            // 
            // menuHistsupOp
            // 
            this.menuHistsupOp.Name = "menuHistsupOp";
            this.menuHistsupOp.Size = new System.Drawing.Size(235, 22);
            this.menuHistsupOp.Text = "Histórico de una Supervisión";
            this.menuHistsupOp.Click += new System.EventHandler(this.menuHistsupOp_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(232, 6);
            // 
            // menuConsulUsu
            // 
            this.menuConsulUsu.Name = "menuConsulUsu";
            this.menuConsulUsu.Size = new System.Drawing.Size(235, 22);
            this.menuConsulUsu.Text = "Usuarios";
            this.menuConsulUsu.Click += new System.EventHandler(this.menuConsulUsu_Click);
            // 
            // menuConsulSucur
            // 
            this.menuConsulSucur.Name = "menuConsulSucur";
            this.menuConsulSucur.Size = new System.Drawing.Size(235, 22);
            this.menuConsulSucur.Text = "Sucursales";
            this.menuConsulSucur.Click += new System.EventHandler(this.menuConsulSucur_Click);
            // 
            // menuConsulEmp
            // 
            this.menuConsulEmp.Name = "menuConsulEmp";
            this.menuConsulEmp.Size = new System.Drawing.Size(235, 22);
            this.menuConsulEmp.Text = "Fichas Personal";
            this.menuConsulEmp.Click += new System.EventHandler(this.menuConsulEmp_Click);
            // 
            // menuCatalogos
            // 
            this.menuCatalogos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuSuc,
            this.submenuUsers,
            this.menucatEmp,
            this.toolStripSeparator6});
            this.menuCatalogos.Name = "menuCatalogos";
            this.menuCatalogos.Size = new System.Drawing.Size(72, 20);
            this.menuCatalogos.Text = "&Catalogos";
            // 
            // submenuSuc
            // 
            this.submenuSuc.ImageTransparentColor = System.Drawing.Color.Black;
            this.submenuSuc.Name = "submenuSuc";
            this.submenuSuc.Size = new System.Drawing.Size(132, 22);
            this.submenuSuc.Text = "Sucursales";
            this.submenuSuc.Click += new System.EventHandler(this.submenuSuc_Click);
            // 
            // submenuUsers
            // 
            this.submenuUsers.ImageTransparentColor = System.Drawing.Color.Black;
            this.submenuUsers.Name = "submenuUsers";
            this.submenuUsers.Size = new System.Drawing.Size(132, 22);
            this.submenuUsers.Text = "Usuarios";
            this.submenuUsers.Click += new System.EventHandler(this.submenuUsers_Click);
            // 
            // menucatEmp
            // 
            this.menucatEmp.Name = "menucatEmp";
            this.menucatEmp.Size = new System.Drawing.Size(132, 22);
            this.menucatEmp.Text = "Empleados";
            this.menucatEmp.Click += new System.EventHandler(this.menucatEmp_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(129, 6);
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
            this.menuAbout.Size = new System.Drawing.Size(147, 22);
            this.menuAbout.Text = "&Acerca de... ...";
            // 
            // timesup
            // 
            this.timesup.Enabled = true;
            this.timesup.Interval = 10000;
            this.timesup.Tick += new System.EventHandler(this.timesup_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Red;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.05027F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.94973F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(878, 100);
            this.tableLayoutPanel1.TabIndex = 282;
            // 
            // pictureBox3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox3, 4);
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Image = global::GDSfonacot.Properties.Resources.ggg;
            this.pictureBox3.Location = new System.Drawing.Point(642, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox3, 3);
            this.pictureBox3.Size = new System.Drawing.Size(233, 84);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 283;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 15);
            this.panel1.Location = new System.Drawing.Point(4, 94);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 282;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::GDSfonacot.Properties.Resources.ffff;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox2, 3);
            this.pictureBox2.Size = new System.Drawing.Size(197, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 285;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(207, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.tableLayoutPanel1.SetRowSpan(this.label2, 3);
            this.label2.Size = new System.Drawing.Size(424, 90);
            this.label2.TabIndex = 284;
            this.label2.Text = "Dirección General Adjunta Comercial\r\nSubdirección General Comercial\r\nDirección de" +
    " Supervisión de Operaciones \r\n\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNombreUsuario.Location = new System.Drawing.Point(0, 124);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(878, 24);
            this.lblNombreUsuario.TabIndex = 284;
            this.lblNombreUsuario.Text = "Usuario";
            this.lblNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerreasig
            // 
            this.timerreasig.Enabled = true;
            this.timerreasig.Interval = 10000;
            this.timerreasig.Tick += new System.EventHandler(this.timerreasig_Tick);
            // 
            // notifySupCreadas
            // 
            this.notifySupCreadas.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifySupCreadas.BalloonTipTitle = "Aviso de Supervisiones por Contestar";
            this.notifySupCreadas.Icon = ((System.Drawing.Icon)(resources.GetObject("notifySupCreadas.Icon")));
            this.notifySupCreadas.Visible = true;
            // 
            // notifySupReasignadas
            // 
            this.notifySupReasignadas.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifySupReasignadas.BalloonTipTitle = "Aviso de Supervisiones Reasignadas por Supervisor";
            this.notifySupReasignadas.Icon = ((System.Drawing.Icon)(resources.GetObject("notifySupReasignadas.Icon")));
            this.notifySupReasignadas.Visible = true;
            // 
            // MDIPrincip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 550);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuPrincipal);
            this.IsMdiContainer = true;
            this.Name = "MDIPrincip";
            this.Text = "GDS INFONACOT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIPrincip_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuModulos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuInicioSup;
        private System.Windows.Forms.ToolStripMenuItem menuSalir;
        private System.Windows.Forms.ToolStripMenuItem menuCatalogos;
        private System.Windows.Forms.ToolStripMenuItem submenuSuc;
        private System.Windows.Forms.ToolStripMenuItem submenuUsers;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem menuayuda;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStripMenuItem menuConstSupSuc;
        private System.Windows.Forms.ToolStripMenuItem menuSegSup;
        private System.Windows.Forms.ToolStripMenuItem menuCerrarSup;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem menubuscSup;
        private System.Windows.Forms.ToolStripMenuItem menuBuscarConst;
        private System.Windows.Forms.ToolStripMenuItem menubuscSeguim;
        private System.Windows.Forms.ToolStripMenuItem menuHistsupOp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuConsulUsu;
        private System.Windows.Forms.ToolStripMenuItem menuConsulSucur;
        private System.Windows.Forms.ToolStripMenuItem menuConsulEmp;
        private System.Windows.Forms.ToolStripMenuItem menucatEmp;
        private System.Windows.Forms.Timer timesup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Timer timerreasig;
        private System.Windows.Forms.NotifyIcon notifySupCreadas;
        private System.Windows.Forms.NotifyIcon notifySupReasignadas;
    }
}
