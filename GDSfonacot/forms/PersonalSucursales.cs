using GDSfonacot.forms;
using GDSfonacotDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDSfonacotDatos.Data;
using GDSfonacotDatos.DTO;
using static GDSfonacotDatos.Utilities.Util;

namespace GDSfonacot
{
    public partial class PersonalSucursales : Form
    {
        private int sucursalInt = 0;
        public PersonalSucursales(int Sucursal)
        {
            InitializeComponent();
            CargarDatos(Sucursal);
            sucursalInt = Sucursal;
        }
        private void LoadingCatTipoPersonal()
        {
            var perfilessistema = new CatalogosData().ObtenerTipoPersonal();
            if (perfilessistema.Code != 0)
            {
                //Mandar mensaje de error con sucursales.Message
            }

            cmbperfilsistema.DataSource = perfilessistema.Result;
            cmbperfilsistema.DisplayMember = "Descripcion";
            cmbperfilsistema.ValueMember = "IdTipoPersonal";
            cmbperfilsistema.SelectedIndex = -1;
        }
        private void PersonalSucursales_Load(object sender, EventArgs e)
        {
            //iniciando form
            LoadingCatTipoPersonal();

        }

        private void tabadmin_Click(object sender, EventArgs e)
        {

        }

        public void CargarDatos(int Sucursal)
        {

            var SucursalDB = new SucursalesData().ObtenerSucursales(Sucursal);
            if (SucursalDB.Code != 0)
            {
                MessageBox.Show("Error: " + SucursalDB.Message);
                return;
            }

            var objSucursal = SucursalDB.Result.First();
            var imagen = ByteToImage(objSucursal.Fotografia);

            if (imagen != null) pbxSucursal.Image = imagen;
            txtDireccionRegional.Text = objSucursal.DireccionRegional;
            txtNoSucursal.Text = objSucursal.NoSucursal.ToString();
            txtSucursal.Text = objSucursal.DescripcionSucursal;
            txtRepresentaciones.Text = objSucursal.Representaciones;
            txtDireccion.Text = objSucursal.Dirección;
            txtDirectorRegional.Text = objSucursal.Director_Regional;
            txtDirectorEstatal.Text = objSucursal.Director_Estatal;
            txtCoordinadorAdministrativo.Text = objSucursal.Coordinador_Administrativo;
            txtCoordinadorCredito.Text = objSucursal.Coordinador_Crédito;
            txtCoordinadorCobranza.Text = objSucursal.Coordinador_Cobranza;
            txtAnalistas.Text = objSucursal.Analistas.ToString();
            txtVentanillas.Text = objSucursal.Ventanillas.ToString();







        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            try
            {
                if (blob == null) return null;
                MemoryStream mStream = new MemoryStream();


                mStream.Write(blob, 0, Convert.ToInt32(blob.Length));

                Bitmap bm = new Bitmap(mStream, true);
                mStream.Dispose();
                return bm;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return null;
            }


        }


        private void CargarGridEmpleados(int tipoperfil)
        {
            var _EmpleadosData = new EmpleadosData();
            var empleados1 = _EmpleadosData.ObtenerEmpleadosGeneralporTipoPersonal(sucursalInt, tipoperfil);
            if (empleados1.Code != 0)
            {
                MessageBox.Show("Error: " + empleados1.Message);
            }
            else
            {

                dgvEmpleados.DataSource = empleados1.Result;
                dgvEmpleados.ReadOnly = true;
                dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvEmpleados.Columns[0].Visible = false;
                dgvEmpleados.Columns[0].HeaderText = "ID";
                dgvEmpleados.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                dgvEmpleados.Columns[1].HeaderText = "Nombre";
                dgvEmpleados.Columns[2].HeaderText = "Gafete";
                dgvEmpleados.Columns[3].HeaderText = "Tipo Personal";
                dgvEmpleados.Columns[4].HeaderText = "Perfil Sistema";
                dgvEmpleados.Columns[5].HeaderText = "Jornada";
                dgvEmpleados.Columns[6].HeaderText = "Horario";
                dgvEmpleados.Columns[7].HeaderText = "Actividad";
                lblRegistros.Text = "Total de Registros: " + dgvEmpleados.RowCount;
            }


        }


