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
    public partial class MDIPrincip : Form
    {
        public MDIPrincip()
        {
            InitializeComponent();
        }

        private void MDIPrincip_Load(object sender, EventArgs e)
        {

        }

        private void menuSupOp_Click(object sender, EventArgs e)
        {
            Supervisiones frmsup = new Supervisiones();//crea una instancia del formulario
            frmsup.MdiParent = this;
            frmsup.Show();
            //  frmsup.ShowDialog(); //muestra el formulario en forma modal
        }

        private void menuHistsupOp_Click(object sender, EventArgs e)
        {
            FichasSupervision frmfichassup = new FichasSupervision();//crea una instancia del formulario
            frmfichassup.MdiParent = this;
            frmfichassup.Show();
            //   frmfichassup.ShowDialog(); //muestra el formulario de forma modal
        }

        private void menuFichasSuc_Click(object sender, EventArgs e)
        {
            SupOperaciones frmsupOp = new SupOperaciones();//crea una instancia del formulario
            frmsupOp.MdiParent = this;
            frmsupOp.Show();
            // frmsupOp.ShowDialog(); //muestra el formulario en forma modal
        }

        private void menuFichasPerson_Click(object sender, EventArgs e)
        {
            PersonalSucursales frmPersonsuc = new PersonalSucursales();//crea una instancia del formulario
            frmPersonsuc.MdiParent = this;
            frmPersonsuc.Show();
            //   frmsup.ShowDialog(); //muestra el formulario en forma modal
        }

        private void menuSeguSup_Click(object sender, EventArgs e)
        {
            SeguimientoSup frmsegSup = new SeguimientoSup();//crea una instancia del formulario
            frmsegSup.MdiParent = this;
            frmsegSup.Show();
            // frmsegSup.ShowDialog(); //muestra el formulario en forma modal
        }

        private void menuMinutas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Minutas de trabajo");// Mensaje en pantalla
        }

        private void MDIPrincip_Resize(object sender, EventArgs e)
        {

        }

        private void menuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();//
        }

      
    }
}
