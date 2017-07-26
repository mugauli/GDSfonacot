namespace GDSfonacot.forms
{
    partial class frmUsuarios
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.Gafete = new System.Windows.Forms.Label();
            this.Nivelusuario = new System.Windows.Forms.Label();
            this.Sucursal = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtfechareingreso = new System.Windows.Forms.DateTimePicker();
            this.lblfechareingreso = new System.Windows.Forms.Label();
            this.txthidIdusuario = new System.Windows.Forms.TextBox();
            this.txtGafete = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.cmbNivelusuario = new System.Windows.Forms.ComboBox();
            this.cmbSucursales = new System.Windows.Forms.ComboBox();
            this.checkinactivar = new System.Windows.Forms.CheckBox();
            this.dtFechaalta = new System.Windows.Forms.DateTimePicker();
            this.fechaalta = new System.Windows.Forms.Label();
            this.dtpickerfechabaja = new System.Windows.Forms.DateTimePicker();
            this.fechabaja = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.chkverpassword = new System.Windows.Forms.CheckBox();
            this.dtreingresotemp = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.MenuText;
            this.tableLayoutPanel1.SetColumnSpan(this.txtNombre, 3);
            this.txtNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNombre.Location = new System.Drawing.Point(4, 34);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(556, 22);
            this.txtNombre.TabIndex = 20;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.Nombre, 2);
            this.Nombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Nombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Nombre.Location = new System.Drawing.Point(4, 60);
            this.Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(299, 30);
            this.Nombre.TabIndex = 21;
            this.Nombre.Text = "Nombre completo";
            // 
            // Gafete
            // 
            this.Gafete.AutoSize = true;
            this.Gafete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gafete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gafete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Gafete.Location = new System.Drawing.Point(568, 60);
            this.Gafete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Gafete.Name = "Gafete";
            this.Gafete.Size = new System.Drawing.Size(249, 30);
            this.Gafete.TabIndex = 32;
            this.Gafete.Text = "Gafete";
            // 
            // Nivelusuario
            // 
            this.Nivelusuario.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.Nivelusuario, 2);
            this.Nivelusuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Nivelusuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nivelusuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Nivelusuario.Location = new System.Drawing.Point(4, 120);
            this.Nivelusuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nivelusuario.Name = "Nivelusuario";
            this.Nivelusuario.Size = new System.Drawing.Size(299, 30);
            this.Nivelusuario.TabIndex = 44;
            this.Nivelusuario.Text = "Nivel de usuario";
            // 
            // Sucursal
            // 
            this.Sucursal.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.Sucursal, 2);
            this.Sucursal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sucursal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Sucursal.Location = new System.Drawing.Point(311, 120);
            this.Sucursal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.Size = new System.Drawing.Size(59, 16);
            this.Sucursal.TabIndex = 46;
            this.Sucursal.Text = "Sucursal";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGuardar.Location = new System.Drawing.Point(824, 213);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(115, 30);
            this.btnGuardar.TabIndex = 287;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.15504F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.71207F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.Controls.Add(this.dtreingresotemp, 8, 5);
            this.tableLayoutPanel1.Controls.Add(this.dtfechareingreso, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblfechareingreso, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.txthidIdusuario, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Nombre, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtNombre, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtGafete, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Gafete, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtpassword, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbNivelusuario, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Nivelusuario, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbSucursales, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.Sucursal, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.checkinactivar, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.dtFechaalta, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.fechaalta, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.dtpickerfechabaja, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.fechabaja, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnGuardar, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnNuevo, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.chkverpassword, 4, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1084, 266);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dtfechareingreso
            // 
            this.dtfechareingreso.CalendarForeColor = System.Drawing.Color.White;
            this.dtfechareingreso.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.dtfechareingreso.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtfechareingreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtfechareingreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechareingreso.Location = new System.Drawing.Point(567, 153);
            this.dtfechareingreso.Name = "dtfechareingreso";
            this.dtfechareingreso.Size = new System.Drawing.Size(251, 22);
            this.dtfechareingreso.TabIndex = 323;
            this.dtfechareingreso.Visible = false;
            // 
            // lblfechareingreso
            // 
            this.lblfechareingreso.AutoSize = true;
            this.lblfechareingreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblfechareingreso.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechareingreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblfechareingreso.Location = new System.Drawing.Point(568, 187);
            this.lblfechareingreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfechareingreso.Name = "lblfechareingreso";
            this.lblfechareingreso.Size = new System.Drawing.Size(249, 23);
            this.lblfechareingreso.TabIndex = 322;
            this.lblfechareingreso.Text = "Fecha de Reingreso";
            this.lblfechareingreso.Visible = false;
            // 
            // txthidIdusuario
            // 
            this.txthidIdusuario.BackColor = System.Drawing.SystemColors.MenuText;
            this.txthidIdusuario.ForeColor = System.Drawing.SystemColors.Info;
            this.txthidIdusuario.Location = new System.Drawing.Point(4, 4);
            this.txthidIdusuario.Margin = new System.Windows.Forms.Padding(4);
            this.txthidIdusuario.Name = "txthidIdusuario";
            this.txthidIdusuario.Size = new System.Drawing.Size(12, 22);
            this.txthidIdusuario.TabIndex = 320;
            // 
            // txtGafete
            // 
            this.txtGafete.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtGafete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGafete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGafete.ForeColor = System.Drawing.SystemColors.Window;
            this.txtGafete.Location = new System.Drawing.Point(568, 34);
            this.txtGafete.Margin = new System.Windows.Forms.Padding(4);
            this.txtGafete.Name = "txtGafete";
            this.txtGafete.Size = new System.Drawing.Size(249, 22);
            this.txtGafete.TabIndex = 31;
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtpassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtpassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.SystemColors.Window;
            this.txtpassword.Location = new System.Drawing.Point(825, 34);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(255, 22);
            this.txtpassword.TabIndex = 47;
            // 
            // cmbNivelusuario
            // 
            this.cmbNivelusuario.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.SetColumnSpan(this.cmbNivelusuario, 2);
            this.cmbNivelusuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbNivelusuario.ForeColor = System.Drawing.SystemColors.Info;
            this.cmbNivelusuario.FormattingEnabled = true;
            this.cmbNivelusuario.Location = new System.Drawing.Point(3, 93);
            this.cmbNivelusuario.Name = "cmbNivelusuario";
            this.cmbNivelusuario.Size = new System.Drawing.Size(301, 24);
            this.cmbNivelusuario.TabIndex = 288;
            // 
            // cmbSucursales
            // 
            this.cmbSucursales.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.SetColumnSpan(this.cmbSucursales, 2);
            this.cmbSucursales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSucursales.ForeColor = System.Drawing.SystemColors.Info;
            this.cmbSucursales.FormattingEnabled = true;
            this.cmbSucursales.Location = new System.Drawing.Point(310, 93);
            this.cmbSucursales.Name = "cmbSucursales";
            this.cmbSucursales.Size = new System.Drawing.Size(508, 24);
            this.cmbSucursales.TabIndex = 289;
            // 
            // checkinactivar
            // 
            this.checkinactivar.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.checkinactivar, 2);
            this.checkinactivar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkinactivar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkinactivar.Location = new System.Drawing.Point(3, 153);
            this.checkinactivar.Name = "checkinactivar";
            this.checkinactivar.Size = new System.Drawing.Size(301, 31);
            this.checkinactivar.TabIndex = 290;
            this.checkinactivar.Text = "Inactivo";
            this.checkinactivar.UseVisualStyleBackColor = true;
            // 
            // dtFechaalta
            // 
            this.dtFechaalta.CalendarForeColor = System.Drawing.Color.White;
            this.dtFechaalta.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.dtFechaalta.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtFechaalta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtFechaalta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaalta.Location = new System.Drawing.Point(824, 93);
            this.dtFechaalta.Name = "dtFechaalta";
            this.dtFechaalta.Size = new System.Drawing.Size(257, 22);
            this.dtFechaalta.TabIndex = 291;
            // 
            // fechaalta
            // 
            this.fechaalta.AutoSize = true;
            this.fechaalta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fechaalta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaalta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fechaalta.Location = new System.Drawing.Point(825, 120);
            this.fechaalta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fechaalta.Name = "fechaalta";
            this.fechaalta.Size = new System.Drawing.Size(255, 30);
            this.fechaalta.TabIndex = 292;
            this.fechaalta.Text = "Fecha de Alta";
            // 
            // dtpickerfechabaja
            // 
            this.dtpickerfechabaja.CalendarForeColor = System.Drawing.Color.White;
            this.dtpickerfechabaja.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.dtpickerfechabaja.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtpickerfechabaja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpickerfechabaja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpickerfechabaja.Location = new System.Drawing.Point(310, 153);
            this.dtpickerfechabaja.Name = "dtpickerfechabaja";
            this.dtpickerfechabaja.Size = new System.Drawing.Size(251, 22);
            this.dtpickerfechabaja.TabIndex = 293;
            this.dtpickerfechabaja.Visible = false;
            // 
            // fechabaja
            // 
            this.fechabaja.AutoSize = true;
            this.fechabaja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fechabaja.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechabaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fechabaja.Location = new System.Drawing.Point(311, 187);
            this.fechabaja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fechabaja.Name = "fechabaja";
            this.fechabaja.Size = new System.Drawing.Size(249, 23);
            this.fechabaja.TabIndex = 294;
            this.fechabaja.Text = "Fecha de Baja";
            this.fechabaja.Visible = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNuevo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNuevo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuevo.Location = new System.Drawing.Point(694, 213);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(124, 30);
            this.btnNuevo.TabIndex = 319;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // chkverpassword
            // 
            this.chkverpassword.AutoSize = true;
            this.chkverpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chkverpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkverpassword.Location = new System.Drawing.Point(824, 63);
            this.chkverpassword.Name = "chkverpassword";
            this.chkverpassword.Size = new System.Drawing.Size(139, 20);
            this.chkverpassword.TabIndex = 321;
            this.chkverpassword.Text = "Mostrar Password";
            this.chkverpassword.UseVisualStyleBackColor = false;
            this.chkverpassword.CheckedChanged += new System.EventHandler(this.chkverpassword_CheckedChanged);
            // 
            // dtreingresotemp
            // 
            this.dtreingresotemp.CalendarForeColor = System.Drawing.Color.White;
            this.dtreingresotemp.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.dtreingresotemp.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtreingresotemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtreingresotemp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtreingresotemp.Location = new System.Drawing.Point(824, 153);
            this.dtreingresotemp.Name = "dtreingresotemp";
            this.dtreingresotemp.Size = new System.Drawing.Size(257, 22);
            this.dtreingresotemp.TabIndex = 325;
            this.dtreingresotemp.Visible = false;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 266);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmUsuarios";
            this.Text = "Control de Usuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label Sucursal;
        private System.Windows.Forms.Label Nivelusuario;
        private System.Windows.Forms.Label Gafete;
        private System.Windows.Forms.TextBox txtGafete;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.ComboBox cmbNivelusuario;
        private System.Windows.Forms.ComboBox cmbSucursales;
        private System.Windows.Forms.CheckBox checkinactivar;
        private System.Windows.Forms.DateTimePicker dtFechaalta;
        private System.Windows.Forms.Label fechaalta;
        private System.Windows.Forms.DateTimePicker dtpickerfechabaja;
        private System.Windows.Forms.Label fechabaja;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txthidIdusuario;
        private System.Windows.Forms.CheckBox chkverpassword;
        private System.Windows.Forms.DateTimePicker dtfechareingreso;
        private System.Windows.Forms.Label lblfechareingreso;
        private System.Windows.Forms.DateTimePicker dtreingresotemp;
    }
}