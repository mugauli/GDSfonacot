using GDSfonacot.Helpers;
using GDSfonacotDatos;
using GDSfonacotDatos.Data;
using GDSfonacotDatos.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace GDSfonacot.forms
{
    public partial class frmSucursales : Form
    {
        private int SucursalInt = 0;

        public frmSucursales(int Sucursal)
        {
            InitializeComponent();
            SucursalInt = Sucursal;
           
        }
        private void LoadingCatRegional()
        {
            var perfilessistema = new CatalogosData().ObtenerRegional();
            if (perfilessistema.Code != 0)
            {
                //Mandar mensaje de error con sucursales.Message
            }

            cmbZonaRegional.DataSource = perfilessistema.Result;
            cmbZonaRegional.DisplayMember = "Descripcion";
            cmbZonaRegional.ValueMember = "IdRegional";
            cmbZonaRegional.SelectedIndex = -1;
        }
        public void CargarDatos(int Sucursal)
        {

            var SucursalDB = new SucursalesData().ObtenerSucursales(Sucursal);
            if (SucursalDB.Code != 0)
            {
                MessageBox.Show("Error: " + SucursalDB.Message);
                //LimpiarDatos();
                return;
            }

            var objSucursal = SucursalDB.Result.First();
            var imagen = ByteToImage(objSucursal.Fotografia);
          
            if (imagen != null) pbxSucursal.Image = imagen;
            //  txtDireccionRegional.Text = objSucursal.DireccionRegional;
            txthidIdSucursal.Text = objSucursal.IdSucursal.ToString();
            txtNoSucursal.Text = objSucursal.NoSucursal.ToString();
            txtSucursal.Text = (objSucursal.DescripcionSucursal != null ? objSucursal.DescripcionSucursal.ToString() : "");
            txtRepresentaciones.Text = objSucursal.Representaciones;
            txtDireccion.Text = objSucursal.Dirección;
            txtDirectorRegional.Text = objSucursal.Director_Regional;
            txtDirectorEstatal.Text = objSucursal.Director_Estatal;
            txtCoordinadorAdministrativo.Text = objSucursal.Coordinador_Administrativo;
            txtCoordinadorCredito.Text = objSucursal.Coordinador_Crédito;
            txtCoordinadorCobranza.Text = objSucursal.Coordinador_Cobranza;
            txtTotalAnalistas.Text = (objSucursal.Analistas != null ? objSucursal.Analistas.ToString() : "");
            cmbZonaRegional.SelectedValue = objSucursal.IdRegional;
            txtTotalVentanillas.Text = (objSucursal.Ventanillas != null ? objSucursal.Ventanillas.ToString() : "");
            txtAnalistasCredito.Text = (objSucursal.Analistas_Otorgamiento_de_Crédito != null ? objSucursal.Analistas_Otorgamiento_de_Crédito.ToString() : "");
            txtAnalistasAdministrativos.Text = (objSucursal.Analistas_Administrativo_y_SAM != null ? objSucursal.Analistas_Administrativo_y_SAM.ToString() : "");
            txtAnalistaComercial.Text = (objSucursal.Analistas_Crédito_Control_Documental != null ? objSucursal.Analistas_Crédito_Control_Documental.ToString() : "");
            txtAnalistasCobranza.Text = (objSucursal.Analistas_Cobranza != null ? objSucursal.Analistas_Cobranza.ToString() : "");
            if (imagen != null) pbxSucursal.Image = imagen;
            txtEmpresasAfiliadas.Text = (objSucursal.Empresas_Afiliadas != null ? objSucursal.Empresas_Afiliadas.ToString() : "");
            txtTrabajadoresAfiliados.Text = (objSucursal.Trabajadores_Afiliados != null ? objSucursal.Trabajadores_Afiliados.ToString() : "");
            txtPotencialEmpresas.Text = (objSucursal.Potencial_de_Empresas != null ? objSucursal.Potencial_de_Empresas.ToString() : "");
            txtPotencialTrabajadores.Text = (objSucursal.Potencial_de_Trabajadores != null ? objSucursal.Potencial_de_Trabajadores.ToString() : "");
            txtEmpresasEstatus1.Text = (objSucursal.Empresas_Status_1 != null ? objSucursal.Empresas_Status_1.ToString() : "");
            txtEmpresasEstatus18.Text = (objSucursal.Empresas_Status_18 != null ? objSucursal.Empresas_Status_18.ToString() : "");
            txtEmpresasEstatus21.Text = (objSucursal.Empresas_Status_21 != null ? objSucursal.Empresas_Status_21.ToString() : "");
            txtEmpresasEstatus30.Text = (objSucursal.Empresas_Status_30 != null ? objSucursal.Empresas_Status_30.ToString() : "");
            txtMetaAnual.Text = (objSucursal.Meta_Anual != null ? objSucursal.Meta_Anual.ToString() : "");
            txtMetaMensual.Text = (objSucursal.Meta_Mensual != null ? objSucursal.Meta_Mensual.ToString() : "");
            txtColocacionAnual.Text = (objSucursal.Colocación_Anual != null ? objSucursal.Colocación_Anual.ToString() : "");
            txtColocacionMensual.Text = (objSucursal.Colocación_Mensual != null ? objSucursal.Colocación_Mensual.ToString() : "");
            txtMetaAcumulada.Text = (objSucursal.Meta_Acumulada_Porcentaje != null ? objSucursal.Meta_Acumulada_Porcentaje.ToString() : "");
            txtcobranzaAnual.Text = (objSucursal.Cobranza_Meta_Anual != null ? objSucursal.Cobranza_Meta_Anual.ToString() : "");
            txtCobranzaMetaMensual.Text = (objSucursal.Cobranza_Meta_Mensual != null ? objSucursal.Cobranza_Meta_Mensual.ToString() : "");
            txtCobranzaPorcentaje.Text = (objSucursal.Cobranza_Porcentaje_Meta != null ? objSucursal.Cobranza_Porcentaje_Meta.ToString() : "");
            txtCobranzaCumplimiento.Text = (objSucursal.Cobranza_Cumplimiento_Meta != null ? objSucursal.Cobranza_Cumplimiento_Meta.ToString() : "");
            cmbZonaRegional.SelectedValue = objSucursal.IdRegional;
            btnGuardar.Enabled = true;
            btnNuevo.Enabled = false;
            //tx.Text = objSucursal.Ventanillas.ToString();







        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            try
            {
                if (blob == null) return null;
                MemoryStream mStream = new MemoryStream();


                mStream.Write(blob, 0, Convert.ToInt32(blob.Length));

                Bitmap bm = new Bitmap(mStream, true);
                mStream.Dispose();
                return bm;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return null;
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void brsImagen_HelpRequest(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            // Se muestra al usuario esperando una acción
            DialogResult result = dialog.ShowDialog();

            // Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)
            // la mostramos en el PictureBox de la inferfaz
            if (result == DialogResult.OK)
            {
                pbxSucursal.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Archivo JPG|*.jpg|Archivo PNG (*.png)|*.png";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pbxSucursal.Image = Image.FromFile(fileDialog.FileName);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var mensaje = string.Empty;
            if (ValidateSucursal(out mensaje))
            {
                MessageBox.Show(mensaje, System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var sucursales = new Sucursales();
            sucursales.IdSucursal = Convert.ToInt32(txthidIdSucursal.Text.ToString());
            sucursales.NoSucursal = Convert.ToInt16(txtNoSucursal.Text.Trim());
            sucursales.DescripcionSucursal = txtSucursal.Text.Trim();
            sucursales.Dirección = txtDireccion.Text;
            sucursales.Representaciones = txtRepresentaciones.Text;
            sucursales.Director_Regional = txtDirectorRegional.Text;
            sucursales.Director_Estatal = txtDirectorEstatal.Text;
            sucursales.Coordinador_Administrativo = txtCoordinadorAdministrativo.Text;
            sucursales.Coordinador_Crédito = txtCoordinadorCredito.Text;
            sucursales.Coordinador_Cobranza = txtCoordinadorCobranza.Text;
            sucursales.Analistas =Convert.ToInt16(txtTotalAnalistas.Text);
            sucursales.Ventanillas = Convert.ToInt16(txtTotalVentanillas.Text);
            sucursales.Analistas_Otorgamiento_de_Crédito = Convert.ToInt16(txtAnalistasCredito.Text);
            sucursales.Analistas_Administrativo_y_SAM = Convert.ToInt16(txtAnalistasAdministrativos.Text);
            sucursales.Analistas_Crédito_Control_Documental = Convert.ToInt16(txtAnalistaComercial.Text);
            sucursales.Analistas_Cobranza = Convert.ToInt16(txtAnalistasCobranza.Text);
            sucursales.Fotografia = ImageHelper.ImageToByteArray(pbxSucursal.Image);
            sucursales.Empresas_Afiliadas = Convert.ToInt32(txtEmpresasAfiliadas.Text);
            sucursales.Trabajadores_Afiliados = Convert.ToInt32(txtTrabajadoresAfiliados.Text);
            sucursales.Potencial_de_Empresas = Convert.ToInt32(txtPotencialEmpresas.Text);
            sucursales.Potencial_de_Trabajadores = Convert.ToInt32(txtPotencialTrabajadores.Text);
            sucursales.Empresas_Status_1 = Convert.ToInt32(txtEmpresasEstatus1.Text);
            sucursales.Empresas_Status_18 = Convert.ToInt32(txtEmpresasEstatus18.Text);
            sucursales.Empresas_Status_21 = Convert.ToInt32(txtEmpresasEstatus21.Text);
            sucursales.Empresas_Status_30 = Convert.ToInt32(txtEmpresasEstatus30.Text);
            sucursales.Meta_Anual = Convert.ToDecimal(txtMetaAnual.Text);
            sucursales.Meta_Mensual = Convert.ToDecimal(txtMetaMensual.Text);
            sucursales.Colocación_Anual = Convert.ToDecimal(txtColocacionAnual.Text);
            sucursales.Colocación_Mensual = Convert.ToDecimal(txtColocacionMensual.Text);
            //sucursales.Fecha_baja = sucursal.Fecha_baja;
            sucursales.Meta_Acumulada_Porcentaje = Convert.ToDecimal(txtMetaAcumulada.Text);
            sucursales.Cobranza_Meta_Anual = txtcobranzaAnual.Text;
            sucursales.Cobranza_Meta_Mensual = txtCobranzaMetaMensual.Text;
            sucursales.Cobranza_Porcentaje_Meta = txtCobranzaPorcentaje.Text;
            sucursales.Cobranza_Cumplimiento_Meta = txtCobranzaCumplimiento.Text;
            sucursales.IdRegional = Convert.ToInt32(cmbZonaRegional.SelectedValue);
            //empleado.IdEmpleado = IdEmpleadoInt;
            //empleado.Nombre = txtNombre.Text.ToString().Trim();
            //empleado.Gafete = txtGafete.Text.ToString().Trim();
            //empleado.Jornada = txtJornada.Text.ToString().Trim();
            //empleado.Horario = txtHorario.Text.ToString().Trim();
            //empleado.IdRegional = cmbRegional.SelectedIndex;
            //empleado.IdSucursal = cmbSucursal.SelectedIndex;
            //empleado.IdTipoPersonal = cmbTipoPersonal.SelectedIndex;
            //empleado.IdArea = cmbActividad.SelectedIndex;
            //empleado.IdPerfilSistema = cmbPerfilSistema.SelectedIndex;
            //empleado.IdActividad = cmbActividad.SelectedIndex;

            var objSucursal = new SucursalesData().GuadarSucursal(sucursales);
            if (objSucursal.Code != 0)
            {
                MessageBox.Show("Error: " + objSucursal.Message);
                return;
                //Mandar mensaje de error con sucursales.Message
            }
            else
            {
                if (txthidIdSucursal.Text == "0")
                {
                    MessageBox.Show("La nueva sucursal ha sido guardada correctamente", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarDatos();
                }
                else
                {
                    MessageBox.Show("La sucursal sucursal ha sido actualizada correctamente", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos(Convert.ToInt32(txthidIdSucursal.Text.ToString()));
                }
            }
        }

        private void LimpiarDatos()
        {
            txthidIdSucursal.Text = "0";

            txtNoSucursal.Text = null;
            txtSucursal.Text = null;
            txtDireccion.Text=null;
            txtRepresentaciones.Text=null;
            txtDirectorRegional.Text=null;
            txtDirectorEstatal.Text= null;
            txtCoordinadorAdministrativo.Text = null;
            txtCoordinadorCredito.Text = null;
            txtCoordinadorCobranza.Text = null;
            txtTotalAnalistas.Text = null;
            txtTotalVentanillas.Text = null;
            txtAnalistasCredito.Text = null;
            txtAnalistasAdministrativos.Text = null;
            txtAnalistaComercial.Text = null;
            txtAnalistasCobranza.Text = null;
            pbxSucursal.Image =null;
            txtEmpresasAfiliadas.Text = null;
            txtTrabajadoresAfiliados.Text = null;
            txtPotencialEmpresas.Text = null;
            txtPotencialTrabajadores.Text = null;
            txtEmpresasEstatus1.Text = null;
            txtEmpresasEstatus18.Text = null;
            txtEmpresasEstatus21.Text = null;
            txtEmpresasEstatus30.Text = null;
            txtMetaAnual.Text = null;
            txtMetaMensual.Text = null;
            txtColocacionAnual.Text = null;
            txtColocacionMensual.Text = null;
            txtMetaAcumulada.Text = null;
            txtcobranzaAnual.Text = null;
            txtCobranzaMetaMensual.Text = null;
            txtCobranzaPorcentaje.Text = null;
            txtCobranzaCumplimiento.Text = null;
            cmbZonaRegional.SelectedIndex = -1;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
        }
        private bool ValidateSucursal(out string mensaje)
        {
            mensaje = string.Empty;

            if (cmbZonaRegional.SelectedIndex == -1) mensaje += "Favor de seleccionar direccion regional\n";
            if (txtNoSucursal.Text == string.Empty) mensaje += "Favor de introducir numero de sucursal\n";
            if(txtSucursal.Text == string.Empty) mensaje += "Favor de introducir el nombre de sucursak\n";
            if(txtDireccion.Text == string.Empty) mensaje += "Favor de introducir el domicilio\n";
            if(txtDirectorRegional.Text == string.Empty) mensaje += "Favor de introducir director regional\n";
            if(txtDirectorEstatal.Text == string.Empty) mensaje += "Favor de introducir director estatal\n";
            if(txtCoordinadorAdministrativo.Text == string.Empty) mensaje += "Favor de introducir coordinador administrativo\n";
            if(txtCoordinadorCredito.Text == string.Empty) mensaje += "Favor de introducir coordinador de credio\n";
            if(txtCoordinadorCobranza.Text == string.Empty) mensaje += "Favor de introducir coordinador de cobranza\n";
            if(txtTotalAnalistas.Text == string.Empty) mensaje += "Favor de introducir total de analistas\n";
            if(txtTotalVentanillas.Text == string.Empty) mensaje += "Favor de introducir total ventanillas\n";
            if(txtAnalistasCredito.Text == string.Empty) mensaje += "Favor de introducir analistas credito\n";
            if(txtAnalistasAdministrativos.Text == string.Empty) mensaje += "Favor de introducir analistas admnistrativos\n";
            if(txtAnalistaComercial.Text == string.Empty) mensaje += "Favor de introducir analistas comerciales\n";
            if(txtAnalistasCobranza.Text == string.Empty) mensaje += "Favor de introducir analistas cobranza\n";
            if(txtEmpresasAfiliadas.Text == string.Empty) mensaje += "Favor de introducir empresas afiliadas\n";
            if(txtTrabajadoresAfiliados.Text == string.Empty) mensaje += "Favor de introducir trabajadores afiliados\n";
            if(txtPotencialEmpresas.Text == string.Empty) mensaje += "Favor de introducir potencial de empresas\n";
            if(txtPotencialTrabajadores.Text == string.Empty) mensaje += "Favor de introducir potencial trabajadores\n";
            if(txtEmpresasEstatus1.Text == string.Empty) mensaje += "Favor de introducir empresas estatus 1\n";
            if(txtEmpresasEstatus18.Text == string.Empty) mensaje += "Favor de introducir empresas estatus 18\n";
            if(txtEmpresasEstatus21.Text == string.Empty) mensaje += "Favor de introducir empresas estatus 21\n";
            if(txtEmpresasEstatus30.Text == string.Empty) mensaje += "Favor de introducir empresas estatus 30\n";
            if(txtMetaMensual.Text == string.Empty) mensaje += "Favor de introducir meta mensual\n";
            if(txtColocacionAnual.Text == string.Empty) mensaje += "Favor de introducir colocacion anual\n";
            if(txtColocacionMensual.Text == string.Empty) mensaje += "Favor de introducir colocacion mensual\n";
            if(txtMetaAcumulada.Text == string.Empty) mensaje += "Favor de introducir meta acumulada\n";
            if(txtcobranzaAnual.Text == string.Empty) mensaje += "Favor de introducir cobranza anual\n";
            if(txtCobranzaMetaMensual.Text == string.Empty) mensaje += "Favor de introducir cobranza meta mensual\n";
            if(txtCobranzaPorcentaje.Text == string.Empty) mensaje += "Favor de introducir cobranza porcentaje\n";
            if(txtCobranzaCumplimiento.Text == string.Empty) mensaje += "Favor de introducir cobranza cumplimiento\n";


            return !(mensaje == string.Empty);
        }

        private void frmSucursales_Load(object sender, EventArgs e)
        {
            LoadingCatRegional();
            if (SucursalInt!=0)
            {
                CargarDatos(SucursalInt);
            }
            else {
                LimpiarDatos();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSucursal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNoSucursal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmbZonaRegional_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtRepresentaciones_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtDirectorEstatal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCoordinadorAdministrativo_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbxSucursal_Click(object sender, EventArgs e)
        {

        }

        private void txtDirectorRegional_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtCoordinadorCredito_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTotalAnalistas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCoordinadorCobranza_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtAnalistaComercial_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtAnalistasCredito_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtAnalistasCobranza_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTrabajadoresAfiliados_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtPotencialEmpresas_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void txtPotencialTrabajadores_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void txtEmpresasEstatus30_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void txtEmpresasEstatus21_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmpresasEstatus18_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void txtMetaAnual_TextChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void txtMetaAcumulada_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtColocacionMensual_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtColocacionAnual_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void txtMetaMensual_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void txtEmpresasEstatus1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtEmpresasAfiliadas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalVentanillas_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }
    }
}
