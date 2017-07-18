using System;
using GDSfonacotDatos;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDSfonacot.forms
{
    public partial class frmBusquedaSupervisiones : Form
    {
        private int guardaractualizar =0;
        private int destinoInt = 0;
        private int[] varstatus = { 0 };
        public frmBusquedaSupervisiones(int Destino,int [] status,int guardaactualiza)
        {
            InitializeComponent();
            destinoInt = Destino;
            varstatus = status;
            guardaractualizar = guardaactualiza;
            CargarSupervisiones();
        }
        private void CargarSupervisiones()
        {
           
                lblRegistros.Text = "";
           
            var totalsupe = new SupervisionesData().ObtenerSupervisonesporSucIndividual(0,varstatus);
            if (totalsupe.Code != 0)
            {
                MessageBox.Show("error");
                dataGlistaSup.Columns.Clear();
                dataGlistaSup.DataSource = null;
            }

            else
            {
                dataGlistaSup.DataSource = totalsupe.Result;
                dataGlistaSup.ReadOnly = true;
                dataGlistaSup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGlistaSup.Columns[0].Visible = false;
                dataGlistaSup.Columns[0].HeaderText = "ID";
                dataGlistaSup.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;

                dataGlistaSup.Columns[1].HeaderText = "No. Supervision";
                dataGlistaSup.Columns[2].HeaderText = "Fecha Supervision";
                dataGlistaSup.Columns[3].HeaderText = "Sucursal";





                lblRegistros.Text = "Total de Registros: " + dataGlistaSup.RowCount;
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
                           
                            //abrir contestacion de sucursales
                            SeguimientoSup frmSegSup = new SeguimientoSup();//crea una instancia del formulario
                            frmSegSup.valor1 = Convert.ToInt32(dataGlistaSup.Rows[e.RowIndex].Cells[0].Value);
                            frmSegSup.valor2 = dataGlistaSup.Rows[e.RowIndex].Cells[1].Value.ToString();
                            frmSegSup.MdiParent = this.ParentForm;
                            frmSegSup.Show();
                            
                            //PersonalSucursales frmPersonsuc = new PersonalSucursales(Convert.ToInt32(valor));//crea una instancia del formulario
                            //frmPersonsuc.MdiParent = this.ParentForm;
                            //frmPersonsuc.Show();
                            //this.Close();
                        }
                        else if (destinoInt == 2)
                        {
                            //
                            if (guardaractualizar == 0)
                            {
                                ContestSuc frmconstSuc = new ContestSuc(0);//crea una instancia del formulario
                                frmconstSuc.valor1 = Convert.ToInt32(dataGlistaSup.Rows[e.RowIndex].Cells[0].Value);
                                frmconstSuc.valor2 = dataGlistaSup.Rows[e.RowIndex].Cells[1].Value.ToString();
                                frmconstSuc.MdiParent = this.ParentForm;
                                frmconstSuc.Show();
                                this.Close();
                            }
                            else
                            {
                                ContestSuc frmconstSuc = new ContestSuc(1);//crea una instancia del formulario
                                frmconstSuc.valor1 = Convert.ToInt32(dataGlistaSup.Rows[e.RowIndex].Cells[0].Value);
                                frmconstSuc.valor2 = dataGlistaSup.Rows[e.RowIndex].Cells[1].Value.ToString();
                                frmconstSuc.MdiParent = this.ParentForm;
                                frmconstSuc.Show();
                                this.Close();

                            }
                            //var frmsup = new frmSucursales(Convert.ToInt32(valor));//crea una instancia del formulario
                            //frmsup.MdiParent = this.ParentForm;
                            //frmsup.Show();
                            //this.Close();
                        }
                        else if (destinoInt == 3)
                        {
                            if (guardaractualizar == 0)
                            {
                                // forms.frmHistoricoSupervisiones frmhistSup = new forms.frmHistoricoSupervisiones(0);//crea una instancia del formulario
                                //frmhistSup.valor1 = Convert.ToInt32(dataGlistaSup.Rows[e.RowIndex].Cells[0].Value);
                                //frmhistSup.valor2 = dataGlistaSup.Rows[e.RowIndex].Cells[1].Value.ToString();
                                //frmhistSup.MdiParent = this.ParentForm;
                                //frmhistSup.Show();
                                //this.Close();
                            }
                            else
                            {
                                //forms.frmHistoricoSupervisiones frmhistSup = new forms.frmHistoricoSupervisiones(1);//crea una instancia del formulario
                                //frmhistSup.valor1 = Convert.ToInt32(dataGlistaSup.Rows[e.RowIndex].Cells[0].Value);
                                //frmhistSup.valor2 = dataGlistaSup.Rows[e.RowIndex].Cells[1].Value.ToString();
                                //frmhistSup.MdiParent = this.ParentForm;
                                //frmhistSup.Show();
                                //this.Close();
                            }
                            var frmsup = new frmSucursales(Convert.ToInt32(valor));//crea una instancia del formulario
                            frmsup.MdiParent = this.ParentForm;
                            frmsup.Show();
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dataGlistaSup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
