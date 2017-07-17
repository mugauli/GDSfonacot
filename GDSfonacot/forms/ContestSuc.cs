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
    
    public partial class ContestSuc : Form
    {
        
        
        public int valor1 = 0;
        public String valor2 = "";
        public ContestSuc()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
                    }

        private void ContestSuc_Load(object sender, EventArgs e)
        {
            LlenarDatos();
        }
        private void LlenarDatos()
        {
            var objSupervision = new SupervisionesData();
            var busqueda = objSupervision.ObtenerDatosSupervision(valor1, valor2,2);
            if (busqueda.Result != null)
            {
                txthidIdSup.Text = busqueda.Result.IdSupervisiones.ToString();
                txthidIdConst.Text = "0";
                txtNoSupervision.Text = busqueda.Result.NoSupervision.ToString();
                txtDirRegional.Text = busqueda.Result.Director_Regional.ToString();
                txtDirEstatal.Text= busqueda.Result.Director_Estatal.ToString();
                txtSucursal.Text= busqueda.Result.NoSucursal.ToString() + "- " +busqueda.Result.DescripcionSucursal.ToString();
                txthidIdSup.Text = busqueda.Result.IdSupervisiones.ToString();
                toolButGuardar.Enabled = true;
                toolButImprimir.Enabled = false;

            }
        }
        private bool validarDatos()
        {
            if (string.IsNullOrEmpty(txtNoOficio.Text.Trim()) || txtNoOficio.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa un numero de Oficio", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNoOficio.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtNoSupervision.Text.Trim()) || txtNoSupervision.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa un numero de supervision", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNoSupervision.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtInmueble.Text.Trim()) || txtInmueble.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa la informacion del Inmueble", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtInmueble.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtGesDireccion.Text.Trim()) || txtGesDireccion.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa la informacion de gestión de la dirección", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtGesDireccion.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtOriginacion.Text.Trim()) || txtOriginacion.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa la informacion de Originación", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtOriginacion.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtTransfer.Text.Trim()) || txtTransfer.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa la informacion de Tarjetas transfer", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTransfer.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtCredito.Text.Trim()) || txtCredito.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa la informacion de Crédito", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCredito.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtUTYS.Text.Trim()) || txtUTYS.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa la informacion de UTYS", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUTYS.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtPromocionales.Text.Trim()) || txtPromocionales.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa la informacion de promocionales", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPromocionales.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtCobranza.Text.Trim()) || txtCobranza.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa la informacion de cobranza", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCobranza.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtFonFijo.Text.Trim()) || txtFonFijo.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa la informacion de fondo fijo", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtFonFijo.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(textAcuerdosCompr.Text.Trim()) || textAcuerdosCompr.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa la informacion de fondo fijo", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textAcuerdosCompr.Focus();
                return true;
            }


            return false;
        }
        private void toolButGuardar_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                return;
            }

            // MessageBox.Show("pASO VALIDACION");
            if (MessageBox.Show("¿La información es correcta? por favor verifique antes de ser registrada", System.Windows.Forms.Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                ;// Mensaje en pantallas)
                var objSupervision = new ContestacionesSuperv_Sucursales();
                objSupervision.Idcontestacion = Convert.ToInt32(txthidIdConst.Text.Trim());
                objSupervision.Idsupervision= Convert.ToInt32(txthidIdSup.Text.Trim());
                objSupervision.NoOficio = txtNoOficio.Text.Trim();
                objSupervision.Inmueble = txtInmueble.Text.Trim();
                objSupervision.Gestion_direccion = txtGesDireccion.Text.Trim();
                objSupervision.Originacion = txtOriginacion.Text.Trim();
                objSupervision.Tarjetas_transfer = txtTransfer.Text.Trim();
                objSupervision.Credito = txtCredito.Text.Trim();
                objSupervision.Utys = txtUTYS.Text.Trim();
                objSupervision.Promocionales = txtPromocionales.Text.Trim();
                objSupervision.Cobranza = txtCobranza.Text.Trim();
                objSupervision.Fondofijo = txtFonFijo.Text.Trim();
                objSupervision.AcuerdosCompromisos = textAcuerdosCompr.Text.Trim();
                objSupervision.Idusuariocreador = Globales.objpasardatosusuario.IdUsuario;
                objSupervision.FechaCreacionContest= DateTime.Now;
                var gdSupervisiones = new SupervisionesData().GuardarConstestacionSucursal(objSupervision);
                if (gdSupervisiones.Code != 0)
                {
                    //Mensage de error con g
                    toolButGuardar.Enabled = true;
                    MessageBox.Show(gdSupervisiones.Message.ToString(), System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    toolButImprimir.Enabled = false;

                }
                else
                {
                    
                    toolButGuardar.Enabled = false;
                    toolButImprimir.Enabled = true;
                    MessageBox.Show("La Contestacion ha sido guardada correctamente,espere la revision del supervisor", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //  LimpiarDatos();
                    var obactualizarsup = new HistorialSupervisiones();
                    obactualizarsup.IdSupervisiones =Convert.ToInt32(txthidIdSup.Text.Trim());
                    obactualizarsup.Idstatus = 2;
                    var actualizarsup = new SupervisionesData().ActualizarSupervision(obactualizarsup);
                    if (actualizarsup.Code!=0)
                    {
                        
                        MessageBox.Show(gdSupervisiones.Message.ToString(), System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        
                    }
                    else
                    {
                        //La supervision se actualizo a estatus 3, se considera cerrada y ya no se pueden hacer mas contestaciones  a esa supervision
                    }
                }

            }
            else
            {
                MessageBox.Show("La Contestacion no fue guardada, por favor intente nuevamente", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                toolButGuardar.Enabled = true;
                toolButImprimir.Enabled = false;
            }
        }

        private void txthidIdSup_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
