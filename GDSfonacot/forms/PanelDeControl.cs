using GDSfonacot.forms;
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
    public partial class PanelDeControl : Form
    {
        public PanelDeControl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSupOperaciones_Click(object sender, EventArgs e)
        {
            FormBusConsultasSupervision frmsup = new FormBusConsultasSupervision();//crea una instancia del formulario
            frmsup.ShowDialog(); //muestra el formulario en forma modal
        }

        private void btnFichasSuc_Click(object sender, EventArgs e)
        {
            SupOperaciones frmsupOp = new SupOperaciones();//crea una instancia del formulario
            frmsupOp.ShowDialog(); //muestra el formulario en forma modal
        }

        private void btnHisSupervision_Click(object sender, EventArgs e)
        {
            FichasSupervision frmfichassup = new FichasSupervision();//crea una instancia del formulario
            frmfichassup.ShowDialog(); //muestra el formulario de forma modal
        }

        private void btnMinuta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Minutas de trabajo");// Mensaje en pantalla

        }

        private void btnCerrarApl_Click(object sender, EventArgs e)
        {
            Application.Exit();//salir de aplicacion completamentess
        }

        private void butSegSup_Click(object sender, EventArgs e)
        {
            SeguimientoSup frmsegSup = new SeguimientoSup();//crea una instancia del formulario
            frmsegSup.ShowDialog(); //muestra el formulario en forma modal
        }

        private void butFicPerson_Click(object sender, EventArgs e)
        {
            PersonalSucursales frmFichPer = new PersonalSucursales();//crea una instancia del formulario
            frmFichPer.ShowDialog(); //muestra el formulario en forma modal
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Formulario reportes");// Mensaje en pantalla
        }
    }
}
