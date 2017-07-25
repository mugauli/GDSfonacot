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
using GDSfonacotDatos.DTO;
using GDSfonacotDatos.Data;

namespace GDSfonacot.forms
{
    public partial class frmBusquedaSupervisiones : Form
    {
        private int guardaractualizar =0;
        private int destinoInt = 0;
        private int[] varstatus = { 0 };
        private int varseguimiento = 0;
        public frmBusquedaSupervisiones(int Destino,int [] status,int guardaactualiza,int seguimiento)
        {
            InitializeComponent();
            destinoInt = Destino;
            varstatus = status;
            guardaractualizar = guardaactualiza;
            varseguimiento = seguimiento;
            if (destinoInt == 1)
            {
                this.Text = "Busqueda de Seguimientos de Supervision";
            }
            else if (destinoInt == 2)
            {
                this.Text = "Busqueda de Contestaciones de Supervision";                               
            }
            else if (destinoInt == 3)
            {

                this.Text = "Busqueda de Histórico de Supervision";
            }

            else if (destinoInt == 4)
            {
                this.Text = "Busqueda de  Supervision";
            }
            
        
    }
        private void CargarSupervisiones(string fechaini,string fechafin,string buscasup)
        {
                lblRegistros.Text = "";
           
            
            if (fechaini != null && fechafin != null)//busca entre fechas de supervision
            {
                var totalsupe = new SupervisionesData().ObtenerSupervisonesporSucFechas(0, varstatus,DateTime.Parse(fechaini), DateTime.Parse(fechafin));
                #region buscaRegistrosentrefechas
                if (totalsupe.Code != 0)
                {
                    MessageBox.Show("error:" +totalsupe.Message);
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
                #endregion 

            }

            else {//se quita el filtrado y busca por supervision
                #region buscaRegistrosporsupervision
                var totalsupe = new SupervisionesData().ObtenerUnaSup_porSucIndividual(0, varstatus, buscasup.Trim());
                if (totalsupe.Code != 0)
                {
                    MessageBox.Show("error:" + totalsupe.Message);
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
                #endregion 
            }



        }

        private void CargarSeguimientoSupervisiones(string fechaini, string fechafin, string buscasup)
        {

            lblRegistros.Text = "";


            if (fechaini != null && fechafin != null)//busca entre fechas de supervision
            {
                var totalsupe2 = new SeguimientosData().ObtenerSupervisonesSegporSucFechas(0, varstatus, DateTime.Parse(fechaini), DateTime.Parse(fechafin));
                #region buscaRegistrosentrefechas
                if (totalsupe2.Code != 0)
                {
                    MessageBox.Show("error:" + totalsupe2.Message);
                    dataGlistaSup.Columns.Clear();
                    dataGlistaSup.DataSource = null;
                }

                else
                {
                    dataGlistaSup.DataSource = totalsupe2.Result;
                    dataGlistaSup.ReadOnly = true;
                    dataGlistaSup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    dataGlistaSup.Columns[0].Visible = false;
                    dataGlistaSup.Columns[0].HeaderText = "IdSup";
                    dataGlistaSup.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                    dataGlistaSup.Columns[1].HeaderText = "No. Seguimiento";
                    dataGlistaSup.Columns[2].HeaderText = "Fecha Seguimiento";
                    dataGlistaSup.Columns[3].HeaderText = "No. Supervision";
                    dataGlistaSup.Columns[4].HeaderText = "Fecha Supervision";
                    dataGlistaSup.Columns[5].HeaderText = "Sucursal";
                    lblRegistros.Text = "Total de Registros: " + dataGlistaSup.RowCount;
                }
                #endregion 

            }

            else
            {//se quita el filtrado y busca por supervision
                #region buscaRegistrosporsupervision
                var totalsupe2 = new SeguimientosData().ObtenerSupervisonesSegporSucIndividual(0, varstatus, buscasup.Trim());
                if (totalsupe2.Code != 0)
                {
                    MessageBox.Show("error:" + totalsupe2.Message);
                    dataGlistaSup.Columns.Clear();
                    dataGlistaSup.DataSource = null;
                }

                else
                {
                    dataGlistaSup.DataSource = totalsupe2.Result;
                    dataGlistaSup.ReadOnly = true;
                    dataGlistaSup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    dataGlistaSup.Columns[0].Visible = false;
                    dataGlistaSup.Columns[0].HeaderText = "IdSup";
                    dataGlistaSup.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                    dataGlistaSup.Columns[1].HeaderText = "No. Seguimiento";
                    dataGlistaSup.Columns[2].HeaderText = "Fecha Seguimiento";
                    dataGlistaSup.Columns[3].HeaderText = "No. Supervision";
                    dataGlistaSup.Columns[4].HeaderText = "Fecha Supervision";
                    dataGlistaSup.Columns[5].HeaderText = "Sucursal";
                    lblRegistros.Text = "Total de Registros: " + dataGlistaSup.RowCount;
                }
                #endregion 
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
                            if (guardaractualizar == 0)
                            {

                                //abrir seguimiento
                                frmSeguimiento frmSegSup = new frmSeguimiento(0);//crea una instancia del formulario
                                frmSegSup.idsup = Convert.ToInt32(dataGlistaSup.Rows[e.RowIndex].Cells[0].Value);
                                frmSegSup.valor2 = dataGlistaSup.Rows[e.RowIndex].Cells[1].Value.ToString();
                                frmSegSup.MdiParent = this.ParentForm;
                                frmSegSup.Show();
                                this.Close();
                            }
                            else
                            {
                                frmSeguimiento frmSegSup = new frmSeguimiento(1);//crea una instancia del formulario
                                frmSegSup.idsup = Convert.ToInt32(dataGlistaSup.Rows[e.RowIndex].Cells[0].Value);
                                frmSegSup.idseg = Convert.ToInt32(dataGlistaSup.Rows[e.RowIndex].Cells[1].Value);
                                frmSegSup.valor2 = dataGlistaSup.Rows[e.RowIndex].Cells[1].Value.ToString();
                                frmSegSup.MdiParent = this.ParentForm;
                                frmSegSup.Show();
                                this.Close();
                            }
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
                                forms.frmHistoricoSupervisiones frmhistSup = new forms.frmHistoricoSupervisiones(0);//crea una instancia del formulario
                                frmhistSup.valor1 = Convert.ToInt32(dataGlistaSup.Rows[e.RowIndex].Cells[0].Value);
                                frmhistSup.valor2 = dataGlistaSup.Rows[e.RowIndex].Cells[1].Value.ToString();
                                frmhistSup.MdiParent = this.ParentForm;
                                frmhistSup.Show();
                                this.Close();
                            }
                            else
                            {
                                forms.frmHistoricoSupervisiones frmhistSup = new forms.frmHistoricoSupervisiones(1);//crea una instancia del formulario
                                frmhistSup.valor1 = Convert.ToInt32(dataGlistaSup.Rows[e.RowIndex].Cells[0].Value);
                                frmhistSup.valor2 = dataGlistaSup.Rows[e.RowIndex].Cells[1].Value.ToString();
                                frmhistSup.MdiParent = this.ParentForm;
                                frmhistSup.Show();
                                this.Close();
                            }
                        }

                        else if (destinoInt == 4)
                        {
                            if (guardaractualizar == 0)
                            {
                                forms.frmSupervisiom frmhistSup = new forms.frmSupervisiom(0);//crea una instancia del formulario
                                frmhistSup.valor1 = Convert.ToInt32(dataGlistaSup.Rows[e.RowIndex].Cells[0].Value);
                                frmhistSup.valor2 = dataGlistaSup.Rows[e.RowIndex].Cells[1].Value.ToString();
                                frmhistSup.MdiParent = this.ParentForm;
                                frmhistSup.Show();
                                this.Close();
                            }
                            else
                            {
                                forms.frmSupervisiom frmhistSup = new forms.frmSupervisiom(1);//crea una instancia del formulario
                                frmhistSup.valor1 = Convert.ToInt32(dataGlistaSup.Rows[e.RowIndex].Cells[0].Value);
                                frmhistSup.valor2 = dataGlistaSup.Rows[e.RowIndex].Cells[1].Value.ToString();
                                frmhistSup.MdiParent = this.ParentForm;
                                frmhistSup.Show();
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

        private void dataGlistaSup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkbuscaSup_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbuscaSup.Checked == true)
            {
                txtsupervision.Enabled = true;
                txtsupervision.Focus();
                dataGlistaSup.Columns.Clear();
                dataGlistaSup.DataSource = null;
                dpickerFechaini.Enabled = false;
                dpickerFechafin.Enabled = false;

            }
            else
            {
                dataGlistaSup.Columns.Clear();
                dataGlistaSup.DataSource = null;
                txtsupervision.Text = null;
                txtsupervision.Enabled = false;
                dpickerFechaini.Enabled = true;
                dpickerFechafin.Enabled = true;
            }
        }

        private void txtsupervision_TextChanged(object sender, EventArgs e)
        {
            if (txtsupervision.Text.Length > 3) {

                if (varseguimiento == 0)
                {
                    CargarSupervisiones(null, null, txtsupervision.Text);
                }
                else
                {
                    CargarSeguimientoSupervisiones(null, null, txtsupervision.Text);
                }
               
            }


        }

        private void dpickerFechaini_ValueChanged(object sender, EventArgs e)
        {

            if (varseguimiento == 0)
            {
                CargarSupervisiones(dpickerFechaini.Value.ToShortDateString(), dpickerFechafin.Value.ToShortDateString(), txtsupervision.Text.Trim());
            }
            else
            {
                CargarSeguimientoSupervisiones(dpickerFechaini.Value.ToShortDateString(), dpickerFechafin.Value.ToShortDateString(), txtsupervision.Text.Trim());
            }
        }

        private void dpickerFechafin_ValueChanged(object sender, EventArgs e)
        {
            if (varseguimiento == 0)
            {
                CargarSupervisiones(dpickerFechaini.Value.ToShortDateString(), dpickerFechafin.Value.ToShortDateString(), txtsupervision.Text.Trim());
            }
            else
            {
                CargarSeguimientoSupervisiones(dpickerFechaini.Value.ToShortDateString(), dpickerFechafin.Value.ToShortDateString(), txtsupervision.Text.Trim());
            }
        }
    }
}