        private DataGridView CargarDatos(List<EmpleadosDGV> empleados)
        {
            var dataGV = new DataGridView();
            dataGV.DataSource = empleados;
            dataGV.ReadOnly = true;
            dataGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGV.Columns[0].Visible = false;
            dataGV.Columns[0].HeaderText = "ID";
            dataGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;

            dataGV.Columns[1].HeaderText = "Nombre";
            dataGV.Columns[2].HeaderText = "Gafete";
            dataGV.Columns[3].HeaderText = "Tipo Personal";
            dataGV.Columns[4].HeaderText = "Perfil Sistema";
            dataGV.Columns[5].HeaderText = "Jornada";
            dataGV.Columns[6].HeaderText = "Horario";
            dataGV.Columns[7].HeaderText = "Actividad";
            return dataGV;
        }


        private void cmbperfilsistema_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if (cmbperfilsistema.SelectedIndex != 0 || cmbperfilsistema.SelectedIndex != -1)
            {
                checkmostrartodos.Checked = false;
                CargarGridEmpleados(Convert.ToInt32(cmbperfilsistema.SelectedValue));

            }
        }

        private void dgvEmpleados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                if (dgvEmpleados.CurrentCell.Selected)
                {
                    var valor = dgvEmpleados.Rows[e.RowIndex].Cells[0].Value;


                    var frmusuSuc = new frmEmpleados(Convert.ToInt32(valor));//crea una instancia del formulario
                    //frmPersonsuc.MdiParent = this.ParentForm;
                    frmusuSuc.ShowDialog();
                    //this.Close();
                    dgvEmpleados.Columns.Clear();
                    checkmostrartodos.Checked = false;
                    cmbperfilsistema.SelectedIndex = -1;
                    this.Close();

                }
            }
        }

        private void checkmostrartodos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkmostrartodos.Checked == true)
            {
                #region mostrartodosempleados
                cmbperfilsistema.SelectedIndex = -1;
                var _EmpleadosData = new EmpleadosData();
                var empleados1 = _EmpleadosData.ObtenerEmpleadosGeneral(sucursalInt);
                if (empleados1.Code != 0)
                {
                    MessageBox.Show("Error: " + empleados1.Message);
                }
                else
                {

                    dgvEmpleados.DataSource = empleados1.Result;
                    dgvEmpleados.ReadOnly = true;
                    dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvEmpleados.Columns[0].Visible = false;
                    dgvEmpleados.Columns[0].HeaderText = "ID";
                    dgvEmpleados.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                    dgvEmpleados.Columns[1].HeaderText = "Nombre";
                    dgvEmpleados.Columns[2].HeaderText = "Gafete";
                    dgvEmpleados.Columns[3].HeaderText = "Tipo Personal";
                    dgvEmpleados.Columns[4].HeaderText = "Perfil Sistema";
                    dgvEmpleados.Columns[5].HeaderText = "Jornada";
                    dgvEmpleados.Columns[6].HeaderText = "Horario";
                    dgvEmpleados.Columns[7].HeaderText = "Actividad";
                    lblRegistros.Text = "Total de Registros: " + dgvEmpleados.RowCount;
                }
#endregion
            }
            else
            {
                dgvEmpleados.Columns.Clear();

            }
        }

        private void butImprimir_Click(object sender, EventArgs e)
        {
            forms.FormVisorConsultarSupervCR frmvisor = new forms.FormVisorConsultarSupervCR(6);//crea una instancia del formulario
            if (checkmostrartodos.Checked == true)
            {
                frmvisor.param1 = Convert.ToString(sucursalInt);
                frmvisor.param2 = "";
                frmvisor.ShowDialog();
            }
            else if (cmbperfilsistema.SelectedIndex != -1) {
            frmvisor.param1 = Convert.ToString(sucursalInt);
            frmvisor.param2 = Convert.ToString(cmbperfilsistema.SelectedValue);
                frmvisor.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debes seleccionar un tipo de 'personal' o la casilla 'Mostrar todos los empleados' para imprimir", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
 }
