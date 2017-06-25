using GDSfonacotDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDSfonacot
{
    public partial class Supervisiones : Form
    {
        public Supervisiones()
        {
            InitializeComponent();//
        }

        private void Supervisiones_Load(object sender, EventArgs e)
        {
  

        }

        private void textSucursal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

            }
        }

        private void textSucursal_TextChanged(object sender, EventArgs e)
        {
            lblTotRegistros.Text = "";
            var totalsupe = new SupervisionesData().ObtenerSupervisonesporSuc(0, textSucursal.Text.Trim());
            if (totalsupe.Code != 0)
            {
                MessageBox.Show("error");
            }


            dataGlistaSup.DataSource = totalsupe.Result;            
            dataGlistaSup.Columns[0].Visible = false;
            dataGlistaSup.AutoResizeColumns();


            lblTotRegistros.Text = "Total de Registros: " + dataGlistaSup.RowCount;

           


        }

        private void dataGlistaSup_SelectionChanged(object sender, EventArgs e)
        {

            

        }

        private void dataGlistaSup_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGlistaSup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

          
         
        }

        private void dataGlistaSup_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>-1 && e.ColumnIndex > -1) { 
                if(dataGlistaSup.CurrentCell.Selected)
                 {
                    ContestSuc frmconstSuc = new ContestSuc();//crea una instancia del formulario
                    frmconstSuc.valor1 =Convert.ToInt32(dataGlistaSup.Rows[e.RowIndex].Cells[0].Value);
                    frmconstSuc.valor2 = dataGlistaSup.Rows[e.RowIndex].Cells[1].Value.ToString();
                    frmconstSuc.ShowDialog();
                }
            }
        }
    }
}
