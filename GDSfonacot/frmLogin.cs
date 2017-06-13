using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDSfonacot
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void butEntrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Acceso Correcto");// Mensaje en pantalla
            PanelDeControl frmPanel = new PanelDeControl();//crea una instancia del formulario
            this.Hide();  //oculta el formulario
            frmPanel.ShowDialog();//muestra el formulario forma modal
            this.Close();//cierra el formulario
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();//salir de aplicacion completamentes
        }
    }
}
