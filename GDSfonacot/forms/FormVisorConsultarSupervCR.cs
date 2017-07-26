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
        public string param1 = "";
        public string param2 = "";
        public int destino = 0;
        public FormVisorConsultarSupervCR(int destinoreport)
        {
            InitializeComponent();
            destino = destinoreport;
        }
       

        private void FormVisorConsultarSupervC_Load(object sender, EventArgs e)
        {
            if (destino == 1)//consultando reporte de supervision creado por supervisor operaciones
            {
                this.Text = "Minuta de Trabajo por Supervision";
                reportes.crpMinutaTrabajo objreport = new reportes.crpMinutaTrabajo();
                objreport.SetParameterValue("@nosupervision", param1);
                objreport.SetDatabaseLogon(Globales.userbd, Globales.pass);
                crpvisor.ReportSource = objreport;
               
            }
            else if (destino == 2)//consultando reporte de contestacion de sucursal
            {
                this.Text = "Contestacion de supervision por sucursal";
                reportes.crpContestacion objreport = new reportes.crpContestacion();
                objreport.SetParameterValue("@nosupervision", param1);
                objreport.SetDatabaseLogon(Globales.userbd, Globales.pass);
                crpvisor.ReportSource = objreport;
                
            }

            else if (destino == 3)//consultando historico de supervision 
            {
                this.Text = "Historico por Supervision";
                reportes.crpHistoricoSuperv objreport = new reportes.crpHistoricoSuperv();
                objreport.SetParameterValue("@nosupervision", param1);
                objreport.SetDatabaseLogon(Globales.userbd, Globales.pass);
                crpvisor.ReportSource = objreport;
            }
            else if (destino == 4)//consultando seguimiento creado por supervisor
            {
                this.Text = "Seguimiento por Supervision";
                reportes.crpSeguimiento objreport = new reportes.crpSeguimiento();
                objreport.SetParameterValue("@idsupervision", param1);
                objreport.SetParameterValue("@idseguimiento", param2);
                objreport.SetDatabaseLogon(Globales.userbd, Globales.pass);
                crpvisor.ReportSource = objreport;
            }
            else if (destino == 5)//consultando seguimiento creado por supervisor
            {
                this.Text = "Historico por Supervision Contestada por Sucursal";
                reportes.crpHistoricoSupervSuc objreport = new reportes.crpHistoricoSupervSuc();
                objreport.SetParameterValue("@idsupervision", param1);
                objreport.SetParameterValue("@idseguimiento", param2);
                objreport.SetDatabaseLogon(Globales.userbd, Globales.pass);
                crpvisor.ReportSource = objreport;
            }
        }
    }
}
