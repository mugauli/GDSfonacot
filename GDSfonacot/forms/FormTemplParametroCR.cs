using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDSfonacot.forms
{
    public partial class FormTemplParametroCR : Form
    {
        public FormTemplParametroCR()
        {
            InitializeComponent();
        }

        private void textparam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                
                forms.formVisorReportes frmvisor = new forms.formVisorReportes();//crea una instancia del formulario

                frmvisor.valor = textparam.Text.Trim();
                //frmvisor.MdiParent = MDIPrincip();
                frmvisor.Show();
                this.Hide();  //oculta el formulario

            }
        }
    }
}
