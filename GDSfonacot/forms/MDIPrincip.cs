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
using GDSfonacot.forms;

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
            lblNombreUsuario.Text = Globales.objpasardatosusuario.Nombre_Usuario;
        }

        private void menuSupOp_Click(object sender, EventArgs e)
        {
            

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

        

        private void menuMinutas_Click(object sender, EventArgs e)
        {
            if (Globales.objpasardatosusuario.IdNivel == 2 || Globales.objpasardatosusuario.IdNivel == 3)
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

       

        private void menuCatalogos_Click(object sender, EventArgs e)
        {
           
        }

        private void submenuSuc_Click(object sender, EventArgs e)
        {
            if (Globales.objpasardatosusuario.IdNivel == 2 || Globales.objpasardatosusuario.IdNivel == 3)
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
            if (Globales.objpasardatosusuario.IdNivel == 2 || Globales.objpasardatosusuario.IdNivel == 3)
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
                 forms.FormTemplParametroCR   frmtempparam = new forms.FormTemplParametroCR();//crea una instancia del formulario
                frmtempparam.ShowDialog();//muestra el formulario forma modal
              
            }
            else
            {
                MessageBox.Show("No tienes acceso a este modulo,verifique con el administrador del sistema", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
                
            }
        }

        private void mnuSupContestSuc_Click(object sender, EventArgs e)
        {
            if (Globales.objpasardatosusuario.IdNivel == 2 || Globales.objpasardatosusuario.IdNivel == 1 || Globales.objpasardatosusuario.IdNivel == 3)
            {
                FormBusConsultasSupervision frmsup = new FormBusConsultasSupervision();//crea una instancia del formulario
                frmsup.MdiParent = this;
                frmsup.Show();
                //  frmsup.ShowDialog(); //muestra el formulario en forma modal
            }
            else
            {
                MessageBox.Show("No tienes acceso a este modulo,verifique con el administrador del sistema", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
            }
        }

        private void mnuSupConsultaSuperv_Click(object sender, EventArgs e)
        {
            if (Globales.objpasardatosusuario.IdNivel == 2 || Globales.objpasardatosusuario.IdNivel == 1 || Globales.objpasardatosusuario.IdNivel == 3)
            {
                forms.FormBusConsultasSupervision frmsup = new forms.FormBusConsultasSupervision();//crea una instancia del formulario
                frmsup.MdiParent = this;
                frmsup.Show();
                //  frmsup.ShowDialog(); //muestra el formulario en forma modal
            }
            else
            {
                MessageBox.Show("No tienes acceso a este modulo,verifique con el administrador del sistema", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
            }
        }

        private void mnuSupContestSeguimSuperv_Click(object sender, EventArgs e)
        {
            if (Globales.objpasardatosusuario.IdNivel == 2 || Globales.objpasardatosusuario.IdNivel == 1 || Globales.objpasardatosusuario.IdNivel == 3)
            {
                forms.FormBusConsultasSupervision frmsup = new forms.FormBusConsultasSupervision();//crea una instancia del formulario
                frmsup.MdiParent = this;
                frmsup.Show();
                //  frmsup.ShowDialog(); //muestra el formulario en forma modal
            }
            else
            {
                MessageBox.Show("No tienes acceso a este modulo,verifique con el administrador del sistema", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
            }
        }

        private void lblNombreUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
