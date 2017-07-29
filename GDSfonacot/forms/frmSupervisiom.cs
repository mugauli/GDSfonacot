using System;
using GDSfonacotDatos;
using GDSfonacotDatos.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDSfonacotDatos.DTO;

namespace GDSfonacot.forms
{
    public partial class frmSupervisiom : Form
    {
        private int saveorupdate = 0;
        public int valor1 = 0;
        public String valor2 = "";
        public frmSupervisiom(int actualizarconst)
        {
            InitializeComponent();
            saveorupdate = actualizarconst;
        }

        private void frmSupervisiom_Load(object sender, EventArgs e)
        {
            LoadingCatSucursales();//load sucursales list of table
            LoadingCatSupervisor2();
            LoadingCatSupervisor1();
            if (saveorupdate == 1)
            {
               
            }
            if (saveorupdate == 0)
            {
                LimpiarDatos();
            }
            else
            {
                ConsultarDatos(valor2);
            }

        }

        private void toolButNuevo_Click(object sender, EventArgs e)
        {
            toolButNuevo.Enabled = false;

            toolButGuardar.Enabled = true;
            toolButImprimir.Enabled = false;
            LimpiarDatos();
            txthidIdSup.Text = "0";

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
            if (txthidIdSup.Text == "0")
            {
                var objbuscaSupervision = new SupervisionesData();
                var busqueda = objbuscaSupervision.BuscarSupervision(txtNoSupervision.Text.Trim());
                if (busqueda.Result != null)
                {
                    MessageBox.Show("La supervision '" + txtNoSupervision.Text.Trim() + "' ya se encuentra registrada,favor de corregir", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNoSupervision.Focus();
                    return;
                }
            }

                // MessageBox.Show("pASO VALIDACION");
                if (MessageBox.Show("¿La información es correcta? por favor verifique antes de ser registrada", System.Windows.Forms.Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                ;// Mensaje en pantallas)
                var objSupervision = new HistorialSupervisiones();
                objSupervision.IdSupervisiones = Convert.ToInt32(txthidIdSup.Text.Trim());
                objSupervision.IdSucursal = Convert.ToInt32(cmbSucursales.SelectedValue);
                objSupervision.NoSupervision = txtNoSupervision.Text.Trim();
                objSupervision.FechaSupervision = dtFechaSupervision.Value;
                objSupervision.Inmueble =txtInmuble.Text.Trim();
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
                objSupervision.Idstatus = 1;
                objSupervision.Idsupervisor1 = Convert.ToInt32(cmbSupervisor1.SelectedValue);
                if (cmbSupervisor2.SelectedValue != null) { 
                objSupervision.Idsupervisor2 = Convert.ToInt32(cmbSupervisor2.SelectedValue);
                }
                
                objSupervision.Fechacreacion = DateTime.Now;
                var gdSupervisiones = new SupervisionesData().GuardarSupervision(objSupervision);
                if (gdSupervisiones.Code != 0)
                {
                    //Mensage de error con g
                    toolButNuevo.Enabled = false;
                    toolButGuardar.Enabled = true;
                    MessageBox.Show(gdSupervisiones.Message.ToString(), System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    toolButImprimir.Enabled = false;

                }
                else
                {
                    toolButNuevo.Enabled = false;
                    toolButGuardar.Enabled = false;
                    toolButImprimir.Enabled = true;
                    MessageBox.Show("La supervision ha sido guardada correctamente", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //LimpiarDatos();
                }

            }
            else
            {
                MessageBox.Show("La supervision no fue guardada, por favor intente nuevamente", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                toolButNuevo.Enabled = false;
                toolButGuardar.Enabled = true;
                toolButImprimir.Enabled = false;
            }


        }
        private bool validarDatos()
        {
            
            if (cmbSucursales.SelectedIndex <= -1)
            {
                MessageBox.Show("Selecciona una Sucursal", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbSucursales.Focus();
                return true;
            }
            if (Convert.ToInt32(cmbSupervisor1.SelectedValue)== Convert.ToInt32(cmbSupervisor2.SelectedValue))
            {
                MessageBox.Show("No puedes seleccionar el mismo supervisor para los campos 'supervisor1' y 'supervisor2',favor de corregir", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }

            if (string.IsNullOrEmpty(txtNoSupervision.Text.Trim()) || txtNoSupervision.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa un numero de supervision", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNoSupervision.Focus();
                return true;

            }

            if (string.IsNullOrEmpty(cmbSupervisor1.Text.Trim()) || cmbSupervisor1.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa el nombre del supervisor 1", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbSupervisor1.Focus();
                return true;
            }

            //if (string.IsNullOrEmpty(cmbSupervisor2.Text.Trim()) || cmbSupervisor2.Text.Trim() == "")
            //{
            //    MessageBox.Show("Ingresa el nombre del supervisor 2", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    cmbSupervisor2.Focus();
            //    return true;
            //}

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
                MessageBox.Show("El limite de caracteres es de " + longitud + " has ingresado " + txtFondoFijo.Text.Length + " en este campo" , System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void LoadingCatSucursales()
        {
            var sucursales = new SucursalesData().ObtenerSucursalesCombo();
            if (sucursales.Code != 0)
            {
                //Mandar mensaje de error con sucursales.Message
            }

            cmbSucursales.DataSource = sucursales.Result;
            cmbSucursales.DisplayMember = "NameSucursal";
            cmbSucursales.ValueMember = "IdSucursal";
            cmbSucursales.SelectedIndex = -1;
        }

        private void LoadingCatSupervisor1()
        {
            var sucursales = new SupervisionesData().ObtenerSupervisores();
            if (sucursales.Code != 0)
            {
                //Mandar mensaje de error con sucursales.Message
            }

            cmbSupervisor1.DataSource = sucursales.Result;
            cmbSupervisor1.DisplayMember = "Nombre_Usuario";
            cmbSupervisor1.ValueMember = "IdUsuario";
            cmbSupervisor1.SelectedIndex = -1;
        }
        private void LoadingCatSupervisor2()
        {
            var sucursales = new SupervisionesData().ObtenerSupervisores();
            if (sucursales.Code != 0)
            {
                //Mandar mensaje de error con sucursales.Message
            }

            cmbSupervisor2.DataSource = sucursales.Result;
            cmbSupervisor2.DisplayMember = "Nombre_Usuario";
            cmbSupervisor2.ValueMember = "IdUsuario";
            cmbSupervisor2.SelectedIndex = -1;
        }
        private void LimpiarDatos()
        {
            txthidIdSup.Text = "0";
            cmbSucursales.SelectedIndex = -1;
            txtNoSupervision.Text = String.Empty;
            dtFechaSupervision.Value = DateTime.Now;
            txtInmuble.Text = String.Empty;
            txtGestionDireccion.Text = String.Empty;
            txtOriginacion.Text = String.Empty;
            txtTarjetasTransfer.Text = String.Empty;
            txtCredito.Text = String.Empty;
            txtUtys.Text = String.Empty;
            txtPromocionales.Text = String.Empty;
            txtCobranza.Text = String.Empty;
            txtFondoFijo.Text = String.Empty;
            txtAcuerdosCompromisos.Text = String.Empty;
            cmbSupervisor1.SelectedIndex = -1;
            cmbSupervisor2.SelectedIndex = -1;
            toolButNuevo.Enabled = false;
            toolButGuardar.Enabled = true;
            txtNoSupervision.Enabled = true;


        }

        private void ConsultarDatos(String Nosupervision)
        {
            //LimpiarDatos();
            var objSupervision = new SupervisionesData();
            var busqueda = objSupervision.BuscarSupervision(Nosupervision);
            if (busqueda.Result != null)
            {
                txthidIdSup.Text = busqueda.Result.IdSupervisiones.ToString();
                txthidStatus.Text = busqueda.Result.Idstatus.ToString();
                cmbSucursales.SelectedValue = busqueda.Result.IdSucursal;
                txtNoSupervision.Text = busqueda.Result.NoSupervision.ToString();
                dtFechaSupervision.Value = busqueda.Result.FechaSupervision.Value;
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
                cmbSupervisor1.SelectedValue = busqueda.Result.Idsupervisor1;
                if (busqueda.Result.Idsupervisor2!=null) { 
                cmbSupervisor2.SelectedValue = busqueda.Result.Idsupervisor2;
                }
                else
                {
                    cmbSupervisor2.SelectedIndex = -1;
                }
                toolButNuevo.Enabled = false;
                toolButGuardar.Enabled = true;
                txtNoSupervision.Enabled = false;
                toolButImprimir.Enabled = true;
            }
            else
            {
                MessageBox.Show(busqueda.Message.ToString());
                MessageBox.Show("No se encontro la supervision requerida");
                toolButNuevo.Enabled = true;
                toolButGuardar.Enabled = false;

                toolButImprimir.Enabled = false;
            }



        }

        private void toolButImprimir_Click(object sender, EventArgs e)
        {
            forms.FormVisorConsultarSupervCR frmvisor = new forms.FormVisorConsultarSupervCR(1);//crea una instancia del formulario

            frmvisor.param1 = txtNoSupervision.Text.Trim();
            //frmvisor.MdiParen8t = MDIPrincip();
            frmvisor.ShowDialog();

        }     
    }
}
