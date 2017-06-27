namespace GDSfonacot.forms
{
    partial class FormVisorConsultarSupervCR
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
            this.crpvisor = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crpvisor
            // 
            this.crpvisor.ActiveViewIndex = -1;
            this.crpvisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpvisor.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpvisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crpvisor.Location = new System.Drawing.Point(0, 0);
            this.crpvisor.Name = "crpvisor";
            this.crpvisor.Size = new System.Drawing.Size(864, 419);
            this.crpvisor.TabIndex = 1;
            // 
            // FormVisorConsultarSupervCR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 419);
            this.Controls.Add(this.crpvisor);
            this.Name = "FormVisorConsultarSupervCR";
            this.Text = "Minuta de Trabajo por Supervision";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormVisorConsultarSupervC_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpvisor;
    }
}