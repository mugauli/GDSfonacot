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

namespace GDSfonacot.forms
{
    public partial class formVisorReportes : Form
    {
        public formVisorReportes()
        {
            InitializeComponent();
        }

        private void formVisorReportes_Load(object sender, EventArgs e)
        {
            string valor = "DSO/SUP/ENE/007/2017";
            reportes.crpMinutaTrabajo objreport = new reportes.crpMinutaTrabajo();
            objreport.SetParameterValue("@nosupervision", valor);
            objreport.SetDatabaseLogon(Globales.userbd, Globales.pass);
            crpvisor.ReportSource = objreport;
        }

       

    }
}
