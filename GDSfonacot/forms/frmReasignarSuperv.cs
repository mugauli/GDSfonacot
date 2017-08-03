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
    public partial class frmReasignarSuperv : Form
    {
        public int valor1 = 0;
        public int varstatus = 0;
        private int Idreasignacion = 0;
        public int cierramanual = 0;
        private int guardo=0;
        public frmReasignarSuperv(int reasignacion)
        {
            InitializeComponent();
            Idreasignacion = reasignacion;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var mensaje = string.Empty;
            if (ValidateReasignacion(out mensaje))
            {
                MessageBox.Show(mensaje);
                return;
            }
            if (MessageBox.Show("¿La información es correcta? por favor verifique antes de ser registrada, despues no se podrá modificar", System.Windows.Forms.Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                var reasignacion = new Reasignaciones ();
                reasignacion.Idreasignacion = Convert.ToInt32(txthidIdReasignacion.Text.ToString());
                reasignacion.MotivoReasigna = txtMotivoReasigna.Text.ToString().Trim();
                reasignacion.fechareasignada = dtFechaReasigna.Value;
                reasignacion.Idsupervision = Convert.ToInt32(txthidIdSup.Text.ToString());
                reasignacion.Idusuariocreador = Globales.objpasardatosusuario.IdUsuario;
                reasignacion.FechaCreacion = DateTime.Now;

                var objCierre = new ReasignacionesData().GuardarReasignacion(reasignacion);
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
                        obactualizarsup.Idstatus = 5;
                        var actualizarsup = new SupervisionesData().ActualizarSupervision(obactualizarsup);
                        if (actualizarsup.Code != 0)
                        {

                            MessageBox.Show(actualizarsup.Message.ToString(), System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        MessageBox.Show("Favor de esperar a que la sucursal realice las modificaciones en la contestacion de la supervision", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // this.Close();
                    }

                    MessageBox.Show("La reasignacion de supervision fue guardada correctamente", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cierramanual = 0;
                    guardo = 1;
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("La reasignacion no fue guardada, por favor intente nuevamente", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cierramanual = 0;
                guardo = 0;
            }

        }
        private bool ValidateReasignacion(out string mensaje)
        {
            mensaje = string.Empty;
            if (txtMotivoReasigna.Text == string.Empty) mensaje += "Favor de introducir Motivo de Reasignacion\n";
            return !(mensaje == string.Empty);
        }

        private void LimpiarDatos()
        {
            txthidIdSup.Text = "0";
            txthidIdReasignacion.Text = "0";
            txthidStatus.Text = "0";
            dtFechaReasigna.Value = DateTime.Now;
        }

         private void frmReasignarSuperv_Load(object sender, EventArgs e)
        {
            if (Idreasignacion != 0)
            {

            }
            else
            {
                LimpiarDatos();
                txthidIdSup.Text = Convert.ToString(valor1);
                txthidStatus.Text = Convert.ToString(varstatus);
            }

        }

        private void frmReasignarSuperv_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (guardo == 0)
            {
                cierramanual = 1;
            }
            else {
                cierramanual = 0;
            }
        }
    }
}
