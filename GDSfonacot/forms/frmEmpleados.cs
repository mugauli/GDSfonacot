using GDSfonacotDatos;
using GDSfonacotDatos.Data;
using System;
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
    public partial class frmEmpleados : Form
    {
        private int IdEmpleadoInt = 0;
        public frmEmpleados(int IdEmpleado)
        {
            InitializeComponent();
            LoadingCatalogos();
            IdEmpleadoInt = IdEmpleado;

            if (IdEmpleado != 0)
            {
                CargarEmpleado(IdEmpleado);
            }
            else
            {
                LimpiarDatos();
            }



        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var mensaje = string.Empty;
            if (ValidateEmpleado(out mensaje))
            {
                MessageBox.Show(mensaje,System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txthidIdEmpleado.Text == "0")
            {
                var objbuscaEmpleado = new EmpleadosData();
                var busqueda = objbuscaEmpleado.BuscarGafeteEmpleado(txtGafete.Text.Trim());
                if (busqueda.Result != null)
                {
                    MessageBox.Show("El gafete de este empledo '" + txtGafete.Text.Trim() + "' ya se encuentra registrado,favor de corregir", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtGafete.Focus();
                    return;
                }
            }
            if (MessageBox.Show("¿La información es correcta? por favor verifique antes de ser registrada", System.Windows.Forms.Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            { 
                var empleados = new Empleados();
                empleados.IdEmpleado = Convert.ToInt32(txthidIdEmpleado.Text.ToString());
                empleados.Nombre = txtNombre.Text.ToString().Trim();
                empleados.Gafete = txtGafete.Text.ToString().Trim();
                empleados.Jornada = txtJornada.Text.ToString().Trim();
                empleados.Horario = txtHorario.Text.ToString().Trim();
               // empleados.IdRegional = Convert.ToInt32(textRegional.Text);
                empleados.IdSucursal = Convert.ToInt32(cmbSucursal.SelectedValue);
                empleados.IdTipoPersonal = Convert.ToInt32(cmbTipoPersonal.SelectedValue);
                empleados.IdArea = Convert.ToInt32(cmbActividad.SelectedValue);
                empleados.IdPerfilSistema = Convert.ToInt32(cmbPerfilSistema.SelectedValue);
                empleados.IdActividad = Convert.ToInt32(cmbActividad.SelectedValue);

                var objEmpleado = new EmpleadosData().GuadarEmpleado(empleados);
                if (objEmpleado.Code != 0)
                {
                    MessageBox.Show("Error: " + objEmpleado.Message);
                    return;
                    //Mandar mensaje de error con sucursales.Message
                }
                else
                {
                    if (txthidIdEmpleado.Text =="0")
                    {
                        MessageBox.Show("El nuevo empleado ha sido guardado correctamente", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarDatos();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("El empleado ha sido actualizado correctamente", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarEmpleado(Convert.ToInt32(txthidIdEmpleado.Text.ToString()));
                        this.Close();
                    }
                }

            }

        }
        private bool ValidateEmpleado(out string mensaje)
        {
            mensaje = string.Empty;


            if (txtNombre.Text == string.Empty) mensaje += "Favor de introducir el nombre\n";
            if (txtGafete.Text == string.Empty) mensaje += "Favor de introducir el gafete\n";
            if (txtJornada.Text == string.Empty) mensaje += "Favor de introducir la jornada\n";
            if (txtHorario.Text == string.Empty) mensaje += "Favor de introducir el horario\n";
            if (cmbSucursal.SelectedIndex == -1) mensaje += "Favor de seleccionar sucursal\n";
            if (cmbTipoPersonal.SelectedIndex == -1) mensaje += "Favor de seleccionar tipo de personal\n";
            if (cmbActividad.SelectedIndex == -1) mensaje += "Favor de seleccionar actividad\n";
            if (cmbPerfilSistema.SelectedIndex == -1) mensaje += "Favor de seleccionar perfil en sistema\n";
            if (cmbArea.SelectedIndex == -1) mensaje += "Favor de seleccionar área\n";

            return !(mensaje == string.Empty);
        }
        private void LimpiarDatos()
        {
            txthidIdEmpleado.Text = "0";
            txtNombre.Text = null;
            txtGafete.Text = null;
            txtJornada.Text=null;
            txtHorario.Text = null;
            textRegional.Text = null;
            cmbSucursal.SelectedIndex = -1;
            cmbTipoPersonal.SelectedIndex = -1;
            cmbActividad.SelectedIndex = -1;
            cmbArea.SelectedIndex = -1;
            cmbPerfilSistema.SelectedIndex = -1;
            cmbActividad.SelectedIndex = -1;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
        }
        private void LoadingCatalogos()
        {
            #region ctActividad

            var ctActividad = new CatalogosData().ObtenerActividad();
            if (ctActividad.Code != 0)
            {
                MessageBox.Show("Error: " + ctActividad.Message);
                return;
                //Mandar mensaje de error con sucursales.Message
            }

            cmbActividad.DataSource = ctActividad.Result;
            cmbActividad.DisplayMember = "Descripcion";
            cmbActividad.ValueMember = "IdActividad";
            cmbActividad.SelectedIndex = -1;

            #endregion

            #region ctArea

            var ctArea = new CatalogosData().ObtenerArea();
            if (ctArea.Code != 0)
            {
                MessageBox.Show("Error: " + ctArea.Message);
                return;
                //Mandar mensaje de error con sucursales.Message
            }

            cmbArea.DataSource = ctArea.Result;
            cmbArea.DisplayMember = "Descripcion";
            cmbArea.ValueMember = "IdArea";
            cmbArea.SelectedIndex = -1;

            #endregion

            #region ctPerfilSistema

            var ctPerfilSistema = new CatalogosData().ObtenerPerfilSistema();
            if (ctPerfilSistema.Code != 0)
            {
                MessageBox.Show("Error: " + ctPerfilSistema.Message);
                return;
                //Mandar mensaje de error con sucursales.Message
            }

            cmbPerfilSistema.DataSource = ctPerfilSistema.Result;
            cmbPerfilSistema.DisplayMember = "Descripcion";
            cmbPerfilSistema.ValueMember = "IdPerfilSistema";
            cmbPerfilSistema.SelectedIndex = -1;

            #endregion

            #region ctTipoPersonal

            var ctTipoPersonal = new CatalogosData().ObtenerTipoPersonal();
            if (ctTipoPersonal.Code != 0)
            {
                MessageBox.Show("Error: " + ctTipoPersonal.Message);
                return;
                //Mandar mensaje de error con sucursales.Message
            }

            cmbTipoPersonal.DataSource = ctTipoPersonal.Result;
            cmbTipoPersonal.DisplayMember = "Descripcion";
            cmbTipoPersonal.ValueMember = "IdTipoPersonal";
            cmbTipoPersonal.SelectedIndex = -1;

            #endregion

            #region ctSucursal

            var sucursales = new SucursalesData().ObtenerSucursalesCombo();
            if (sucursales.Code != 0)
            {
                MessageBox.Show("Error: " + sucursales.Message);
                return;
                //Mandar mensaje de error con sucursales.Message
            }

            cmbSucursal.DataSource = sucursales.Result;
            cmbSucursal.DisplayMember = "NameSucursal";
            cmbSucursal.ValueMember = "IdSucursal";
            cmbSucursal.SelectedIndex = -1;

            #endregion

        }

        private void CargarEmpleado(int IdEmpleado)
        {
            var empleadoDB = new EmpleadosData().ObtenerEmpleados(IdEmpleado, 0);
            if (empleadoDB.Code != 0 || empleadoDB.Result.Count < 1)
            {
                MessageBox.Show("Error: " + empleadoDB.Message);
                return;
            }

            var emp = empleadoDB.Result.First();
            txthidIdEmpleado.Text = IdEmpleado.ToString();
            if (Globales.objpasardatosusuario.IdNivel == 2)
            {
                txtNombre.Enabled = false;
                txtGafete.Enabled = false;
            }
            else
            { 
                txtNombre.Enabled = true;
                txtGafete.Enabled = true;
            }
            txtNombre.Text = emp.Nombre.ToString().Trim();
            txtGafete.Text = emp.Gafete.ToString().Trim();
            txtJornada.Text = emp.Jornada.ToString().Trim();
            txtHorario.Text = emp.Horario.ToString().Trim();
            cmbSucursal.SelectedValue= emp.IdSucursal;
            textRegional.Text = DevuelveRegion(Convert.ToInt32(cmbSucursal.SelectedValue));
            cmbTipoPersonal.SelectedValue = emp.IdTipoPersonal;
            cmbActividad.SelectedValue = emp.IdActividad;
            cmbPerfilSistema.SelectedValue = emp.IdPerfilSistema;
            cmbArea.SelectedValue = emp.IdArea;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void cmbSucursal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbSucursal.SelectedIndex != 0 || cmbSucursal.SelectedIndex != -1)
            {
                textRegional.Text = DevuelveRegion(Convert.ToInt32(cmbSucursal.SelectedValue));
            }
            else
            {
                 textRegional.Text = "";
            }
        }
        
        private String DevuelveRegion(int sucursal)
        {
            var regionDB = new SucursalesData().ObtenerRegionSucursal(sucursal);
            if (regionDB.Code != 0 || regionDB.Result.Count < 1)
            {
                MessageBox.Show("Error: " + regionDB.Message);
                return "";
            }
            else { 
            var reg = regionDB.Result.First();
            return reg.DireccionRegional;
            }
        }
    }
}
