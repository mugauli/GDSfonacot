namespace GDSfonacot.forms
{
    partial class FormBusSegRespuesta
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
            this.dataGlistaSup = new System.Windows.Forms.DataGridView();
            this.lblTotRegistros = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textSucursal = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGlistaSup)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGlistaSup
            // 
            this.dataGlistaSup.AllowUserToAddRows = false;
            this.dataGlistaSup.AllowUserToDeleteRows = false;
            this.dataGlistaSup.AllowUserToOrderColumns = true;
            this.dataGlistaSup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGlistaSup.Location = new System.Drawing.Point(467, 115);
            this.dataGlistaSup.Name = "dataGlistaSup";
            this.dataGlistaSup.ReadOnly = true;
            this.dataGlistaSup.Size = new System.Drawing.Size(722, 280);
            this.dataGlistaSup.TabIndex = 288;
            this.dataGlistaSup.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGlistaSup_CellContentDoubleClick);
            // 
            // lblTotRegistros
            // 
            this.lblTotRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotRegistros.Location = new System.Drawing.Point(464, 398);
            this.lblTotRegistros.Name = "lblTotRegistros";
            this.lblTotRegistros.Size = new System.Drawing.Size(751, 23);
            this.lblTotRegistros.TabIndex = 287;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(10, 139);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(442, 33);
            this.label10.TabIndex = 286;
            this.label10.Text = "Por favor ingresa el nombre de Sucursal /Representacion a filtrar";
            // 
            // textSucursal
            // 
            this.textSucursal.BackColor = System.Drawing.SystemColors.MenuText;
            this.textSucursal.ForeColor = System.Drawing.SystemColors.Info;
            this.textSucursal.Location = new System.Drawing.Point(10, 115);
            this.textSucursal.Margin = new System.Windows.Forms.Padding(4);
            this.textSucursal.Name = "textSucursal";
            this.textSucursal.Size = new System.Drawing.Size(442, 20);
            this.textSucursal.TabIndex = 285;
            this.textSucursal.TextChanged += new System.EventHandler(this.textSucursal_TextChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1354, 108);
            this.panel1.TabIndex = 284;
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
            this.pictureBox2.Location = new System.Drawing.Point(74, 12);
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
            // FormBusSegRespuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 665);
            this.Controls.Add(this.dataGlistaSup);
            this.Controls.Add(this.lblTotRegistros);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textSucursal);
            this.Controls.Add(this.panel1);
            this.Name = "FormBusSegRespuesta";
            this.Text = "FormBusSegRespuesta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGlistaSup)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGlistaSup;
        private System.Windows.Forms.Label lblTotRegistros;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textSucursal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}