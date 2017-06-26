using GDSfonacot.forms;
using GDSfonacotDatos;
using GDSfonacotDatos.Data;
using GDSfonacotDatos.DTO;
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

        private void PersonalSucursales_Load(object sender, EventArgs e)
        {
            //iniciando form

        }

        private void tabadmin_Click(object sender, EventArgs e)
        {

        }

        public void CargarDatos(int Sucursal)
        {

            var SucursalDB = new SupervisionesData().ObtenerSucursales(Sucursal);
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
                MemoryStream mStream = new MemoryStream();


                mStream.Write(blob, 0, Convert.ToInt32(blob.Length));

                Bitmap bm = new Bitmap(mStream, true);
                mStream.Dispose();
                return bm;
            }
            catch (Exception ex)
            {

                return null;
            }

        }

        private void TabsEmpleados_Selected(object sender, TabControlEventArgs e)
        {
            MessageBox.Show("Tab seleccionado:" + e.TabPageIndex);
            CargarGrid(e.TabPage.Name);
        }

        private void CargarGrid(string tabSelected)
        {
            //sucursalInt

            var _EmpleadosData = new EmpleadosData();


            switch (tabSelected)
            {
                case "tabadmin":
                    var empleados1 = _EmpleadosData.ObtenerEmpleadosAdministrativos(sucursalInt);
                    if (empleados1.Code != 0)
                    {
                        MessageBox.Show("Error: " + empleados1.Message);
                        break;
                    }

                    dgvAdministrativos.DataSource = empleados1.Result;
                    dgvAdministrativos.ReadOnly = true;
                    dgvAdministrativos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvAdministrativos.Columns[0].Visible = false;
                    dgvAdministrativos.Columns[0].Name = "ID";
                    dgvAdministrativos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                    dgvAdministrativos.Columns[1].Name = "Nombre";
                    dgvAdministrativos.Columns[2].Name = "Gafete";
                    dgvAdministrativos.Columns[3].Name = "Jornada";
                    dgvAdministrativos.Columns[4].Name = "Horario";
                    break;
                case "taborig":
                    var empleados2 = _EmpleadosData.ObtenerEmpleadosOriginacion(sucursalInt);
                    if (empleados2.Code != 0)
                    {
                        MessageBox.Show("Error: " + empleados2.Message);
                        break;
                    }
                    dgvOriginacion.DataSource = empleados2.Result;
                    dgvOriginacion.ReadOnly = true;
                    dgvOriginacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    dgvOriginacion.Columns[0].Visible = false;
                    dgvOriginacion.Columns[0].Name = "ID";
                    dgvOriginacion.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;

                    dgvOriginacion.Columns[1].Name = "Nombre";
                    dgvOriginacion.Columns[2].Name = "Gafete";
                    dgvOriginacion.Columns[3].Name = "Jornada";
                    dgvOriginacion.Columns[4].Name = "Horario";
                    break;
                case "tabcred":
                    var empleados3 = _EmpleadosData.ObtenerEmpleadosCredito(sucursalInt);
                    if (empleados3.Code != 0)
                    {
                        MessageBox.Show("Error: " + empleados3.Message);
                        break;
                    }

                    dgvCreditos.DataSource = empleados3.Result;
                    dgvCreditos.ReadOnly = true;
                    dgvCreditos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvCreditos.Columns[0].Visible = false;
                    dgvCreditos.Columns[0].Name = "ID";
                    dgvCreditos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                    dgvCreditos.Columns[1].Name = "Nombre";
                    dgvCreditos.Columns[2].Name = "Gafete";
                    dgvCreditos.Columns[3].Name = "Jornada";
                    dgvCreditos.Columns[4].Name = "Horario";
                    break;
                case "tabcobra":
                    var empleados4 = _EmpleadosData.ObtenerEmpleadosCobranza(sucursalInt);
                    if (empleados4.Code != 0)
                    {
                        MessageBox.Show("Error: " + empleados4.Message);
                        break;
                    }

                    dgvCobranza.DataSource = empleados4.Result;
                    dgvCobranza.ReadOnly = true;
                    dgvCobranza.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvCobranza.Columns[0].Visible = false;
                    dgvCobranza.Columns[0].Name = "ID";
                    dgvCobranza.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                    dgvCobranza.Columns[1].Name = "Nombre";
                    dgvCobranza.Columns[2].Name = "Gafete";
                    dgvCobranza.Columns[3].Name = "Jornada";
                    dgvCobranza.Columns[4].Name = "Horario";
                    break;
                case "taboutso":
                    var empleados5 = _EmpleadosData.ObtenerEmpleadosOutsourcing(sucursalInt);
                    if (empleados5.Code != 0)
                    {
                        MessageBox.Show("Error: " + empleados5.Message);
                        break;
                    }

                    dgvOutsourcing.DataSource = empleados5.Result;
                    dgvOutsourcing.ReadOnly = true;
                    dgvOutsourcing.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvOutsourcing.Columns[0].Visible = false;
                    dgvOutsourcing.Columns[0].Name = "ID";
                    dgvOutsourcing.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                    dgvOutsourcing.Columns[1].Name = "Nombre";
                    dgvOutsourcing.Columns[2].Name = "Gafete";
                    dgvOutsourcing.Columns[3].Name = "Jornada";
                    dgvOutsourcing.Columns[4].Name = "Horario";
                    break;

            }

        }

        private DataGridView CargarDatos(List<EmpleadosDGV> empleados)
        {
            var dataGV = new DataGridView();
            dataGV.DataSource = empleados;
            dataGV.ReadOnly = true;
            dataGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGV.Columns[0].Visible = false;
            dataGV.Columns[0].Name = "ID";
            dataGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;

            dataGV.Columns[1].Name = "Nombre";
            dataGV.Columns[2].Name = "Gafete";
            dataGV.Columns[3].Name = "Jornada";
            dataGV.Columns[4].Name = "Horario";

            return dataGV;
        }

        private void dgvAdministrativos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                if (dgvAdministrativos.CurrentCell.Selected)
                {
                    var valor = dgvAdministrativos.Rows[e.RowIndex].Cells[0].Value;


                    var frmPersonsuc = new frmEmpleados(Convert.ToInt32(valor));//crea una instancia del formulario
                    frmPersonsuc.MdiParent = this.ParentForm;
                    frmPersonsuc.Show();
                    this.Close();

                }
            }
        }

        private void dgvOriginacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                if (dgvOriginacion.CurrentCell.Selected)
                {
                    var valor = dgvOriginacion.Rows[e.RowIndex].Cells[0].Value;


                    var frmPersonsuc = new frmEmpleados(Convert.ToInt32(valor));//crea una instancia del formulario
                    frmPersonsuc.MdiParent = this.ParentForm;
                    frmPersonsuc.Show();
                    this.Close();

                }
            }
        }

        private void dgvCreditos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                if (dgvCreditos.CurrentCell.Selected)
                {
                    var valor = dgvCreditos.Rows[e.RowIndex].Cells[0].Value;


                    var frmPersonsuc = new frmEmpleados(Convert.ToInt32(valor));//crea una instancia del formulario
                    frmPersonsuc.MdiParent = this.ParentForm;
                    frmPersonsuc.Show();
                    this.Close();

                }
            }
        }

        private void dgvCobranza_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                if (dgvAdministrativos.CurrentCell.Selected)
                {
                    var valor = dgvAdministrativos.Rows[e.RowIndex].Cells[0].Value;


                    var frmPersonsuc = new frmEmpleados(Convert.ToInt32(valor));//crea una instancia del formulario
                    frmPersonsuc.MdiParent = this.ParentForm;
                    frmPersonsuc.Show();
                    this.Close();

                }
            }
        }

        private void dgvCobranza_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                if (dgvCobranza.CurrentCell.Selected)
                {
                    var valor = dgvCobranza.Rows[e.RowIndex].Cells[0].Value;


                    var frmPersonsuc = new frmEmpleados(Convert.ToInt32(valor));//crea una instancia del formulario
                    frmPersonsuc.MdiParent = this.ParentForm;
                    frmPersonsuc.Show();
                    this.Close();

                }
            }
        }

        private void dgvOutsourcing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                if (dgvOutsourcing.CurrentCell.Selected)
                {
                    var valor = dgvOutsourcing.Rows[e.RowIndex].Cells[0].Value;

                    var frmPersonsuc = new frmEmpleados(Convert.ToInt32(valor));//crea una instancia del formulario
                    frmPersonsuc.MdiParent = this.ParentForm;
                    frmPersonsuc.Show();
                    this.Close();

                }
            }

            
        }
    }
}
