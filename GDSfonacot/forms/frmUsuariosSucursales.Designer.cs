﻿namespace GDSfonacot.forms
{
    partial class frmUsuariosSucursales
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
            this.label1 = new System.Windows.Forms.Label();
            this.TabsEmpleados = new System.Windows.Forms.TabControl();
            this.tabadmin = new System.Windows.Forms.TabPage();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.cmbNivelusuario = new System.Windows.Forms.ComboBox();
            this.label47 = new System.Windows.Forms.Label();
            this.txtNoSucursal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtVentanillas = new System.Windows.Forms.TextBox();
            this.txtAnalistas = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCoordinadorCobranza = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCoordinadorCredito = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCoordinadorAdministrativo = new System.Windows.Forms.TextBox();
            this.txtDireccionRegional = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSucursal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDirectorEstatal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRepresentaciones = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDirectorRegional = new System.Windows.Forms.TextBox();
            this.pbxSucursal = new System.Windows.Forms.PictureBox();
            this.TabsEmpleados.SuspendLayout();
            this.tabadmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSucursal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(6, 238);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 282;
            this.label1.Text = "Tipo nivel de usuario";
            // 
            // TabsEmpleados
            // 
            this.TabsEmpleados.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.TabsEmpleados.Controls.Add(this.tabadmin);
            this.TabsEmpleados.Location = new System.Drawing.Point(9, 284);
            this.TabsEmpleados.Name = "TabsEmpleados";
            this.TabsEmpleados.SelectedIndex = 0;
            this.TabsEmpleados.Size = new System.Drawing.Size(1548, 255);
            this.TabsEmpleados.TabIndex = 280;
            // 
            // tabadmin
            // 
            this.tabadmin.BackColor = System.Drawing.Color.DarkGray;
            this.tabadmin.Controls.Add(this.dgvUsuarios);
            this.tabadmin.Location = new System.Drawing.Point(4, 25);
            this.tabadmin.Name = "tabadmin";
            this.tabadmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabadmin.Size = new System.Drawing.Size(1540, 226);
            this.tabadmin.TabIndex = 0;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToOrderColumns = true;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.Location = new System.Drawing.Point(3, 3);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(1534, 220);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentDoubleClick);
            // 
            // cmbNivelusuario
            // 
            this.cmbNivelusuario.BackColor = System.Drawing.Color.Black;
            this.cmbNivelusuario.ForeColor = System.Drawing.SystemColors.Info;
            this.cmbNivelusuario.FormattingEnabled = true;
            this.cmbNivelusuario.Location = new System.Drawing.Point(7, 257);
            this.cmbNivelusuario.Name = "cmbNivelusuario";
            this.cmbNivelusuario.Size = new System.Drawing.Size(298, 21);
            this.cmbNivelusuario.TabIndex = 281;
            this.cmbNivelusuario.SelectionChangeCommitted += new System.EventHandler(this.cmbNivelusuario_SelectionChangeCommitted);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.ForeColor = System.Drawing.Color.DimGray;
            this.label47.Location = new System.Drawing.Point(528, 53);
            this.label47.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(104, 16);
            this.label47.TabIndex = 279;
            this.label47.Text = "No de Sucursal";
            // 
            // txtNoSucursal
            // 
            this.txtNoSucursal.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtNoSucursal.ForeColor = System.Drawing.Color.White;
            this.txtNoSucursal.Location = new System.Drawing.Point(527, 29);
            this.txtNoSucursal.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoSucursal.Name = "txtNoSucursal";
            this.txtNoSucursal.Size = new System.Drawing.Size(105, 20);
            this.txtNoSucursal.TabIndex = 278;
            this.txtNoSucursal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(1367, 216);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 16);
            this.label13.TabIndex = 277;
            this.label13.Text = "Ventanillas";
            // 
            // txtVentanillas
            // 
            this.txtVentanillas.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtVentanillas.ForeColor = System.Drawing.Color.White;
            this.txtVentanillas.Location = new System.Drawing.Point(1366, 192);
            this.txtVentanillas.Margin = new System.Windows.Forms.Padding(4);
            this.txtVentanillas.Name = "txtVentanillas";
            this.txtVentanillas.Size = new System.Drawing.Size(194, 20);
            this.txtVentanillas.TabIndex = 275;
            this.txtVentanillas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAnalistas
            // 
            this.txtAnalistas.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtAnalistas.ForeColor = System.Drawing.Color.White;
            this.txtAnalistas.Location = new System.Drawing.Point(1151, 192);
            this.txtAnalistas.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnalistas.Name = "txtAnalistas";
            this.txtAnalistas.Size = new System.Drawing.Size(193, 20);
            this.txtAnalistas.TabIndex = 274;
            this.txtAnalistas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(717, 218);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 16);
            this.label11.TabIndex = 273;
            this.label11.Text = "Coordinador Cobranza";
            // 
            // txtCoordinadorCobranza
            // 
            this.txtCoordinadorCobranza.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtCoordinadorCobranza.ForeColor = System.Drawing.Color.White;
            this.txtCoordinadorCobranza.Location = new System.Drawing.Point(718, 192);
            this.txtCoordinadorCobranza.Margin = new System.Windows.Forms.Padding(4);
            this.txtCoordinadorCobranza.Name = "txtCoordinadorCobranza";
            this.txtCoordinadorCobranza.Size = new System.Drawing.Size(413, 20);
            this.txtCoordinadorCobranza.TabIndex = 272;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(311, 218);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 16);
            this.label10.TabIndex = 271;
            this.label10.Text = "Coordinador Crédito";
            // 
            // txtCoordinadorCredito
            // 
            this.txtCoordinadorCredito.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtCoordinadorCredito.ForeColor = System.Drawing.Color.White;
            this.txtCoordinadorCredito.Location = new System.Drawing.Point(314, 192);
            this.txtCoordinadorCredito.Margin = new System.Windows.Forms.Padding(4);
            this.txtCoordinadorCredito.Name = "txtCoordinadorCredito";
            this.txtCoordinadorCredito.Size = new System.Drawing.Size(381, 20);
            this.txtCoordinadorCredito.TabIndex = 270;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(1150, 159);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 16);
            this.label9.TabIndex = 269;
            this.label9.Text = "Coordinador Administrativo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(1153, 218);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 16);
            this.label12.TabIndex = 276;
            this.label12.Text = "Analistas";
            // 
            // txtCoordinadorAdministrativo
            // 
            this.txtCoordinadorAdministrativo.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtCoordinadorAdministrativo.ForeColor = System.Drawing.Color.White;
            this.txtCoordinadorAdministrativo.Location = new System.Drawing.Point(1150, 134);
            this.txtCoordinadorAdministrativo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCoordinadorAdministrativo.Name = "txtCoordinadorAdministrativo";
            this.txtCoordinadorAdministrativo.Size = new System.Drawing.Size(410, 20);
            this.txtCoordinadorAdministrativo.TabIndex = 268;
            // 
            // txtDireccionRegional
            // 
            this.txtDireccionRegional.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtDireccionRegional.ForeColor = System.Drawing.Color.White;
            this.txtDireccionRegional.Location = new System.Drawing.Point(314, 29);
            this.txtDireccionRegional.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccionRegional.Name = "txtDireccionRegional";
            this.txtDireccionRegional.Size = new System.Drawing.Size(199, 20);
            this.txtDireccionRegional.TabIndex = 258;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(658, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 257;
            this.label3.Text = "Sucursal";
            // 
            // txtSucursal
            // 
            this.txtSucursal.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtSucursal.ForeColor = System.Drawing.Color.White;
            this.txtSucursal.Location = new System.Drawing.Point(653, 29);
            this.txtSucursal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSucursal.Name = "txtSucursal";
            this.txtSucursal.Size = new System.Drawing.Size(253, 20);
            this.txtSucursal.TabIndex = 256;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(719, 160);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 16);
            this.label8.TabIndex = 267;
            this.label8.Text = "Director Estatal";
            // 
            // txtDirectorEstatal
            // 
            this.txtDirectorEstatal.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtDirectorEstatal.ForeColor = System.Drawing.Color.White;
            this.txtDirectorEstatal.Location = new System.Drawing.Point(718, 134);
            this.txtDirectorEstatal.Margin = new System.Windows.Forms.Padding(4);
            this.txtDirectorEstatal.Name = "txtDirectorEstatal";
            this.txtDirectorEstatal.Size = new System.Drawing.Size(418, 20);
            this.txtDirectorEstatal.TabIndex = 266;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(316, 162);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 16);
            this.label7.TabIndex = 265;
            this.label7.Text = "Director Regional";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(311, 102);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 263;
            this.label6.Text = "Dirección";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtDireccion.ForeColor = System.Drawing.Color.White;
            this.txtDireccion.Location = new System.Drawing.Point(314, 76);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(1249, 20);
            this.txtDireccion.TabIndex = 262;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(932, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 16);
            this.label5.TabIndex = 261;
            this.label5.Text = "Representaciones";
            // 
            // txtRepresentaciones
            // 
            this.txtRepresentaciones.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtRepresentaciones.ForeColor = System.Drawing.Color.White;
            this.txtRepresentaciones.Location = new System.Drawing.Point(935, 29);
            this.txtRepresentaciones.Margin = new System.Windows.Forms.Padding(4);
            this.txtRepresentaciones.Name = "txtRepresentaciones";
            this.txtRepresentaciones.Size = new System.Drawing.Size(628, 20);
            this.txtRepresentaciones.TabIndex = 260;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(314, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 259;
            this.label4.Text = "Dirección Regional";
            // 
            // txtDirectorRegional
            // 
            this.txtDirectorRegional.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtDirectorRegional.ForeColor = System.Drawing.Color.White;
            this.txtDirectorRegional.Location = new System.Drawing.Point(314, 134);
            this.txtDirectorRegional.Margin = new System.Windows.Forms.Padding(4);
            this.txtDirectorRegional.Name = "txtDirectorRegional";
            this.txtDirectorRegional.Size = new System.Drawing.Size(381, 20);
            this.txtDirectorRegional.TabIndex = 264;
            // 
            // pbxSucursal
            // 
            this.pbxSucursal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxSucursal.Location = new System.Drawing.Point(7, 10);
            this.pbxSucursal.Name = "pbxSucursal";
            this.pbxSucursal.Size = new System.Drawing.Size(298, 221);
            this.pbxSucursal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSucursal.TabIndex = 255;
            this.pbxSucursal.TabStop = false;
            // 
            // frmUsuariosSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1362, 574);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TabsEmpleados);
            this.Controls.Add(this.cmbNivelusuario);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.txtNoSucursal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtVentanillas);
            this.Controls.Add(this.txtAnalistas);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCoordinadorCobranza);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCoordinadorCredito);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCoordinadorAdministrativo);
            this.Controls.Add(this.txtDireccionRegional);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSucursal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDirectorEstatal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRepresentaciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDirectorRegional);
            this.Controls.Add(this.pbxSucursal);
            this.Name = "frmUsuariosSucursales";
            this.Text = "frmUsuariosSucursales";
            this.Load += new System.EventHandler(this.frmUsuariosSucursales_Load);
            this.TabsEmpleados.ResumeLayout(false);
            this.tabadmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSucursal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl TabsEmpleados;
        private System.Windows.Forms.TabPage tabadmin;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.ComboBox cmbNivelusuario;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox txtNoSucursal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtVentanillas;
        private System.Windows.Forms.TextBox txtAnalistas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCoordinadorCobranza;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCoordinadorCredito;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCoordinadorAdministrativo;
        private System.Windows.Forms.TextBox txtDireccionRegional;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSucursal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDirectorEstatal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRepresentaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDirectorRegional;
        private System.Windows.Forms.PictureBox pbxSucursal;
    }
}