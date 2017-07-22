using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDSfonacotDatos.Data;
using GDSfonacotDatos.DTO;
using static GDSfonacotDatos.Utilities.Util;

namespace GDSfonacot.forms
{
    public partial class frmUsuariosSucursales : Form
    {
        private int sucursalInt = 0;
        public frmUsuariosSucursales(int Sucursal)
        {
            InitializeComponent();
            CargarDatos(Sucursal);
            sucursalInt = Sucursal;
        }
        private void frmUsuariosSucursales_Load(object sender, EventArgs e)
        {
            LoadingNivelUsuario();
        }

        private void LoadingNivelUsuario()
        {
            var nivelesusuario = new CatalogosData().ObtenerNivelUsuario();
            if (nivelesusuario.Code != 0)
            {
                //Mandar mensaje de error con sucursales.Message
            }

            cmbNivelusuario.DataSource = nivelesusuario.Result;
            cmbNivelusuario.DisplayMember = "Nivel_Usuario";
            cmbNivelusuario.ValueMember = "IdNivel";
            cmbNivelusuario.SelectedIndex = -1;
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
        private void CargarGridUsuarios(int tipoacceso)
        {
            var _usuariosData = new UsuariosData();
            var usuarios = _usuariosData.ObtenerUsuariosGeneral(sucursalInt, tipoacceso);
            if (usuarios.Code != 0)
            {
                MessageBox.Show("Error: " + usuarios.Message);
            }
            else
            {

                dgvUsuarios.DataSource = usuarios.Result;
                dgvUsuarios.ReadOnly = true;
                dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvUsuarios.Columns[0].Visible = false;
                dgvUsuarios.Columns[0].HeaderText = "ID";
                dgvUsuarios.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                dgvUsuarios.Columns[1].HeaderText = "Nombre Usuario";
                dgvUsuarios.Columns[2].HeaderText = "Nivel de Acceso";
                dgvUsuarios.Columns[3].HeaderText = "Sucursal";

            }


        }


        private DataGridView CargarDatos(List<UsuariosDGV> usuarios)
        {
            var dataGV = new DataGridView();
            dataGV.DataSource = usuarios;
            dataGV.ReadOnly = true;
            dataGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGV.Columns[0].Visible = false;
            dataGV.Columns[0].HeaderText = "ID";
            dataGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;

            dataGV.Columns[1].HeaderText = "Nombre Usuario";
            dataGV.Columns[2].HeaderText = "Nivel de Acceso";
            dataGV.Columns[3].HeaderText = "Sucursal";
            return dataGV;
        }


        private void cmbNivelusuario_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if (cmbNivelusuario.SelectedIndex != 0 || cmbNivelusuario.SelectedIndex != -1)
            {

                CargarGridUsuarios(Convert.ToInt32(cmbNivelusuario.SelectedValue));

            }
        }

        private void dgvUsuarios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                if (dgvUsuarios.CurrentCell.Selected)
                {
                    var valor = dgvUsuarios.Rows[e.RowIndex].Cells[0].Value;


                    var frmPersonsuc = new frmUsuarios(Convert.ToInt32(valor));//crea una instancia del formulario
                    frmPersonsuc.MdiParent = this.ParentForm;                                                          // frmPersonsuc.MdiParent = this.ParentForm;
                    frmPersonsuc.Show();
                   //  this.Close();

                }
            }
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
