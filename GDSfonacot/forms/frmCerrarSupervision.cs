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
using GDSfonacotDatos.Data;

namespace GDSfonacot.forms
{
    public partial class frmCerrarSupervision : Form
    {
        public int valor1 = 0;
        public int varstatus = 0;
        private int IdCierre = 0;
        public int cierramanual = 0;
        private int guardo = 0;
        public frmCerrarSupervision(int cierre)
        {
            InitializeComponent();
            IdCierre = cierre;
           
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var mensaje = string.Empty;
            if (ValidateCierre(out mensaje))
            {
                MessageBox.Show(mensaje);
                return;
            }
            if (MessageBox.Show("¿La información es correcta? por favor verifique antes de ser registrada, despues no se podrá modificar", System.Windows.Forms.Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                var cierre = new Cierres();
                cierre.Idcierre = Convert.ToInt32(txthidIdCierre.Text.ToString());
                cierre.MotivoCierre = txtMotivocierre.Text.ToString().Trim();
                cierre.fechacierre = dtfechacierre.Value;
                cierre.solventada = checksolventada.Checked;
                cierre.Idsupervision = Convert.ToInt32(txthidIdSup.Text.ToString());
                cierre.Idusuariocreador = Globales.objpasardatosusuario.IdUsuario;
                cierre.FechaCreacion = DateTime.Now;

                var objCierre= new CierresData().GuadarCierre(cierre);
                if (objCierre.Code != 0)
                {
                    MessageBox.Show("Error: " + objCierre.Message);
                    return;
                    //Mandar mensaje de error con sucursales.Message
                }
                else
                {
                    if (txthidStatus.Text == "2")
                    {
                    var obactualizarsup = new HistorialSupervisiones();
                    obactualizarsup.IdSupervisiones = Convert.ToInt32(txthidIdSup.Text.Trim());
                    obactualizarsup.Idstatus = 3;
                    var actualizarsup = new SupervisionesData().ActualizarSupervision(obactualizarsup);
                    if (actualizarsup.Code != 0)
                    {

                        MessageBox.Show(actualizarsup.Message.ToString(), System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    MessageBox.Show("Esta supervision ha sido cerrada", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                   // this.Close();
                    }
                
                    MessageBox.Show("El cierre de supervision fue guardado correctamente", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cierramanual = 0;
                    guardo = 1;
                    this.Close();
                }

            }
         else
            {
                MessageBox.Show("El Ciere no fue guardado, por favor intente nuevamente", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cierramanual = 0;
                guardo = 0;
            }

       }
        private bool ValidateCierre(out string mensaje)
        {
            mensaje = string.Empty;
            if (txtMotivocierre.Text == string.Empty) mensaje += "Favor de introducir Motivo de Cierre\n";
            return !(mensaje == string.Empty);
        }
       
        private void LimpiarDatos()
        {
            txthidIdSup.Text = "0";
            txthidIdCierre.Text = "0";
            txthidStatus.Text = "0";
            dtfechacierre.Value = DateTime.Now;
            checksolventada.Checked = false;
            checksolventada.Text = "";


        }

        private void frmCerrarSupervision_Load(object sender, EventArgs e)
        {
            if (IdCierre != 0)
            {

            }
            else
            {
                LimpiarDatos();
                txthidIdSup.Text = Convert.ToString(valor1);
                txthidStatus.Text = Convert.ToString(varstatus);
            }
        }

        private void checksolventada_CheckedChanged(object sender, EventArgs e)
        {
            if (checksolventada.Checked==true)
            {
                checksolventada.Text = "Solventada";
            }
            else
            {

                checksolventada.Text = "No Solventada";
            }
        }

        private void frmCerrarSupervision_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (guardo == 0)
            {
                cierramanual = 1;
            }
            else
            {
                cierramanual = 0;
            }
        }
    }
}
