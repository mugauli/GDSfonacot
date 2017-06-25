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
          
        }
        private void LlenarDatos()
        {
            var objSupervision = new SupervisionesData();
            var busqueda = objSupervision.ObtenerDatosSupervision(valor1, valor2);
            if (busqueda.Result != null)
            {
              //  txthidIdSup.Text = busqueda.Result.IdSupervisiones.ToString();
              
                txtNoSupervision.Text = busqueda.Result.NoSupervision.ToString();
            
                txtInmueble.Text = busqueda.Result.Inmueble.ToString();
                txtGesDireccion.Text = busqueda.Result.Gestion_direccion.ToString();
                txtOriginacion.Text = busqueda.Result.Originacion.ToString();
                txtTransfer.Text = busqueda.Result.Tarjetas_transfer.ToString();
                txtCredito.Text = busqueda.Result.Credito.ToString();
                txtUTYS.Text = busqueda.Result.Utys.ToString();
                txtPromocionales.Text = busqueda.Result.Promocionales.ToString();
                txtCobranza.Text = busqueda.Result.Cobranza.ToString();
                txtFonFijo.Text = busqueda.Result.Fondofijo.ToString();
               
            }
        }
    }
}
