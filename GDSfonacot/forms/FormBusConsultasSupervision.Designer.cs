namespace GDSfonacot.forms
{
    partial class FormBusConsultasSupervision
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGlistaSup)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGlistaSup
            // 
            this.dataGlistaSup.AllowUserToAddRows = false;
            this.dataGlistaSup.AllowUserToDeleteRows = false;
            this.dataGlistaSup.AllowUserToOrderColumns = true;
            this.dataGlistaSup.BackgroundColor = System.Drawing.SystemColors.WindowText;
            this.dataGlistaSup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGlistaSup.Location = new System.Drawing.Point(461, 80);
            this.dataGlistaSup.Name = "dataGlistaSup";
            this.dataGlistaSup.ReadOnly = true;
            this.dataGlistaSup.Size = new System.Drawing.Size(830, 507);
            this.dataGlistaSup.TabIndex = 278;
            this.dataGlistaSup.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGlistaSup_CellContentDoubleClick);
            this.dataGlistaSup.SelectionChanged += new System.EventHandler(this.dataGlistaSup_SelectionChanged);
            // 
            // lblTotRegistros
            // 
            this.lblTotRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotRegistros.Location = new System.Drawing.Point(461, 363);
            this.lblTotRegistros.Name = "lblTotRegistros";
            this.lblTotRegistros.Size = new System.Drawing.Size(751, 23);
            this.lblTotRegistros.TabIndex = 277;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(4, 104);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(442, 33);
            this.label10.TabIndex = 276;
            this.label10.Text = "Por favor ingresa el nombre de Sucursal /Representacion a filtrar";
            // 
            // textSucursal
            // 
            this.textSucursal.BackColor = System.Drawing.SystemColors.MenuText;
            this.textSucursal.ForeColor = System.Drawing.SystemColors.Info;
            this.textSucursal.Location = new System.Drawing.Point(4, 80);
            this.textSucursal.Margin = new System.Windows.Forms.Padding(4);
            this.textSucursal.Name = "textSucursal";
            this.textSucursal.Size = new System.Drawing.Size(442, 20);
            this.textSucursal.TabIndex = 275;
            this.textSucursal.TextChanged += new System.EventHandler(this.textSucursal_TextChanged);
            this.textSucursal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSucursal_KeyPress);
            // 
            // FormBusConsultasSupervision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1354, 665);
            this.Controls.Add(this.dataGlistaSup);
            this.Controls.Add(this.lblTotRegistros);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textSucursal);
            this.Name = "FormBusConsultasSupervision";
            this.Text = "Buscar supervisiones para consulta de un supervisor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGlistaSup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGlistaSup;
        private System.Windows.Forms.Label lblTotRegistros;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textSucursal;
    }
}