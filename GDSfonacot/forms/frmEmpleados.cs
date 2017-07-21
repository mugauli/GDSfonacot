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

            if (IdEmpleado != 0) CargarEmpleado(IdEmpleado);



        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var mensaje = string.Empty;
            if (ValidateEmpleado(out mensaje))
            {
                MessageBox.Show(mensaje);
                return;
            }

            var empleado = new Empleados();
            empleado.IdEmpleado = IdEmpleadoInt;
            empleado.Nombre = txtNombre.Text.ToString().Trim();
            empleado.Gafete = txtGafete.Text.ToString().Trim();
            empleado.Jornada = txtJornada.Text.ToString().Trim();
            empleado.Horario = txtHorario.Text.ToString().Trim();
            empleado.IdRegional = cmbRegional.SelectedIndex;
            empleado.IdSucursal = cmbSucursal.SelectedIndex;
            empleado.IdTipoPersonal = cmbTipoPersonal.SelectedIndex;
            empleado.IdArea = cmbActividad.SelectedIndex;
            empleado.IdPerfilSistema = cmbPerfilSistema.SelectedIndex;
            empleado.IdActividad = cmbActividad.SelectedIndex;

            var objEmpleado = new EmpleadosData().GuadarEmpleado(empleado);
            if (objEmpleado.Code != 0)
            {
                MessageBox.Show("Error: " + objEmpleado.Message);
                return;
                //Mandar mensaje de error con sucursales.Message
            }


        }
        private bool ValidateEmpleado(out string mensaje)
        {
            mensaje = string.Empty;


            if (txtNombre.Text == string.Empty) mensaje += "Favor de introducir el nombre\n";
            if (txtGafete.Text == string.Empty) mensaje += "Favor de introducir el gafete\n";
            if (txtJornada.Text == string.Empty) mensaje += "Favor de introducir la jornada\n";
            if (txtHorario.Text == string.Empty) mensaje += "Favor de introducir el horario\n";
            if (cmbRegional.SelectedIndex == -1) mensaje += "Favor de seleccionar regional\n";
            if (cmbSucursal.SelectedIndex == -1) mensaje += "Favor de seleccionar sucursal\n";
            if (cmbTipoPersonal.SelectedIndex == -1) mensaje += "Favor de seleccionar tipo de personal\n";
            if (cmbActividad.SelectedIndex == -1) mensaje += "Favor de seleccionar actividad\n";
            if (cmbPerfilSistema.SelectedIndex == -1) mensaje += "Favor de seleccionar perfil en sistema\n";
            if (cmbArea.SelectedIndex == -1) mensaje += "Favor de seleccionar área\n";

            return !(mensaje == string.Empty);
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

            #region ctRegional

            var ctRegional = new CatalogosData().ObtenerRegional();
            if (ctRegional.Code != 0)
            {
                MessageBox.Show("Error: " + ctRegional.Message);
                return;
                //Mandar mensaje de error con sucursales.Message
            }

            cmbRegional.DataSource = ctRegional.Result;
            cmbRegional.DisplayMember = "Descripcion";
            cmbRegional.ValueMember = "IdRegional";
            cmbRegional.SelectedIndex = -1;

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

            var sucursales = new SupervisionesData().ObtenerSucursalesCombo();
            if (sucursales.Code != 0)
            {
                MessageBox.Show("Error: " + ctRegional.Message);
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

            txtNombre.Text = emp.Nombre.ToString().Trim();
            txtGafete.Text = emp.Gafete.ToString().Trim();
            txtJornada.Text = emp.Jornada.ToString().Trim();
            txtHorario.Text = emp.Horario.ToString().Trim();
            cmbRegional.SelectedValue = emp.IdRegional;
            cmbSucursal.SelectedValue= emp.IdSucursal;
            cmbTipoPersonal.SelectedValue = emp.IdTipoPersonal;
            cmbActividad.SelectedValue = emp.IdActividad;
            cmbPerfilSistema.SelectedValue = emp.IdPerfilSistema;
            cmbArea.SelectedValue = emp.IdArea;
        }
    }
}
