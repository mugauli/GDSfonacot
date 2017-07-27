﻿using System;
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
    public partial class FormBusConsultasSupervision : Form
    {
        public FormBusConsultasSupervision()
        {
            InitializeComponent();
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
            var totalsupe = new SupervisionesData().ObtenerSupervisonesporSuc(0, textSucursal.Text.Trim(),3);
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
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                if (dataGlistaSup.CurrentCell.Selected)
                {
                    var valor = dataGlistaSup.Rows[e.RowIndex].Cells[1].Value;
                    MessageBox.Show("Has seleccionado la supervision " + valor);
                }
            }
        }
    }
}