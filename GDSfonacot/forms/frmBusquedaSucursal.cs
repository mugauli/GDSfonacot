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
using GDSfonacotDatos.Data;
using GDSfonacotDatos.DTO;
using static GDSfonacotDatos.Utilities.Util;

namespace GDSfonacot.forms
{
    public partial class frmBusquedaSucursal : Form
    {
        private int guardaractualizar = 0;
        private int destinoInt = 0;
        public frmBusquedaSucursal(int Destino)
        {
            InitializeComponent();
            destinoInt = Destino;
        }

        private void txtSucursal_TextChanged(object sender, EventArgs e)
        {
            if (txtSucursal.Text.Length > 3)
            {
                lblRegistros.Text = "";
                var totalsupe = new SucursalesData().ObtenerSucursalesFilter(txtSucursal.Text.Trim());
                if (totalsupe.Code != 0)
                {
                    MessageBox.Show("error");
                }


                dataGlistaSup.DataSource = totalsupe.Result;
                dataGlistaSup.ReadOnly = true;
                dataGlistaSup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGlistaSup.Columns[0].Visible = false;
                dataGlistaSup.Columns[0].HeaderText = "ID";
                dataGlistaSup.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;

                dataGlistaSup.Columns[1].HeaderText = "Nombre";
                dataGlistaSup.Columns[2].HeaderText= "No. Sucursal";
                dataGlistaSup.Columns[3].HeaderText = "Regional";




                
                lblRegistros.Text = "Total de Registros: " + dataGlistaSup.RowCount;
            }
            else
            {
                dataGlistaSup.Columns.Clear();
                 dataGlistaSup.DataSource=null;
            }
        }

        private void dataGlistaSup_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    if (dataGlistaSup.CurrentCell.Selected)
                    {
                        var valor = dataGlistaSup.Rows[e.RowIndex].Cells[0].Value;

                        if (destinoInt == 1)
                        {

                           
                            PersonalSucursales frmPersonsuc = new PersonalSucursales(Convert.ToInt32(valor));//crea una instancia del formulario
                            frmPersonsuc.MdiParent = this.ParentForm;
                            frmPersonsuc.Show();
                            this.Close();
                        }
                        else if (destinoInt == 2)
                        {
                            if (guardaractualizar == 0)
                            {
                                //forms.frmSupervisiom frmhistSup = new forms.frmSupervisiom(0);//crea una instancia del formulario
                                var frmsup = new frmSucursales(Convert.ToInt32(valor));//crea una instancia del formulario
                                frmsup.MdiParent = this.ParentForm;
                                frmsup.Show();
                                this.Close();
                            }
                            else
                            {
                                //forms.frmSupervisiom frmhistSup = new forms.frmSupervisiom(1);//crea una instancia del formulario
                                var frmsup = new frmSucursales(Convert.ToInt32(valor));//crea una instancia del formulario
                                frmsup.MdiParent = this.ParentForm;
                                frmsup.Show();
                                this.Close();
                            }

                    
                        }
                        else if (destinoInt == 3)
                        {
                            if (guardaractualizar == 0)
                            {
                                var frmusu = new frmUsuariosSucursales(Convert.ToInt32(valor));//crea una instancia del formulario
                                frmusu.MdiParent = this.ParentForm;
                                frmusu.Show();
                                this.Close();
                            }
                            else
                            {
                                var frmusu = new frmUsuariosSucursales(Convert.ToInt32(valor));//crea una instancia del formulario
                                frmusu.MdiParent = this.ParentForm;
                                frmusu.Show();
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
