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
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using GMap.NET.ObjectModel;
using System.Text.RegularExpressions;
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
        private void LoadingCatRepreSucursales()
        {
            var sucursales = new SucursalesData().ObtenerSucursalesCombo();
            if (sucursales.Code != 0)
            {
                //Mandar mensaje de error con sucursales.Message
            }

            cborepresentacion.DataSource = sucursales.Result;
            cborepresentacion.DisplayMember = "NameSucursal";
            cborepresentacion.ValueMember = "IdSucursal";
            cborepresentacion.SelectedIndex = -1;
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
            if (Globales.objpasardatosusuario.IdNivel == 2 || Globales.objpasardatosusuario.IdNivel ==3)
            {
                txtNoSucursal.Enabled = false;
                txtSucursal.Enabled = false;
            }
            else
            {
                txtNoSucursal.Enabled = true;
                txtSucursal.Enabled = true;
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
            txtLatitud.Text = (objSucursal.Latitud != null ? objSucursal.Latitud.ToString() : "");
            txtAltitud.Text= (objSucursal.Altitud != null ? objSucursal.Altitud.ToString() : "");
            if (txtLatitud.Text!=String.Empty && txtAltitud.Text != String.Empty)
            {
                CargarMapa(txtLatitud.Text, txtAltitud.Text);
            }
            else
            {
                LimpiarMapa();
            }
            if (objSucursal.IdsucursalPadre==0)
            {
                checkrepresentacion.Checked = false;
                cborepresentacion.Visible = false;
            }
            else
            {
                checkrepresentacion.Checked = true;
                cborepresentacion.Visible = true;
                cborepresentacion.SelectedValue = objSucursal.IdsucursalPadre;
            }
            btnGuardar.Enabled = true;
            btnNuevo.Enabled = false;
            //tx.Text = objSucursal.Ventanillas.ToString();







        }

        public void LimpiarMapa()
        {
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 50;
            gMapControl1.AutoScroll = true;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gMapControl1.SetPositionByKeywords("Ciudad de Mexico");
      
            gMapControl1.Zoom = 14;
            numzoom.Value=Convert.ToDecimal(gMapControl1.Zoom);
        }
        public void CargarMapa(string latitud, string altitud)
        {

            LimpiarMapa();
            GMapMarker marker = null;
            GMapOverlay markers = new GMapOverlay("markers");
            markers.Clear();
            marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(latitud), Convert.ToDouble(altitud)), GMarkerGoogleType.blue_pushpin);
            numzoom.Value = 18;
            numzoom.Enabled = true;
            gMapControl1.Zoom = Convert.ToDouble(numzoom.Value);
            markers.Markers.Add(marker);
            gMapControl1.Overlays.Clear();
            gMapControl1.Overlays.Add(markers);
            marker.Position = new PointLatLng(Convert.ToDouble(latitud), Convert.ToDouble(altitud));
            gMapControl1.Position = marker.Position;
            marker.ToolTip = new GMapRoundedToolTip(marker);
            marker.ToolTipMode = MarkerTooltipMode.Always;
            Font font = new Font("Arial", 8, FontStyle.Regular);
            marker.ToolTipText = "Sucursal: \n" + txtSucursal.Text + "\nDomicilio:\n" + txtDireccion.Text.Trim() + "";
            marker.ToolTip.Font = font;
            marker.ToolTip.Format.Alignment = StringAlignment.Near;

          


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
            if (Globales.objpasardatosusuario.IdNivel != 1)
            {
                MessageBox.Show("Solo el administrador tiene acceso a esta accion", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
                return;    
            }
            var mensaje = string.Empty;
            if (ValidateSucursal(out mensaje))
            {
                MessageBox.Show(mensaje, System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //var mensaje2 = string.Empty;
            //if (ValidarDatosIntroducidos(out mensaje2))
            //{
            //    MessageBox.Show(mensaje2, System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            if (txthidIdSucursal.Text == "0")
            {
                var objbuscaSucursal = new SucursalesData();
                var busqueda = objbuscaSucursal.BuscarNoSucursal(Convert.ToInt32(txtNoSucursal.Text.Trim()));
                if (busqueda.Result != null)
                {
                    MessageBox.Show("El número de sucursal '" + txtNoSucursal.Text.Trim() + "' ya se encuentra registrado,favor de corregir", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNoSucursal.Focus();
                    return;
                }
            }

            if (MessageBox.Show("¿La información es correcta? por favor verifique antes de ser registrada", System.Windows.Forms.Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                var sucursales = new Sucursales();
                sucursales.IdSucursal = Convert.ToInt32(txthidIdSucursal.Text.ToString());
                sucursales.NoSucursal = Convert.ToInt16(txtNoSucursal.Text.Trim());
                sucursales.DescripcionSucursal = txtSucursal.Text.Trim();
                sucursales.Dirección = txtDireccion.Text.Trim();
                sucursales.Representaciones = txtRepresentaciones.Text.Trim();
                sucursales.Director_Regional = txtDirectorRegional.Text.Trim();
                sucursales.Director_Estatal = txtDirectorEstatal.Text.Trim();
                sucursales.Coordinador_Administrativo = txtCoordinadorAdministrativo.Text.Trim();
                sucursales.Coordinador_Crédito = txtCoordinadorCredito.Text.Trim();
                sucursales.Coordinador_Cobranza = txtCoordinadorCobranza.Text.Trim();
                sucursales.Analistas = Convert.ToInt16(txtTotalAnalistas.Text);
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
                sucursales.Cobranza_Meta_Anual = txtcobranzaAnual.Text.Trim();
                sucursales.Cobranza_Meta_Mensual = txtCobranzaMetaMensual.Text.Trim();
                sucursales.Cobranza_Porcentaje_Meta = txtCobranzaPorcentaje.Text.Trim();
                sucursales.Cobranza_Cumplimiento_Meta = txtCobranzaCumplimiento.Text.Trim();
                sucursales.IdRegional = Convert.ToInt32(cmbZonaRegional.SelectedValue);
                sucursales.Latitud = txtLatitud.Text.ToString().Trim();
                sucursales.Altitud = txtAltitud.Text.ToString().Trim();
                if (checkrepresentacion.Checked==true)
                {
                    sucursales.IdsucursalPadre = Convert.ToInt32(cborepresentacion.SelectedValue);
                }
                else
                {
                    sucursales.IdsucursalPadre = 0;
                }


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
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("La sucursal ha sido actualizada correctamente", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatos(Convert.ToInt32(txthidIdSucursal.Text.ToString()));
                        this.Close();
                    }
                }
            }
        }

        private void LimpiarDatos()
        {
            txthidIdSucursal.Text = "0";

            txtNoSucursal.Text = null;
            txtSucursal.Text = null;
            txtDireccion.Text = null;
            txtRepresentaciones.Text = null;
            txtDirectorRegional.Text = null;
            txtDirectorEstatal.Text = null;
            txtCoordinadorAdministrativo.Text = null;
            txtCoordinadorCredito.Text = null;
            txtCoordinadorCobranza.Text = null;
            txtTotalAnalistas.Text = null;
            txtTotalVentanillas.Text = null;
            txtAnalistasCredito.Text = null;
            txtAnalistasAdministrativos.Text = null;
            txtAnalistaComercial.Text = null;
            txtAnalistasCobranza.Text = null;
            pbxSucursal.Image = null;
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
            LimpiarMapa();
            txtAltitud.Text = null;
            txtLatitud.Text = null;
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
            //if (txtAltitud.Text == string.Empty && txtLatitud.Text==string.Empty) mensaje += "Favor de indicar la ubicación geografica de la sucursal\n";

            if (checkrepresentacion.Checked == true)
            {
                if (cborepresentacion.SelectedIndex == -1) mensaje += "Favor de seleccionar una sucursal Padre para asociarla a esta\n";


                if (Convert.ToInt32(txthidIdSucursal.Text) == Convert.ToInt32(cborepresentacion.SelectedValue))
                {
                    mensaje += "No se puede asignar una misma sucursal asi misma\n";
                }
            }

        


            return !(mensaje == string.Empty);
        }

        private bool ValidarDatosIntroducidos(out string mensaje)
        {
            mensaje = string.Empty;
            ////if (!System.Text.RegularExpressions.Regex.IsMatch(txtTotalAnalistas.Text, "^[0-9]*$")) mensaje += "El campo "+label1.Text+ " solo acepta datos númericos";
            //if (!System.Text.RegularExpressions.Regex.IsMatch(txtTotalAnalistas.Text, "^d+$|^d+,d+$")) mensaje += "El campo " + label1.Text + " solo acepta datos númericos";
            return !(mensaje == string.Empty);
        }
        private bool IsNumeric(string sValue)
        {
            return Regex.IsMatch(sValue, "^[0-9]+$.");
        }

        private void txtubicacion_TextChanged(object sender, EventArgs e)
        {
          


            //markerOverlay = new GMapOverlay("Marcador");
            //marker = new GMarkerGoogle(new PointLatLng(LatInicial, LngInicial), GMarkerGoogleType.green);
            //markerOverlay.Markers.Add(marker);
            //marker.ToolTipMode = MarkerTooltipMode.Always;
            //marker.ToolTipText = string.Format("Ubicacion: \n Latitud {0} \n Longitud:{1}", LatInicial, LngInicial);
            //Ahora agregamos el overlays en el maa

        }

        private void frmSucursales_Load(object sender, EventArgs e)
        {
            LoadingCatRegional();
            LoadingCatRepreSucursales();


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

             
        private void txtubicacion_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (e.KeyChar==13)
            {
                gMapControl1.DragButton = MouseButtons.Left;
                gMapControl1.CanDragMap = true;
                gMapControl1.MapProvider = GMapProviders.GoogleMap;
                gMapControl1.MinZoom = 0;
                gMapControl1.MaxZoom = 50;
                gMapControl1.AutoScroll = true;
                GMaps.Instance.Mode = AccessMode.ServerOnly;
                gMapControl1.SetPositionByKeywords(txtubicacion.Text.Trim());
                gMapControl1.Zoom = 18;
                numzoom.Value = Convert.ToDecimal(gMapControl1.Zoom);
                //markerOverlay = new GMapOverlay("Marcador");
                //marker = new GMarkerGoogle(new PointLatLng(LatInicial, LngInicial), GMarkerGoogleType.none);
                //markerOverlay.Markers.Add(marker);
                ////Ahora agregamos el overlays en el maa
                //gMapControl1.Overlays.Add(markerOverlay);
                gMapControl1.ShowCenter = true;
                numzoom.Enabled = true;
            }
            else
            {
                numzoom.Enabled =false;
            }
        }

        private void numzoom_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToDouble(numzoom.Value) <= gMapControl1.MaxZoom)
            {
                gMapControl1.Zoom = Convert.ToDouble(numzoom.Value);
            }
        }
        private void gMapControl1_DoubleClick(object sender, EventArgs e)
        {
            GMapMarker marker = null;
            txtAltitud.Text = "";
            txtLatitud.Text = "";
            GMapControl gm = (GMapControl)sender;
            MouseEventArgs hj = (MouseEventArgs)e;
            PointLatLng plg = gm.FromLocalToLatLng(hj.X, hj.Y);
            PointLatLng ultimopunto = plg;
            txtLatitud.Text = ultimopunto.Lat.ToString().Trim();
            txtAltitud.Text = ultimopunto.Lng.ToString().Trim();
            GMapOverlay markers = new GMapOverlay("markers");
            markers.Clear();

            marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(txtLatitud.Text), Convert.ToDouble(txtAltitud.Text)), GMarkerGoogleType.blue_pushpin);
            gMapControl1.Zoom = Convert.ToDouble(numzoom.Value);
            markers.Markers.Add(marker);
            gMapControl1.Overlays.Clear();
            gMapControl1.Overlays.Add(markers);
            marker.Position = new PointLatLng(Convert.ToDouble(txtLatitud.Text), Convert.ToDouble(txtAltitud.Text));
            gMapControl1.Position = marker.Position;
            marker.ToolTipMode = MarkerTooltipMode.Always;
            Font font = new Font("Arial", 8, FontStyle.Regular);
            marker.ToolTipText = "Sucursal: \n" + txtSucursal.Text + "\nDomicilio:\n" + txtDireccion.Text.Trim() + "";
            marker.ToolTip.Font = font;
            marker.ToolTip.Format.Alignment = StringAlignment.Near;



        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkrepresentacion_CheckedChanged(object sender, EventArgs e)
        {
            if (checkrepresentacion.Checked == true)
            {
                cborepresentacion.Visible = true;
            }
            else
            {
                cborepresentacion.Visible = false;
            }
        }

        private void cmbZonaRegional_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbZonaRegional.SelectedIndex != 0 || cmbZonaRegional.SelectedIndex != -1)
            {

                txtDirectorRegional.Text = DevuelveDirectorRegional(Convert.ToInt32(cmbZonaRegional.SelectedValue));

            }
            else {
                txtDirectorRegional.Text = null;

            }

        }

        private String DevuelveDirectorRegional(int idregion)
        {
            var regionDB = new SucursalesData().ObtenerRegionTitular(idregion);
            if (regionDB.Code != 0 || regionDB.Result.Count < 1)
            {
                MessageBox.Show("Error: " + regionDB.Message);
                return "";
            }
            else
            {
                var reg = regionDB.Result.First();
                return reg.Director_Regional;
            }
        }
    }
}
