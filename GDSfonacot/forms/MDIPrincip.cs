using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDSfonacotDatos;
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
            if (Globales.objpasardatosusuario.IdNivel == 2 || Globales.objpasardatosusuario.IdNivel == 1)
            {
                Supervisiones frmsup = new Supervisiones();//crea una instancia del formulario
                frmsup.MdiParent = this;
                frmsup.Show();
                //  frmsup.ShowDialog(); //muestra el formulario en forma modal
            }
            else
            {
                MessageBox.Show("No tienes acceso a este modulo,verifique con el administrador del sistema", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
            }

        }

        private void menuHistsupOp_Click(object sender, EventArgs e)
        {
            if (Globales.objpasardatosusuario.IdNivel == 2)
            {
                MessageBox.Show("No tienes acceso a este modulo,verifique con el administrador del sistema", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
            }
            else
            {
                FichasSupervision frmfichassup = new FichasSupervision();//crea una instancia del formulario
                frmfichassup.MdiParent = this;
                frmfichassup.Show();
                //   frmfichassup.ShowDialog(); //muestra el formulario de forma modal
            }
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
            if (Globales.objpasardatosusuario.IdNivel == 2)
            {
                MessageBox.Show("No tienes acceso a este modulo,verifique con el administrador del sistema", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
            }
            else
            {
                PersonalSucursales frmPersonsuc = new PersonalSucursales();//crea una instancia del formulario
                frmPersonsuc.MdiParent = this;
                frmPersonsuc.Show();
                //   frmsup.ShowDialog(); //muestra el formulario en forma modal
            }
        }

        private void menuSeguSup_Click(object sender, EventArgs e)
        {
            if (Globales.objpasardatosusuario.IdNivel == 2)
            {
                MessageBox.Show("No tienes acceso a este modulo,verifique con el administrador del sistema", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
            }
            else
            {
                SeguimientoSup frmsegSup = new SeguimientoSup();//crea una instancia del formulario
                frmsegSup.MdiParent = this;
                frmsegSup.Show();
                // frmsegSup.ShowDialog(); //muestra el formulario en forma modal
            }
        }

        private void menuMinutas_Click(object sender, EventArgs e)
        {
            if (Globales.objpasardatosusuario.IdNivel == 2)
            {
                MessageBox.Show("No tienes acceso a este modulo,verifique con el administrador del sistema", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
            }
            else
            {
                MessageBox.Show("Minutas de trabajo");// Mensaje en pantalla
            }
        }

        private void MDIPrincip_Resize(object sender, EventArgs e)
        {

        }

        private void menuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();//
        }

        private void menuConstSuc_Click(object sender, EventArgs e)
        {
            if (Globales.objpasardatosusuario.IdNivel == 2 || Globales.objpasardatosusuario.IdNivel == 1)
            {
                ContestSuc frmConstSuc = new ContestSuc();//crea una instancia del formulario
                frmConstSuc.MdiParent = this;
                frmConstSuc.Show();
                // frmsegSup.ShowDialog(); //muestra el formulario en forma modal
            }
            else
            {
                MessageBox.Show("No tienes acceso a este modulo,verifique con el administrador del sistema", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
                
            }
        }

        private void menuCatalogos_Click(object sender, EventArgs e)
        {
           
        }

        private void submenuSuc_Click(object sender, EventArgs e)
        {
            if (Globales.objpasardatosusuario.IdNivel == 2)
            {
                MessageBox.Show("No tienes acceso a este modulo,verifique con el administrador del sistema", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
            }
            else
            {
                MessageBox.Show("Catalogo de las  sucursales");// Mensaje en pantalla
            }

        }

        private void submenuUsers_Click(object sender, EventArgs e)
        {
            if (Globales.objpasardatosusuario.IdNivel == 2)
            {
                MessageBox.Show("No tienes acceso a este modulo,verifique con el administrador del sistema", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
            }
            else
            {
                MessageBox.Show("Catalogo de los usuarios");// Mensaje en pantalla
            }
        }

        private void menuReportes_Click(object sender, EventArgs e)
        {
            if (Globales.objpasardatosusuario.IdNivel == 2 || Globales.objpasardatosusuario.IdNivel == 1)
            {
                 forms.formVisorReportes   frmvisor = new forms.formVisorReportes();//crea una instancia del formulario
                frmvisor.MdiParent = this;
                frmvisor.Show();
                // frmsegSup.ShowDialog(); //muestra el formulario en forma modal
            }
            else
            {
                MessageBox.Show("No tienes acceso a este modulo,verifique con el administrador del sistema", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
                
            }
        }
    }
}
