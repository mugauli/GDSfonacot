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
              //  txthidIdSup.Text = busqueda.Result.IdSupervisiones.ToString();
              
                txtNoSupervision.Text = busqueda.Result.NoSupervision.ToString();
                txtDirRegional.Text = busqueda.Result.Director_Regional.ToString();
                txtDirEstatal.Text= busqueda.Result.Director_Estatal.ToString();
                txtSucursal.Text= busqueda.Result.NoSucursal.ToString() + "- " +busqueda.Result.DescripcionSucursal.ToString();

            }
        }
    }
}
