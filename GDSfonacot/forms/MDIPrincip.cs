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
            try
            {
                if (Globales.objpasardatosusuario.IdNivel == 2)
                {
                    timesup.Start();
                    timerreasig.Start();
                }
                else
                {
                    timesup.Stop();
                    timerreasig.Stop();
                }
                lblNombreUsuario.Text = Globales.objpasardatosusuario.Nombre_Usuario;
                CargarMenus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex, System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void menuHistsupOp_Click(object sender, EventArgs e)
        {
            try
            {
                if (Globales.objpasardatosusuario.IdNivel == 2 || Globales.objpasardatosusuario.IdNivel == 1 || Globales.objpasardatosusuario.IdNivel == 3)
                {
                    int[] varstatus = { 3, 2 };
                    var frmbusquedasup = new frmBusquedaSupervisiones(3, varstatus, 1, 0);//crea una instancia del formulario
                    frmbusquedasup.MdiParent = this;
                    frmbusquedasup.Show();
                    varstatus = null;
                }
                else
                {
                    MessageBox.Show("No tienes acceso a este modulo,verifique con el administrador del sistema", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex, System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void menuMinutas_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex, System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void menuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();//
        }


        private void submenuSuc_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex, System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void submenuUsers_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex, System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void mnuSupContestSeguimSuperv_Click(object sender, EventArgs e)
        {
            try
            {
                if (Globales.objpasardatosusuario.IdNivel == 2 || Globales.objpasardatosusuario.IdNivel == 1 || Globales.objpasardatosusuario.IdNivel == 3)
                {
                    int[] varstatus = { 1 };

                    var frmbusquedasup = new frmBusquedaSupervisiones(1, varstatus, 0, 0);//crea una instancia del formulario
                    frmbusquedasup.MdiParent = this;
                    frmbusquedasup.Show();
                    varstatus = null;
                }
                else
                {
                    MessageBox.Show("No tienes acceso a este modulo,verifique con el administrador del sistema", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex, System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

   

   
        private void mnuSolventarSeg_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex, System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void menuInicioSup_Click(object sender, EventArgs e)
        {
            try
            {
                if (Globales.objpasardatosusuario.IdNivel == 1 || Globales.objpasardatosusuario.IdNivel == 3)
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
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex, System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void menuConstSupSuc_Click(object sender, EventArgs e)
        {
            try
            {
                if (Globales.objpasardatosusuario.IdNivel == 2 || Globales.objpasardatosusuario.IdNivel == 1 || Globales.objpasardatosusuario.IdNivel == 3)
                {
                    int[] varstatus = { 1 };
                    var frmbusquedasup = new frmBusquedaSupervisiones(2, varstatus, 0, 0);//crea una instancia del formulario
                    frmbusquedasup.MdiParent = this;
                    frmbusquedasup.Show();
                    varstatus = null;
                }
                else
                {
                    MessageBox.Show("No tienes acceso a este modulo,verifique con el administrador del sistema", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex, System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void menuCerrarSup_Click(object sender, EventArgs e)
        {
            try
            {
                if (Globales.objpasardatosusuario.IdNivel == 1 || Globales.objpasardatosusuario.IdNivel == 3 || Globales.objpasardatosusuario.IdNivel == 1004)
                {
                    int[] varstatus = { 2, };

                    var frmbusquedasup = new frmBusquedaSupervisiones(3, varstatus, 0, 0);//crea una instancia del formulario
                    frmbusquedasup.MdiParent = this;
                    frmbusquedasup.Show();
                    varstatus = null;
                }
                else
                {
                    MessageBox.Show("No tienes acceso a este modulo,verifique con el administrador del sistema", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex, System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void menuBuscarConst_Click(object sender, EventArgs e)
        {
            try
            {
                if (Globales.objpasardatosusuario.IdNivel == 2 || Globales.objpasardatosusuario.IdNivel == 1 || Globales.objpasardatosusuario.IdNivel == 3)
                {
                    int[] varstatus = { 2, 3, 5 };
                    var frmbusquedasup = new frmBusquedaSupervisiones(2, varstatus, 1, 0);//crea una instancia del formulario
                    frmbusquedasup.MdiParent = this;
                    frmbusquedasup.Show();
                    varstatus = null;
                }
                else
                {
                    MessageBox.Show("No tienes acceso a este modulo,verifique con el administrador del sistema", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex, System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void menubuscSup_Click(object sender, EventArgs e)
        {
            try
            {
                if (Globales.objpasardatosusuario.IdNivel == 1 || Globales.objpasardatosusuario.IdNivel == 3 || Globales.objpasardatosusuario.IdNivel == 1004)
                {
                    int[] varstatus = { 1, 2, 3, 5 };
                    var frmbusquedasup = new frmBusquedaSupervisiones(4, varstatus, 1, 0);//crea una instancia del formulario
                    frmbusquedasup.MdiParent = this;
                    frmbusquedasup.Show();
                    varstatus = null;
                }
                else
                {
                    MessageBox.Show("No tienes acceso a este modulo,verifique con el administrador del sistema", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex, System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void menuConsulUsu_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex, System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void menuConsulSucur_Click(object sender, EventArgs e)
        {
            try
            {
                if (Globales.objpasardatosusuario.IdNivel == 2 || Globales.objpasardatosusuario.IdNivel == 3 || Globales.objpasardatosusuario.IdNivel == 1 || Globales.objpasardatosusuario.IdNivel == 1004)
                {
                    var frmPersonsuc = new frmBusquedaSucursal(2);//crea una instancia del formulario
                    frmPersonsuc.MdiParent = this;
                    frmPersonsuc.Show();

                }
                else
                {
                    MessageBox.Show("No tienes acceso a este modulo,verifique con el administrador del sistema", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex, System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void menuConsulEmp_Click(object sender, EventArgs e)
        {
            try
            {
                if (Globales.objpasardatosusuario.IdNivel == 1 || Globales.objpasardatosusuario.IdNivel == 2 || Globales.objpasardatosusuario.IdNivel == 3 || Globales.objpasardatosusuario.IdNivel == 1004)
                {
                    var frmPersonsuc = new frmBusquedaSucursal(1);//crea una instancia del formulario
                    frmPersonsuc.MdiParent = this;
                    frmPersonsuc.Show();
                }
                else
                {
                    //if (Globales.objpasardatosusuario.IdNivel == 1)
                    //{


                }
                //    else
                //    {
                //        PersonalSucursales frmPersonsuc = new PersonalSucursales(Globales.objpasardatosusuario.IdSucursal.Value);//crea una instancia del formulario
                //        frmPersonsuc.MdiParent = this;
                //        frmPersonsuc.Show();
                //    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex, System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void menucatEmp_Click(object sender, EventArgs e)
        {
            try
            {
                if (Globales.objpasardatosusuario.IdNivel == 2 || Globales.objpasardatosusuario.IdNivel == 3 || Globales.objpasardatosusuario.IdNivel == 1004 || Globales.objpasardatosusuario.IdNivel == 1)
                {

                    var frmemp = new frmEmpleados(0);//crea una instancia del formulario
                    frmemp.MdiParent = this;
                    frmemp.Show();
                }
                else
                {
                    MessageBox.Show("No tienes acceso a este modulo, verifique con el administrador del sistema", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex, System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void menuSegSup_Click(object sender, EventArgs e)
        {
            try
            {
                if (Globales.objpasardatosusuario.IdNivel == 1 || Globales.objpasardatosusuario.IdNivel == 3 || Globales.objpasardatosusuario.IdNivel == 1004)
                {
                    int[] varstatus = { 1, 2 };
                    var frmbusquedasup = new frmBusquedaSupervisiones(1, varstatus, 0, 0);//crea una instancia del formulario
                    frmbusquedasup.MdiParent = this;
                    frmbusquedasup.Show();
                    varstatus = null;
                }
                else
                {
                    MessageBox.Show("No tienes acceso a este modulo,verifique con el administrador del sistema", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex, System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void menubuscSeguim_Click(object sender, EventArgs e)
        {
            try
            {
                if (Globales.objpasardatosusuario.IdNivel == 1 || Globales.objpasardatosusuario.IdNivel == 3 || Globales.objpasardatosusuario.IdNivel == 1004)
                {
                    int[] varstatus = { 2, 5, 3, 1 };
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
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex, System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void timesup_Tick(object sender, EventArgs e)
        {
            notificationcreadas();

        }

        public void timerreasig_Tick(object sender, EventArgs e)
        {
            notificationreasignadas();
        }
        public void notificationcreadas()
        {
            
            int[] varstatus = { 1 };
            var objcreadasSupervision = new SupervisionesData();
            try
            {
                var busqueda = objcreadasSupervision.ObtenerTotalSupSucursal(varstatus);

                if (Globales.objpasardatosusuario.IdNivel == 2)
                {
                    if (busqueda.Result != null)
                    {
                        if (busqueda.Result.Count != 0)
                        {

                            notifySupCreadas.BalloonTipText = "*Tienes " + busqueda.Result.Count + " supervisiones pendientes favor de ingresar a 'Crear Contestación para Supervisión'";
                            notifySupCreadas.ShowBalloonTip(0);
                            notifySupCreadas.Dispose();

                        }
                        else
                        {
                            //No muestro nada
                            notifySupReasignadas.Dispose();
                        }

                    }

                }
                objcreadasSupervision = null;
                busqueda = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex, System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void notificationreasignadas()
        {
            int[] varstatus2 = { 5 };
            var objreasignadasSupervision = new SupervisionesData();
            try
            {
                var busqueda2 = objreasignadasSupervision.ObtenerTotalSupSucursal(varstatus2);
                if (Globales.objpasardatosusuario.IdNivel == 2)
                {
                    if (busqueda2.Result != null)
                    {
                        if (busqueda2.Result.Count != 0)
                        {

                            notifySupReasignadas.BalloonTipText = "*Tienes " + busqueda2.Result.Count + " supervisiones reasignadas favor de ingresar a 'Contestaciones de Supervision'";
                            notifySupReasignadas.ShowBalloonTip(0);
                            notifySupReasignadas.Dispose();
                        }
                        else
                        {
                            //No muestro nada
                            notifySupReasignadas.Dispose();
                        }
                    }

                }
                objreasignadasSupervision = null;
                busqueda2 = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex, System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void CargarMenus()
        {
            try
            {
                if (Globales.objpasardatosusuario.IdNivel == 1 || Globales.objpasardatosusuario.IdNivel == 3 || Globales.objpasardatosusuario.IdNivel == 1004)
                {
                    menuInicioSup.Visible = true;
                    menuConstSupSuc.Visible = true;
                    menuSegSup.Visible = true;
                    menuCerrarSup.Visible = true;
                    menuSalir.Visible = true;
                    menubuscSup.Visible = true;
                    menuBuscarConst.Visible = true;
                    menubuscSeguim.Visible = true;
                    menuHistsupOp.Visible = true;
                    menuConsulUsu.Visible = true;
                    menuConsulSucur.Visible = true;
                    menuConsulEmp.Visible = true;
                    submenuSuc.Visible = true;
                    submenuUsers.Visible = true;
                    menucatEmp.Visible = true;
                }
                else if (Globales.objpasardatosusuario.IdNivel == 2)
                {
                    menuInicioSup.Visible = false;
                    menuConstSupSuc.Visible = true;
                    menuSegSup.Visible = false;
                    menuCerrarSup.Visible = false;
                    menuSalir.Visible = true;
                    menubuscSup.Visible = false;
                    menuBuscarConst.Visible = true;
                    menubuscSeguim.Visible = false;
                    menuHistsupOp.Visible = true;
                    menuConsulSucur.Visible = true;
                    menuConsulUsu.Visible = false;
                    menuConsulEmp.Visible = true;
                    submenuSuc.Visible = false;
                    submenuUsers.Visible = false;
                    menucatEmp.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex, System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    
    }
}
