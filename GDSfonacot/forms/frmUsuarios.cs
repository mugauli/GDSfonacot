using System;
using GDSfonacotDatos;
using GDSfonacotDatos.Data;
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
    public partial class frmUsuarios : Form
    {
        private int Idusuario = 0;
        private string fecha=null;
     
        public frmUsuarios(int usuario)
        {
            try
            {
                InitializeComponent();
                LoadingCatalogos();
                Idusuario = usuario;
                if (Idusuario != 0)
                {
                    CargarUsuario(Idusuario);
                }
                else
                {
                    LimpiarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex, System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Globales.objpasardatosusuario.IdNivel != 1)
                {
                    MessageBox.Show("Solo el administrador tiene acceso a esta accion", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
                    return;
                }

                var mensaje = string.Empty;
                if (ValidateUsuario(out mensaje))
                {
                    MessageBox.Show(mensaje);
                    return;
                }
                if (txthidIdusuario.Text == "0")
                {
                    var objbuscaUsuario = new UsuariosData();
                    var busqueda = objbuscaUsuario.BuscarUsuario(txtGafete.Text.Trim());
                    if (busqueda.Result != null)
                    {
                        MessageBox.Show("El usuario '" + txtGafete.Text.Trim() + "' ya se encuentra registrado,favor de corregir", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtGafete.Focus();
                        return;
                    }
                }


                if (MessageBox.Show("¿La información es correcta? por favor verifique antes de ser registrada", System.Windows.Forms.Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    var usuario = new Usuarios();
                    usuario.IdUsuario = Convert.ToInt32(txthidIdusuario.Text.ToString());
                    usuario.Nombre_Usuario = txtNombre.Text.ToString();
                    usuario.Usuario = txtGafete.Text.ToString();
                    usuario.Pass = Globales.Encriptar(txtpassword.Text.ToString());
                    usuario.IdNivel = Convert.ToInt32(cmbNivelusuario.SelectedValue);
                    usuario.IdSucursal = Convert.ToInt32(cmbSucursales.SelectedValue);

                    if (Convert.ToInt32(txthidIdusuario.Text.ToString()) == 0)
                    {
                        usuario.fechaalta = System.DateTime.Now;
                        usuario.fechabaja = null;
                        usuario.fechareingreso = null;
                    }
                    else
                    {
                        if (checkinactivar.Checked == true)
                        {
                            usuario.fechabaja = System.DateTime.Now;
                            usuario.fechareingreso = null;
                        }
                        else
                        {
                            //usuario.fechareingreso = System.DateTime.Now;
                            //usuario.fechabaja = null;
                            if (fechaalta.Visible == true && fechabaja.Visible == true && lblfechareingreso.Visible == false)
                            {
                                #region muestradatos
                                usuario.fechabaja = null;
                                usuario.fechareingreso = System.DateTime.Now;
                                fecha = null;
                                #endregion
                            }
                            else
                            {
                                if (fechaalta.Visible == true && lblfechareingreso.Visible == false && fechabaja.Visible == true)
                                {
                                    #region muestradatos
                                    usuario.fechabaja = null;
                                    usuario.fechareingreso = null;
                                    fecha = null;
                                    #endregion
                                }
                                else if (fechaalta.Visible == true && fechabaja.Visible == false && lblfechareingreso.Visible == true)
                                {
                                    #region muestradatos
                                    usuario.fechabaja = null;
                                    fecha = Convert.ToString(dtfechareingreso.Value);
                                    usuario.fechareingreso = Convert.ToDateTime(fecha);
                                    #endregion
                                }
                                else if (fechaalta.Visible == true && fechabaja.Visible == false && lblfechareingreso.Visible == false)
                                {
                                    #region muestradatos
                                    usuario.fechabaja = null;
                                    usuario.fechareingreso = null;
                                    #endregion
                                }
                            }
                        }
                    }

                    var objusuario = new UsuariosData().GuardarUsuario(usuario, checkinactivar.Checked);
                    if (objusuario.Code != 0)
                    {
                        MessageBox.Show("Error: " + objusuario.Message);
                        return;
                        //Mandar mensaje de error con sucursales.Message
                    }

                    else
                    {
                        if (txthidIdusuario.Text == "0")
                        {
                            MessageBox.Show("El nuevo usuario ha sido guardado correctamente", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarDatos();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("El usuario ha sido actualizado correctamente", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarUsuario(Convert.ToInt32(txthidIdusuario.Text.ToString()));
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex, System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
        private bool ValidateUsuario(out string mensaje)
        {
            mensaje = string.Empty;


            if (txtNombre.Text == string.Empty) mensaje += "Favor de introducir el nombre\n";
            if (txtpassword.Text == string.Empty) mensaje += "Favor de introducir el password\n";
            if (txtGafete.Text == string.Empty) mensaje += "Favor de introducir gafete\n";
            if (cmbNivelusuario.SelectedIndex == -1) mensaje += "Favor de seleccionar nivel de usuario\n";
            if (cmbSucursales.SelectedIndex == -1) mensaje += "Favor de seleccionar sucursal\n";

            return !(mensaje == string.Empty);

        }

        private void LoadingCatalogos()
        {
            try
            {
                #region ctSucursal

                var sucursales = new SucursalesData().ObtenerSucursalesCombo();
                if (sucursales.Code != 0)
                {
                    MessageBox.Show("Error: " + sucursales.Message);
                    return;
                    //Mandar mensaje de error con sucursales.Message
                }

                cmbSucursales.DataSource = sucursales.Result;
                cmbSucursales.DisplayMember = "NameSucursal";
                cmbSucursales.ValueMember = "IdSucursal";
                cmbSucursales.SelectedIndex = -1;

                #endregion

                #region ctnivelusuario

                var nivelusuario = new CatalogosData().ObtenerNivelUsuario();
                if (nivelusuario.Code != 0)
                {
                    MessageBox.Show("Error: " + nivelusuario.Message);
                    return;
                    //Mandar mensaje de error con sucursales.Message
                }

                cmbNivelusuario.DataSource = nivelusuario.Result;
                cmbNivelusuario.DisplayMember = "Nivel_Usuario";
                cmbNivelusuario.ValueMember = "IdNivel";
                cmbNivelusuario.SelectedIndex = -1;

                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex, System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void CargarUsuario(int Idusuario)
        {
            try
            {
                var usuarioDB = new UsuariosData().ObtenerUsuarios(Idusuario);
                if (usuarioDB.Code != 0 || usuarioDB.Result.Count < 1)
                {
                    MessageBox.Show("Error: " + usuarioDB.Message);
                    return;
                }
                if (Globales.objpasardatosusuario.IdNivel == 2 || Globales.objpasardatosusuario.IdNivel == 3)
                {
                    txtGafete.Enabled = false;

                }
                else
                {
                    txtGafete.Enabled = true;
                }

                var usu = usuarioDB.Result.First();

                txthidIdusuario.Text = usu.IdUsuario.ToString();
                cmbSucursales.SelectedValue = usu.IdSucursal;
                cmbNivelusuario.SelectedValue = usu.IdNivel;
                txtNombre.Text = usu.Nombre_Usuario;
                txtGafete.Text = usu.Usuario;
                txtGafete.Enabled = false;
                txtpassword.Text = Globales.Desencriptar(usu.Pass);
                if (usu.fechaalta != null && usu.fechabaja != null && usu.fechareingreso == null)
                {
                    #region muestradatos
                    dtFechaalta.Visible = true;
                    dtFechaalta.Enabled = false;
                    dtFechaalta.Value = usu.fechaalta.Value;
                    fechaalta.Visible = true;
                    checkinactivar.Checked = false;
                    dtpickerfechabaja.Visible = true;
                    dtpickerfechabaja.Enabled = false;
                    dtpickerfechabaja.Value = usu.fechabaja.Value;
                    fechabaja.Visible = true;
                    dtfechareingreso.Visible = false;
                    dtfechareingreso.Enabled = false;
                    lblfechareingreso.Visible = false;
                    #endregion
                }
                else
                {
                    if (usu.fechaalta != null && usu.fechareingreso == null && usu.fechabaja == null)
                    {
                        #region muestradatos
                        dtFechaalta.Visible = true;
                        dtFechaalta.Enabled = false;
                        dtFechaalta.Value = usu.fechaalta.Value;
                        fechaalta.Visible = true;
                        checkinactivar.Checked = false;
                        dtpickerfechabaja.Visible = false;
                        dtpickerfechabaja.Enabled = false;
                        fechabaja.Visible = false;
                        dtfechareingreso.Visible = false;
                        dtfechareingreso.Enabled = false;
                        lblfechareingreso.Visible = false;
                        #endregion
                    }
                    else if (usu.fechaalta != null && usu.fechabaja == null && usu.fechareingreso != null)
                    {
                        #region muestradatos
                        dtFechaalta.Visible = true;
                        dtFechaalta.Enabled = false;
                        dtFechaalta.Value = usu.fechaalta.Value;
                        fechaalta.Visible = true;
                        checkinactivar.Checked = false;
                        dtpickerfechabaja.Visible = false;
                        dtpickerfechabaja.Enabled = false;
                        fechabaja.Visible = false;
                        dtfechareingreso.Visible = true;
                        dtfechareingreso.Enabled = false;
                        lblfechareingreso.Visible = true;
                        dtfechareingreso.Value = usu.fechareingreso.Value;
                        #endregion
                    }
                }
                btnNuevo.Enabled = false;
                btnGuardar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex, System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
       

        private void LimpiarDatos()
        {
            txthidIdusuario.Text = "0";
            txtNombre.Text = null;
            txtGafete.Text = null;
            txtGafete.Enabled = true;
            txtpassword.Text = null;
            cmbNivelusuario.SelectedIndex = -1;
            cmbSucursales.SelectedIndex = -1;
            checkinactivar.Checked = false;
            fechaalta.Visible = false;
            fechabaja.Visible = false;
            dtFechaalta.Visible = false;
            dtpickerfechabaja.Visible = false;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
        }
        private void frmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void chkverpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (Globales.objpasardatosusuario.IdNivel == 2 || Globales.objpasardatosusuario.IdNivel == 3 || Globales.objpasardatosusuario.IdNivel ==1004)
            { 
                MessageBox.Show("No tienes privilegio para mostrar el password", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
            }
            else
            {
                if (chkverpassword.Checked == false)
                {
                    txtpassword.PasswordChar = '*';
                    
                }
                else
                {
                    if (txtpassword.Text != "")
                    {
                        txtpassword.Text.ToString();
                        txtpassword.PasswordChar = '\0';
                    }
                }
            }
        }

       
    }
}
