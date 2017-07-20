using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDSfonacotDatos;

namespace GDSfonacot.forms
{
    public partial class frmHistoricoSupervisiones : Form
    {
        private int saveorupdate = 0;
        public int valor1 = 0;
        public String valor2 = "";
        public frmHistoricoSupervisiones(int actualizarconst)
        {
            InitializeComponent();
            saveorupdate = actualizarconst;
        }

        private void CargarDatosHistoricoSupervision()
        {
            var objSupervision = new SupervisionesData();
            var busqueda = objSupervision.ObtenerDatosHistoricoSupervision(valor1);
            var imagen = ByteToImage(busqueda.Result.Fotografia);
            if (busqueda.Result != null)
            {

                if (imagen != null) pbxSucursal.Image = imagen;
                txthidIdSup.Text = busqueda.Result.Idsupervision.ToString();
                txtNoSupervision.Text = busqueda.Result.NoSupervision.ToString();
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
                txthidStatus.Text = busqueda.Result.Idstatus.ToString();
                txtSupervisor1.Text = busqueda.Result.Supervisor1.ToString();
                txtSupervisor2.Text = busqueda.Result.Supervisor2.ToString();
                //DescripcionSucursal = x.HistSup2.Suc.DescripcionSucursal,
                //            NoSucursal = x.HistSup2.Suc.NoSucursal,
                //            Director_Estatal = x.HistSup2.Suc.Director_Estatal,
                //            Director_Regional = x.HistSup2.Suc.Director_Regional,
                //            Analistas = x.HistSup2.Suc.Analistas,
                //            Ventanillas = x.HistSup2.Suc.Ventanillas,
                //            Analistas_Otorgamiento_de_Crédito = x.HistSup2.Suc.Analistas_Otorgamiento_de_Crédito,
                //            Analistas_Administrativo_y_SAM = x.HistSup2.Suc.Analistas_Administrativo_y_SAM,
                //            Analistas_Crédito_Control_Documental = x.HistSup2.Suc.Analistas_Crédito_Control_Documental,
                //            Analistas_Cobranza = x.HistSup2.Suc.Analistas_Cobranza,
                //            Empresas_Afiliadas = x.HistSup2.Suc.Empresas_Afiliadas,
                //            Trabajadores_Afiliados = x.HistSup2.Suc.Trabajadores_Afiliados,
                //            Potencial_de_Empresas = x.HistSup2.Suc.Potencial_de_Empresas,
                //            Potencial_de_Trabajadores = x.HistSup2.Suc.Potencial_de_Trabajadores,
                //            Empresas_Status_1 = x.HistSup2.Suc.Empresas_Status_1,
                //            Empresas_Status_18 = x.HistSup2.Suc.Empresas_Status_18,
                //            Empresas_Status_21 = x.HistSup2.Suc.Empresas_Status_21,
                //            Empresas_Status_30 = x.HistSup2.Suc.Empresas_Status_30,
                //            Meta_Anual = x.HistSup2.Suc.Meta_Anual,
                //            Meta_Mensual = x.HistSup2.Suc.Meta_Mensual,
                //            Colocación_Anual = x.HistSup2.Suc.Colocación_Anual,
                //            Colocación_Mensual = x.HistSup2.Suc.Colocación_Mensual,
                //            Fecha_baja = x.HistSup2.Suc.Fecha_baja,
                //            Meta_Acumulada_Porcentaje = x.HistSup2.Suc.Meta_Acumulada_Porcentaje,
                //            Cobranza_Meta_Anual = x.HistSup2.Suc.Cobranza_Meta_Anual,
                //            Cobranza_Porcentaje_Meta = x.HistSup2.Suc.Cobranza_Porcentaje_Meta,
                //            Cobranza_Cumplimiento_Meta = x.HistSup2.Suc.Cobranza_Cumplimiento_Meta,
                //            IdRegional = x.HistSup2.Suc.IdRegional,
                //            Fotografia = x.HistSup2.Suc.Fotografia
                txtSucursal.Text = busqueda.Result.NoSucursal.ToString() + "- " + busqueda.Result.DescripcionSucursal.ToString();
                txtDirectorEstatal.Text = (busqueda.Result.Director_Estatal != null ? busqueda.Result.Director_Estatal.ToString() : "");
                txtDirectorRegional.Text = (busqueda.Result.Director_Regional != null ? busqueda.Result.Director_Regional.ToString() : "");
                txtCoordinadorAdministrativo.Text = (busqueda.Result.Coordinador_Administrativo != null ? busqueda.Result.Coordinador_Administrativo.ToString() : "");
                txtCoordinadorCobranza.Text = (busqueda.Result.Coordinador_Cobranza != null ? busqueda.Result.Coordinador_Cobranza.ToString() : "");
                txtCoordinadorCredito.Text = (busqueda.Result.Coordinador_Crédito != null ? busqueda.Result.Coordinador_Crédito.ToString() : "");
                txtDireccion.Text = (busqueda.Result.Dirección != null ? busqueda.Result.Dirección.ToString() : "");
                txtRepresentaciones.Text= (busqueda.Result.Representaciones != null ? busqueda.Result.Representaciones.ToString() : "");
                txtDireccionRegional.Text= (busqueda.Result.DireccionRegional != null ? busqueda.Result.DireccionRegional.ToString() : "");
                txtTotalAnalistas.Text= (busqueda.Result.Analistas != null ? busqueda.Result.Analistas.ToString() : "");
                txtTotalVentanillas.Text = (busqueda.Result.Ventanillas != null ? busqueda.Result.Ventanillas.ToString() : "");
                txtAnalistasCredito.Text = (busqueda.Result.Analistas_Otorgamiento_de_Crédito != null ? busqueda.Result.Analistas_Otorgamiento_de_Crédito.ToString() : "");
                txtAnalistasAdministrativos.Text= (busqueda.Result.Analistas_Administrativo_y_SAM != null ? busqueda.Result.Analistas_Administrativo_y_SAM.ToString() : "");
                txtAnalistaComercial.Text = (busqueda.Result.Analistas_Crédito_Control_Documental != null ? busqueda.Result.Analistas_Crédito_Control_Documental.ToString() : "");
                txtAnalistasCobranza.Text= (busqueda.Result.Analistas_Cobranza != null ? busqueda.Result.Analistas_Cobranza.ToString() : "");
                txtEmpresasAfiliadas.Text= (busqueda.Result.Empresas_Afiliadas != null ? busqueda.Result.Empresas_Afiliadas.ToString() : "");
                txtTrabajadoresAfiliados.Text= (busqueda.Result.Trabajadores_Afiliados != null ? busqueda.Result.Trabajadores_Afiliados.ToString() : "");
                txtPotencialEmpresas.Text = (busqueda.Result.Potencial_de_Empresas != null ? busqueda.Result.Potencial_de_Empresas.ToString() : "");
                txtPotencialTrabajadores.Text = (busqueda.Result.Potencial_de_Trabajadores != null ? busqueda.Result.Potencial_de_Trabajadores.ToString() : "");
                txtEmpresasEstatus1.Text= (busqueda.Result.Empresas_Status_1 != null ? busqueda.Result.Empresas_Status_1.ToString() : "");
                txtEmpresasEstatus18.Text= (busqueda.Result.Empresas_Status_18 != null ? busqueda.Result.Empresas_Status_18.ToString() : "");
                txtEmpresasEstatus21.Text = (busqueda.Result.Empresas_Status_21 != null ? busqueda.Result.Empresas_Status_21.ToString() : "");
                txtEmpresasEstatus30.Text= (busqueda.Result.Empresas_Status_30 != null ? busqueda.Result.Empresas_Status_30.ToString() : "");
               //falta meta anual
               txtMetaMensual.Text= (busqueda.Result.Meta_Mensual != null ? busqueda.Result.Meta_Mensual.ToString() : "");
                txtColocacionAnual.Text= (busqueda.Result.Colocación_Anual != null ? busqueda.Result.Colocación_Anual.ToString() : "");
                txtColocacionMensual.Text= (busqueda.Result.Colocación_Mensual != null ? busqueda.Result.Colocación_Mensual.ToString() : "");
                txtMetaAcumulada.Text=(busqueda.Result.Meta_Acumulada_Porcentaje != null ? busqueda.Result.Meta_Acumulada_Porcentaje.ToString() : "");
                dtFechaSupervision.Value = busqueda.Result.FechaSupervision.Value;
                //falta  cobranza meta anual
               // txtCobranzaMetaMensual.Text  Hay conflicto porque en la base de datos solo hay campo COBRANZAMETAANUAL , no hay ninguno que haga referencia
               // a cobranza meta mensual
                txtCobranzaPorcentaje.Text= (busqueda.Result.Cobranza_Porcentaje_Meta != null ? busqueda.Result.Cobranza_Porcentaje_Meta.ToString() : "");
                txtCobranzaCumplimiento.Text= (busqueda.Result.Cobranza_Cumplimiento_Meta != null ? busqueda.Result.Cobranza_Cumplimiento_Meta.ToString() : "");

                toolButReasignar.Enabled = true;
                toolButImprimir.Enabled = false;

            }

        }

        private void frmHistoricoSupervisiones_Load(object sender, EventArgs e)
        {
            CargarDatosHistoricoSupervision();
            if (Globales.objpasardatosusuario.IdNivel == 1 || Globales.objpasardatosusuario.IdNivel == 3 || Globales.objpasardatosusuario.IdNivel == 1004)
            {
                toolButReasignar.Enabled = true;
                toolButImprimir.Enabled = true;
            }
            else {
                toolButReasignar.Enabled = false;
                toolButImprimir.Enabled = true;
            }


        }
        public static Bitmap ByteToImage(byte[] blob)
        {
            try
            {
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

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtAnalistaComercial_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void txtAnalistasCredito_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txtAnalistasCobranza_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void txtEmpresasAfiliadas_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void txtTrabajadoresAfiliados_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void txtPotencialEmpresas_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void txtPotencialTrabajadores_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmpresasEstatus1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void txtEmpresasEstatus18_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void txtEmpresasEstatus21_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void txtEmpresasEstatus30_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
