﻿namespace GDSfonacot.forms
{
    partial class FormTemplParametroCR
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
            this.textparam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textparam
            // 
            this.textparam.Location = new System.Drawing.Point(15, 87);
            this.textparam.Name = "textparam";
            this.textparam.Size = new System.Drawing.Size(283, 20);
            this.textparam.TabIndex = 0;
            this.textparam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textparam_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresa el numero de supervision completo y presiona enter";
            // 
            // FormTemplParametroCR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 175);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textparam);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTemplParametroCR";
            this.Text = "FormTemplParametroCR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textparam;
        private System.Windows.Forms.Label label1;
    }
}