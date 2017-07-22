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
    public partial class FormVisorConsultarSupervCR : Form
    {
        public string valor = "";
        public int destino = 0;
        public FormVisorConsultarSupervCR()
        {
            InitializeComponent();
        }
       

        private void FormVisorConsultarSupervC_Load(object sender, EventArgs e)
        {

            reportes.crpMinutaTrabajo objreport = new reportes.crpMinutaTrabajo();
            objreport.SetParameterValue("@nosupervision", valor);
            objreport.SetDatabaseLogon(Globales.userbd, Globales.pass);
            crpvisor.ReportSource = objreport;
        }
    }
}
