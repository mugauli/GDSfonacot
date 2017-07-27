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
using GDSfonacotDatos.DTO;
using GDSfonacotDatos.Data;

namespace GDSfonacot.forms
{
    public partial class frmContestacionSucursal : Form
    {

        private int saveorupdate = 0;
        public int valor1 = 0;
        public String valor2 = "";
        public frmContestacionSucursal(int actualizarconst)
        {
            InitializeComponent();
            saveorupdate = actualizarconst;
        }


        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void frmContestacionSucursal_Load(object sender, EventArgs e)
        {
            if (saveorupdate == 0)
            {
                LlenarDatos();
            }
            else
            {
                CargarContestacionSucursal();
            }
            MDIPrincip temp = new MDIPrincip();
            temp.timesup.Start();
            temp.timerreasig.Start();
           

        }
        private void CargarContestacionSucursal()
        {
            var objSupervision = new ContestacionesData();
            var busqueda = objSupervision.ObtenerDatosContestacionSupervision(valor1);
            if (busqueda.Result != null)
            {
                txthidIdSup.Text = busqueda.Result.Idsupervision.ToString();
                txthidIdConst.Text = busqueda.Result.Idcontestacion.ToString();
                txtNoSupervision.Text = busqueda.Result.NoSupervision.ToString();
                //txtDirRegional.Text = (busqueda.Result.Director_Regional != null ? busqueda.Result.Director_Regional.ToString() : "");
                txtDirectorEstatal.Text = (busqueda.Result.Director_Estatal != null ? busqueda.Result.Director_Estatal.ToString() : "");
                txtSucursal.Text = busqueda.Result.NoSucursal.ToString() + "- " + busqueda.Result.DescripcionSucursal.ToString();
                txtInmuble.Text = busqueda.Result.Inmueble.ToString();
                txtGestionDireccion.Text = busqueda.Result.Gestion_direccion.ToString();
                txtOriginacion.Text = busqueda.Result.Originacion.ToString();
                txtTarjetasTransfer.Text = busqueda.Result.Tarjetas_transfer.ToString();
                txtCredito.Text = busqueda.Result.Credito.ToString();
                txtUtys.Text = busqueda.Result.Utys.ToString();
                txtPromocionales.Text = busqueda.Result.Promocionales.ToString();
                txtCobranza.Text = busqueda.Result.Cobranza.ToString();
                txtFondoFijo.Text = busqueda.Result.Fondofijo.ToString();
                txtAcuerdosCompromisos.Text = busqueda.Result.AcuerdosCompromisos.ToString();
                txtNoOficio.Text = busqueda.Result.NoOficio.ToString();
                txtNoOficio.Enabled = false;
                txthidStatus.Text = busqueda.Result.Idstatus.ToString();
                dtFechaRespOficio.Value = busqueda.Result.FechaRespuesta.Value;

                toolButGuardar.Enabled = true;
                toolButImprimir.Enabled = true;

            }

        }
        private void LlenarDatos()
        {
            int[] varstatus = { 1 };
            var objSupervision = new SupervisionesData();
            var busqueda = objSupervision.ObtenerDatosSupervision(valor1, valor2, varstatus);
            if (busqueda.Result != null)
            {
                txthidIdSup.Text = busqueda.Result.IdSupervisiones.ToString();
                txthidIdConst.Text = "0";
                txtNoSupervision.Text = busqueda.Result.NoSupervision.ToString();
                txtDirectorEstatal.Text = (busqueda.Result.Director_Estatal != null ? busqueda.Result.Director_Estatal.ToString() : "");
                txtSucursal.Text = busqueda.Result.NoSucursal.ToString() + "- " + busqueda.Result.DescripcionSucursal.ToString();
                txthidIdSup.Text = busqueda.Result.IdSupervisiones.ToString();
                txthidStatus.Text = busqueda.Result.Idstatus.ToString();
                txtNoOficio.Enabled = true;
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

            if (string.IsNullOrEmpty(txtInmuble.Text.Trim()) || txtInmuble.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa la informacion del Inmueble", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtInmuble.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtGestionDireccion.Text.Trim()) || txtGestionDireccion.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa la informacion de gestión de la dirección", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtGestionDireccion.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtOriginacion.Text.Trim()) || txtOriginacion.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa la informacion de Originación", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtOriginacion.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtTarjetasTransfer.Text.Trim()) || txtTarjetasTransfer.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa la informacion de Tarjetas transfer", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTarjetasTransfer.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtCredito.Text.Trim()) || txtCredito.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa la informacion de Crédito", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCredito.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtUtys.Text.Trim()) || txtUtys.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa la informacion de UTYS", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUtys.Focus();
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

            if (string.IsNullOrEmpty(txtFondoFijo.Text.Trim()) || txtFondoFijo.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa la informacion de fondo fijo", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtFondoFijo.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtAcuerdosCompromisos.Text.Trim()) || txtAcuerdosCompromisos.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa la informacion de fondo fijo", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAcuerdosCompromisos.Focus();
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

            if (validarlongitudDatos())
            {
                return;
            }
            if (txthidIdConst.Text == "0")
            {
                var objbuscaOficio = new ContestacionesData();
                var busqueda = objbuscaOficio.BuscarNoOficio(txtNoOficio.Text.Trim());
                if (busqueda.Result != null)
                {
                    MessageBox.Show("El No. de Oficio '" + txtNoOficio.Text.Trim() + "' ya se encuentra registrado,favor de corregir", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNoOficio.Focus();
                    return;
                }
            }

            // MessageBox.Show("pASO VALIDACION");
            if (MessageBox.Show("¿La información es correcta? por favor verifique antes de ser registrada", System.Windows.Forms.Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                // Mensaje en pantallas)
                var objSupervision = new ContestacionesSuperv_Sucursales();
                objSupervision.Idcontestacion = Convert.ToInt32(txthidIdConst.Text.Trim());
                objSupervision.Idsupervision = Convert.ToInt32(txthidIdSup.Text.Trim());
                objSupervision.NoOficio = txtNoOficio.Text.Trim();
                objSupervision.Inmueble = txtInmuble.Text.Trim();
                objSupervision.Gestion_direccion = txtGestionDireccion.Text.Trim();
                objSupervision.Originacion = txtOriginacion.Text.Trim();
                objSupervision.Tarjetas_transfer = txtTarjetasTransfer.Text.Trim();
                objSupervision.Credito = txtCredito.Text.Trim();
                objSupervision.Utys = txtUtys.Text.Trim();
                objSupervision.Promocionales = txtPromocionales.Text.Trim();
                objSupervision.Cobranza = txtCobranza.Text.Trim();
                objSupervision.Fondofijo = txtFondoFijo.Text.Trim();
                objSupervision.AcuerdosCompromisos = txtAcuerdosCompromisos.Text.Trim();
                objSupervision.Idusuariocreador = Globales.objpasardatosusuario.IdUsuario;
                objSupervision.FechaCreacionContest = DateTime.Now;
                objSupervision.FechaRespuesta = dtFechaRespOficio.Value;
                var gdSupervisiones = new ContestacionesData().GuardarConstestacionSucursal(objSupervision);
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
                    if (txthidIdConst.Text == "0")
                    {
                        MessageBox.Show("La Contestacion ha sido guardada correctamente", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("La Contestacion ha sido actualizada correctamente", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                 
                    //  LimpiarDatos();
                    if (txthidStatus.Text == "5" || txthidStatus.Text == "1")
                    {
                        var obactualizarsup = new HistorialSupervisiones();
                        obactualizarsup.IdSupervisiones = Convert.ToInt32(txthidIdSup.Text.Trim());
                        obactualizarsup.Idstatus = 2;
                        var actualizarsup = new SupervisionesData().ActualizarSupervision(obactualizarsup);
                        if (actualizarsup.Code != 0)
                        {

                            MessageBox.Show(actualizarsup.Message.ToString(), System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        MessageBox.Show("Favor de esperar a la revisión de un supervisor", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private bool validarlongitudDatos()
        {
            int longitud = Globales.longitudChars;

            if (txtInmuble.Text.Length >= longitud)
            {
                MessageBox.Show("El limite de caracteres es de " + longitud + " has ingresado " + txtInmuble.Text.Length + " en este campo", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtInmuble.Focus();
                return true;
            }
            if (txtGestionDireccion.Text.Length >= longitud)
            {
                MessageBox.Show("El limite de caracteres es de " + longitud + " has ingresado " + txtGestionDireccion.Text.Length + " en este campo", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtGestionDireccion.Focus();
                return true;
            }
            if (txtOriginacion.Text.Length >= longitud)
            {
                MessageBox.Show("El limite de caracteres es de " + longitud + " has ingresado " + txtOriginacion.Text.Length + " en este campo", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtOriginacion.Focus();
                return true;
            }
            if (txtOriginacion.Text.Length >= longitud)
            {
                MessageBox.Show("El limite de caracteres es de " + longitud + " has ingresado " + txtOriginacion.Text.Length + " en este campo", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtOriginacion.Focus();
                return true;
            }
            if (txtTarjetasTransfer.Text.Length >= longitud)
            {
                MessageBox.Show("El limite de caracteres es de " + longitud + " has ingresado " + txtTarjetasTransfer.Text.Length + " en este campo", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTarjetasTransfer.Focus();
                return true;
            }
            if (txtCredito.Text.Length >= longitud)
            {
                MessageBox.Show("El limite de caracteres es de " + longitud + " has ingresado " + txtCredito.Text.Length + " en este campo", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCredito.Focus();
                return true;
            }
            if (txtUtys.Text.Length >= longitud)
            {
                MessageBox.Show("El limite de caracteres es de " + longitud + " has ingresado " + txtUtys.Text.Length + " en este campo", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUtys.Focus();
                return true;
            }
            if (txtPromocionales.Text.Length >= longitud)
            {
                MessageBox.Show("El limite de caracteres es de " + longitud + " has ingresado " + txtPromocionales.Text.Length + " en este campo", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPromocionales.Focus();
                return true;
            }
            if (txtCobranza.Text.Length >= longitud)
            {
                MessageBox.Show("El limite de caracteres es de " + longitud + " has ingresado " + txtCobranza.Text.Length + " en este campo", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCobranza.Focus();
                return true;
            }
            if (txtFondoFijo.Text.Length >= longitud)
            {
                MessageBox.Show("El limite de caracteres es de " + longitud + " has ingresado " + txtFondoFijo.Text.Length + " en este campo", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtFondoFijo.Focus();
                return true;
            }
            if (txtAcuerdosCompromisos.Text.Length >= longitud)
            {
                MessageBox.Show("El limite de caracteres es de " + longitud + " has ingresado " + txtAcuerdosCompromisos.Text.Length + " en este campo", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAcuerdosCompromisos.Focus();
                return true;
            }

            return false;
        }
        private void toolButImprimir_Click(object sender, EventArgs e)
        {
            forms.FormVisorConsultarSupervCR frmvisor = new forms.FormVisorConsultarSupervCR(2);//crea una instancia del formulario

            frmvisor.param1 = txtNoSupervision.Text.Trim();
            //frmvisor.MdiParen8t = MDIPrincip();
            frmvisor.ShowDialog();
        }
    }
}
