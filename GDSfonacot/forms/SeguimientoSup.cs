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
    public partial class SeguimientoSup : Form
    {
        public int valor1 = 0;
        public String valor2 = "";
        public SeguimientoSup()
        {
            InitializeComponent();//
        }

        private void SeguimientoSup_Load(object sender, EventArgs e)
        {
            LlenarDatos();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textSupervision_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            if (e.KeyChar==13)
            {
              
            }
        }
        private void LlenarDatos()
        {
            var objSupervision = new SupervisionesData();
            var busqueda = objSupervision.ObtenerDatosSupervision(valor1, valor2,1);
            if (busqueda.Result != null)
            {
                //  txthidIdSup.Text = busqueda.Result.IdSupervisiones.ToString();

                txtNoSupervision.Text = busqueda.Result.NoSupervision.ToString();
                txtDirectorRegional.Text = busqueda.Result.Director_Regional.ToString();
                txtDirectorEstatal.Text = busqueda.Result.Director_Estatal.ToString();
                txtSucursal.Text = busqueda.Result.NoSucursal.ToString() + "- " + busqueda.Result.DescripcionSucursal.ToString();
                textDireccRegional.Text = busqueda.Result.DireccionRegional.ToString();
                textRepresentaciones.Text = busqueda.Result.Representaciones.ToString();
                toolButGuardar.Enabled = true;
                toolButImprimir.Enabled = false;

            }
        }
    }
}
