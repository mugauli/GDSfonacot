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
            timesup.Start();
            timerreasig.Start();
            lblNombreUsuario.Text = Globales.objpasardatosusuario.Nombre_Usuario;
        }

        private void menuHistsupOp_Click(object sender, EventArgs e)
        {
            
            if (Globales.objpasardatosusuario.IdNivel == 2 || Globales.objpasardatosusuario.IdNivel == 1 || Globales.objpasardatosusuario.IdNivel == 3)
            {
                int[] varstatus = { 3,2 };
                var frmbusquedasup = new frmBusquedaSupervisiones(3, varstatus, 1,0);//crea una instancia del formulario
                frmbusquedasup.MdiParent = this;
                frmbusquedasup.Show();
                varstatus = null;
            }
            else
            {
                MessageBox.Show("No tienes acceso a este modulo,verifique con el administrador del sistema", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
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

        private void menuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();//
        }


        private void submenuSuc_Click(object sender, EventArgs e)
        {
            if (Globales.objpasardatosusuario.IdNivel == 2 || Globales.objpasardatosusuario.IdNivel == 3)
            {
                MessageBox.Show("No tienes acceso a este modulo,verifique con el administrador del sistema", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
            }
            else
            {
                var frmsucurs = new frmSucursales(0);//crea una instancia del formulario
                frmsucurs.MdiParent = this;
                frmsucurs.Show();

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
                var frmPersonsuc = new frmUsuarios(0);//crea una instancia del formulario
                frmPersonsuc.MdiParent = this;
                frmPersonsuc.Show();
            }
        }

        private void mnuSupContestSeguimSuperv_Click(object sender, EventArgs e)
        {
            if (Globales.objpasardatosusuario.IdNivel == 2 || Globales.objpasardatosusuario.IdNivel == 1 || Globales.objpasardatosusuario.IdNivel == 3)
            {
                int[] varstatus = { 1 };

                var frmbusquedasup = new frmBusquedaSupervisiones(1, varstatus, 0,0);//crea una instancia del formulario
                frmbusquedasup.MdiParent = this;
                frmbusquedasup.Show();
                varstatus = null;
            }
            else
            {
                MessageBox.Show("No tienes acceso a este modulo,verifique con el administrador del sistema", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
            }
        }

   

   
        private void mnuSolventarSeg_Click(object sender, EventArgs e)
        {
            if (Globales.objpasardatosusuario.IdNivel == 2 || Globales.objpasardatosusuario.IdNivel == 1 || Globales.objpasardatosusuario.IdNivel == 3)
            {
                //forms.FormBusSegRespuesta frmsup = new forms.FormBusSegRespuesta();//crea una instancia del formulario
                //frmsup.MdiParent = this;
                //frmsup.Show();
                //  frmsup.ShowDialog(); //muestra el formulario en forma modal
            }
            else
            {
                MessageBox.Show("No tienes acceso a este modulo,verifique con el administrador del sistema", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
            }
        }

        private void menuInicioSup_Click(object sender, EventArgs e)
        {
            if ( Globales.objpasardatosusuario.IdNivel == 1 || Globales.objpasardatosusuario.IdNivel == 3)
            {

                var frminicioSup = new frmSupervisiom(0);//crea una instancia del formulario
                frminicioSup.MdiParent = this;
                frminicioSup.Show();
            }
            else
            {
                MessageBox.Show("No tienes acceso a este modulo,verifique con el administrador del sistema", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
            }
        }

        private void menuConstSupSuc_Click(object sender, EventArgs e)
        {
            if (Globales.objpasardatosusuario.IdNivel == 2 || Globales.objpasardatosusuario.IdNivel == 1 || Globales.objpasardatosusuario.IdNivel == 3)
            {
                int[] varstatus = { 1 };
                var frmbusquedasup = new frmBusquedaSupervisiones(2, varstatus, 0,0);//crea una instancia del formulario
                frmbusquedasup.MdiParent = this;
                frmbusquedasup.Show();
                varstatus = null;
            }
            else
            {
                MessageBox.Show("No tienes acceso a este modulo,verifique con el administrador del sistema", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
            }
        }

        private void menuCerrarSup_Click(object sender, EventArgs e)
        {
            if (Globales.objpasardatosusuario.IdNivel == 1 || Globales.objpasardatosusuario.IdNivel == 3 || Globales.objpasardatosusuario.IdNivel ==1004)
            {
                int[] varstatus = { 2, };

                var frmbusquedasup = new frmBusquedaSupervisiones(3, varstatus, 0,0);//crea una instancia del formulario
                frmbusquedasup.MdiParent = this;
                frmbusquedasup.Show();
                varstatus = null;
            }
            else
            {
                MessageBox.Show("No tienes acceso a este modulo,verifique con el administrador del sistema", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
            }
        }

        private void menuBuscarConst_Click(object sender, EventArgs e)
        {
            if (Globales.objpasardatosusuario.IdNivel == 2 || Globales.objpasardatosusuario.IdNivel == 1 || Globales.objpasardatosusuario.IdNivel == 3)
            {
                int[] varstatus = {2,5};
                var frmbusquedasup = new frmBusquedaSupervisiones(2, varstatus, 1,0);//crea una instancia del formulario
                frmbusquedasup.MdiParent = this;
                frmbusquedasup.Show();
                varstatus = null;
            }
            else
            {
                MessageBox.Show("No tienes acceso a este modulo,verifique con el administrador del sistema", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
            }
        }

        private void menubuscSup_Click(object sender, EventArgs e)
        {
            if (Globales.objpasardatosusuario.IdNivel == 1 || Globales.objpasardatosusuario.IdNivel == 3 || Globales.objpasardatosusuario.IdNivel ==1004)
            {
                int[] varstatus = { 1,2,3,5 };
                var frmbusquedasup = new frmBusquedaSupervisiones(4, varstatus, 1,0);//crea una instancia del formulario
                frmbusquedasup.MdiParent = this;
                frmbusquedasup.Show();
                varstatus = null;
            }
            else
            {
                MessageBox.Show("No tienes acceso a este modulo,verifique con el administrador del sistema", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
            }
        }

        private void menuConsulUsu_Click(object sender, EventArgs e)
        {
            if (Globales.objpasardatosusuario.IdNivel == 2 || Globales.objpasardatosusuario.IdNivel == 3)
            {
                MessageBox.Show("No tienes acceso a este modulo,verifique con el administrador del sistema", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
            }
            else
            {
                var frmPersonsuc = new frmBusquedaSucursal(3);//crea una instancia del formulario
                frmPersonsuc.MdiParent = this;
                frmPersonsuc.Show();
            }
        }

        private void menuConsulSucur_Click(object sender, EventArgs e)
        {
            if (Globales.objpasardatosusuario.IdNivel == 2 || Globales.objpasardatosusuario.IdNivel == 3)
            {
                MessageBox.Show("No tienes acceso a este modulo,verifique con el administrador del sistema", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
            }
            else
            {
                var frmPersonsuc = new frmBusquedaSucursal(2);//crea una instancia del formulario
                frmPersonsuc.MdiParent = this;
                frmPersonsuc.Show();
            }
        }

        private void menuConsulEmp_Click(object sender, EventArgs e)
        {
            if (Globales.objpasardatosusuario.IdNivel == 2 || Globales.objpasardatosusuario.IdNivel == 3 || Globales.objpasardatosusuario.IdNivel ==1004)
            {
                MessageBox.Show("No tienes acceso a este modulo, verifique con el administrador del sistema", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
            }
            else
            {
                //if (Globales.objpasardatosusuario.IdNivel == 1)
                //{
                    var frmPersonsuc = new frmBusquedaSucursal(1);//crea una instancia del formulario
                    frmPersonsuc.MdiParent = this;
                    frmPersonsuc.Show();
                
             }
            //    else
            //    {
            //        PersonalSucursales frmPersonsuc = new PersonalSucursales(Globales.objpasardatosusuario.IdSucursal.Value);//crea una instancia del formulario
            //        frmPersonsuc.MdiParent = this;
            //        frmPersonsuc.Show();
            //    }
          }

        private void menucatEmp_Click(object sender, EventArgs e)
        {
            if (Globales.objpasardatosusuario.IdNivel == 2 || Globales.objpasardatosusuario.IdNivel == 3 || Globales.objpasardatosusuario.IdNivel == 1004)
            {
                MessageBox.Show("No tienes acceso a este modulo, verifique con el administrador del sistema", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
            }
            else
            {
                //if (Globales.objpasardatosusuario.IdNivel == 1)
                //{
                var frmemp = new frmEmpleados(0);//crea una instancia del formulario
                frmemp.MdiParent = this;
                frmemp.Show();

            }
        }

        private void menuSegSup_Click(object sender, EventArgs e)
        {
            if (Globales.objpasardatosusuario.IdNivel == 1 || Globales.objpasardatosusuario.IdNivel == 3 || Globales.objpasardatosusuario.IdNivel ==1004)
            {
                int[] varstatus = {1,2};
                var frmbusquedasup = new frmBusquedaSupervisiones(1, varstatus, 0,0);//crea una instancia del formulario
                frmbusquedasup.MdiParent = this;
                frmbusquedasup.Show();
                varstatus = null;
            }
            else
            {
                MessageBox.Show("No tienes acceso a este modulo,verifique con el administrador del sistema", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
            }
        }

        private void menubuscSeguim_Click(object sender, EventArgs e)
        {
            if (Globales.objpasardatosusuario.IdNivel == 1 || Globales.objpasardatosusuario.IdNivel == 3 || Globales.objpasardatosusuario.IdNivel ==1004)
            {
                int[] varstatus = { 2, 5,3,1 };
                var frmbusquedasup = new frmBusquedaSupervisiones(1, varstatus, 1, 1);//crea una instancia del formulario
                frmbusquedasup.MdiParent = this;
                frmbusquedasup.Show();
                varstatus = null;
            }
            else
            {
                MessageBox.Show("No tienes acceso a este modulo,verifique con el administrador del sistema", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
            }
        }

        private void timesup_Tick(object sender, EventArgs e)
        {
            notificationcreadas();

        }

        private void timerreasig_Tick(object sender, EventArgs e)
        {
            notificationreasignadas();
        }
        private void notificationcreadas()
        {
            int[] varstatus = { 1 };
            var objcreadasSupervision = new SupervisionesData();
            var busqueda = objcreadasSupervision.ObtenerTotalSupSucursal(varstatus);

            if (Globales.objpasardatosusuario.IdNivel == 2)
            {
                if (busqueda.Result != null)
                {
                    if (busqueda.Result.Count != 0)
                    {

                        notifySupCreadas.BalloonTipText = "*Tienes " + busqueda.Result.Count + " supervisiones pendientes favor de ingresar a 'Crear Contestación para Supervisión'";
                        notifySupCreadas.ShowBalloonTip(0);
                      
                    }
                    else
                    {
                        //No muestro nada
                    }

                }
              
            }
            objcreadasSupervision = null;
            busqueda = null;
        }

        private void notificationreasignadas()
        {
            int[] varstatus2 = { 5 };
            var objreasignadasSupervision = new SupervisionesData();
            var busqueda2 = objreasignadasSupervision.ObtenerTotalSupSucursal(varstatus2);
            if (Globales.objpasardatosusuario.IdNivel == 2)
            {
                if (busqueda2.Result != null)
                {
                    if (busqueda2.Result.Count != 0)
                    {

                        notifySupReasignadas.BalloonTipText = "*Tienes " + busqueda2.Result.Count + " supervisiones reasignadas favor de ingresar a 'Contestaciones de Supervision'";
                        notifySupReasignadas.ShowBalloonTip(5);
                    }
                    else
                    {
                        //No muestro nada
                    }
                }

            }
            objreasignadasSupervision = null;
            busqueda2 = null;
        }
    
    }
}
