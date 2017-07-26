﻿using System;
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

namespace GDSfonacot
{
    
    public partial class ContestSuc : Form
    {

        private int saveorupdate =0;
        public int valor1 = 0;
        public String valor2 = "";
        public ContestSuc(int actualizarconst)
        {
            InitializeComponent();
            saveorupdate = actualizarconst;
           
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void ContestSuc_Load(object sender, EventArgs e)
        {
            if (saveorupdate == 0)
            {
                LlenarDatos();
            }
            else
            {
                CargarContestacionSucursal();
            }

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
                txtDirRegional.Text = (busqueda.Result.Director_Regional != null ? busqueda.Result.Director_Regional.ToString() : "");
                txtDirEstatal.Text = (busqueda.Result.Director_Estatal != null ? busqueda.Result.Director_Estatal.ToString() : "");
                txtSucursal.Text = busqueda.Result.NoSucursal.ToString() + "- " + busqueda.Result.DescripcionSucursal.ToString();
                txtInmueble.Text = busqueda.Result.Inmueble.ToString();
                txtGesDireccion.Text = busqueda.Result.Gestion_direccion.ToString();
                txtOriginacion.Text = busqueda.Result.Originacion.ToString();
                txtTransfer.Text = busqueda.Result.Tarjetas_transfer.ToString();
                txtCredito.Text = busqueda.Result.Credito.ToString();
                txtUTYS.Text = busqueda.Result.Utys.ToString();
                txtPromocionales.Text = busqueda.Result.Promocionales.ToString();
                txtCobranza.Text = busqueda.Result.Cobranza.ToString();
                txtFonFijo.Text = busqueda.Result.Fondofijo.ToString();
                textAcuerdosCompr.Text = busqueda.Result.AcuerdosCompromisos.ToString();
                txtNoOficio.Text = busqueda.Result.NoOficio.ToString();
                txthidStatus.Text = busqueda.Result.Idstatus.ToString();
                dtFechaRespOficio.Value = busqueda.Result.FechaRespuesta.Value;
                toolButGuardar.Enabled = true;
                toolButImprimir.Enabled = true;

            }

        }
        private void LlenarDatos()
        {
            int[] varstatus = { 1};
            var objSupervision = new SupervisionesData();
            var busqueda = objSupervision.ObtenerDatosSupervision(valor1, valor2,varstatus);
            if (busqueda.Result != null)
            {
                txthidIdSup.Text = busqueda.Result.IdSupervisiones.ToString();
                txthidIdConst.Text = "0";
                txtNoSupervision.Text = busqueda.Result.NoSupervision.ToString();
                txtDirRegional.Text = (busqueda.Result.Director_Regional !=null ? busqueda.Result.Director_Regional.ToString(): "");
                txtDirEstatal.Text= (busqueda.Result.Director_Estatal !=null ? busqueda.Result.Director_Estatal.ToString() : "");
                txtSucursal.Text= busqueda.Result.NoSucursal.ToString() + "- " +busqueda.Result.DescripcionSucursal.ToString();
                txthidIdSup.Text = busqueda.Result.IdSupervisiones.ToString();
                txthidStatus.Text = busqueda.Result.Idstatus.ToString();
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

            if (validarlongitudDatos())
            {
                return;
            }
            if (txthidIdConst.Text=="0") {
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
                    MessageBox.Show("La Contestacion ha sido guardada correctamente", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //  LimpiarDatos();
                    if (txthidStatus.Text=="5" || txthidStatus.Text=="1") { 
                        var obactualizarsup = new HistorialSupervisiones();
                        obactualizarsup.IdSupervisiones =Convert.ToInt32(txthidIdSup.Text.Trim());
                        obactualizarsup.Idstatus = 2;
                        var actualizarsup = new SupervisionesData().ActualizarSupervision(obactualizarsup);
                            if (actualizarsup.Code!=0)
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

            if (txtInmueble.Text.Length >= longitud)
            {
                MessageBox.Show("El limite de caracteres es de " + longitud + " has ingresado " + txtInmueble.Text.Length + " en este campo", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtInmueble.Focus();
                return true;
            }
            if (txtGesDireccion.Text.Length >= longitud)
            {
                MessageBox.Show("El limite de caracteres es de " + longitud + " has ingresado " + txtGesDireccion.Text.Length + " en este campo", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtGesDireccion.Focus();
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
            if (txtTransfer.Text.Length >= longitud)
            {
                MessageBox.Show("El limite de caracteres es de " + longitud + " has ingresado " + txtTransfer.Text.Length + " en este campo", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTransfer.Focus();
                return true;
            }
            if (txtCredito.Text.Length >= longitud)
            {
                MessageBox.Show("El limite de caracteres es de " + longitud + " has ingresado " + txtCredito.Text.Length + " en este campo", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCredito.Focus();
                return true;
            }
            if (txtUTYS.Text.Length >= longitud)
            {
                MessageBox.Show("El limite de caracteres es de " + longitud + " has ingresado " + txtUTYS.Text.Length + " en este campo", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUTYS.Focus();
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
            if (txtFonFijo.Text.Length >= longitud)
            {
                MessageBox.Show("El limite de caracteres es de " + longitud + " has ingresado " + txtFonFijo.Text.Length + " en este campo", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtFonFijo.Focus();
                return true;
            }
            if (textAcuerdosCompr.Text.Length >= longitud)
            {
                MessageBox.Show("El limite de caracteres es de " + longitud + " has ingresado " + textAcuerdosCompr.Text.Length + " en este campo", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textAcuerdosCompr.Focus();
                return true;
            }

            return false;
        }

        private void txthidIdSup_TextChanged(object sender, EventArgs e)
        {

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
