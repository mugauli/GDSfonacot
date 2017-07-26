using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDSfonacotDatos;
using GDSfonacotDatos.Data;


namespace GDSfonacot
{

    public partial class frmLogin : Form
    {
      UsuariosData objusuario = new UsuariosData();


        public frmLogin()
        {
            InitializeComponent();
        }

        private void butEntrar_Click(object sender, EventArgs e)
        {
            //
            ValidaCajastexto(); //void que valida

        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();//salir de aplicacion completamentes
        }

        private void textUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ValidaCajastexto();
            }

        }

        private void textPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ValidaCajastexto();
            }
        }
        private void ValidaCajastexto()
        {
            #region ValidacajasUser
            if (String.IsNullOrEmpty(textUsuario.Text.Trim()) || String.IsNullOrEmpty(textPass.Text.Trim()))
            {//primer if valida usuario

                MessageBox.Show("Debe ingresar el usuario y el password.", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textUsuario.Focus();

            }//llave cierre del primer if que valida el usuario
            else
            {//else1 para anidar un segundo if y validar solo la contraseña

                var logueo = objusuario.LoginUsuario(textUsuario.Text,Globales.Encriptar(textPass.Text));
                //var insertar=   objusuario.GuardarSupervision(;
                if (logueo.Result != null)
                {


                    if (logueo.Result.fechabaja != null)
                    {
                        MessageBox.Show("El usuario " + logueo.Result.Nombre_Usuario + " gafete " + logueo.Result.Usuario + " esta dado de baja,favor de verificar con el administrador del sistema", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);// Mensaje en pantallas

                    }
                    else
                    {
                       // MessageBox.Show("Bienvenido " + logueo.Result.Nombre_Usuario, System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);// Mensaje en pantallas

                        Globales.objpasardatosusuario.IdNivel = logueo.Result.IdNivel;
                        Globales.objpasardatosusuario.Nombre_Usuario = logueo.Result.Nombre_Usuario;
                        Globales.objpasardatosusuario.IdUsuario = logueo.Result.IdUsuario;
                        Globales.objpasardatosusuario.fechabaja = logueo.Result.fechabaja;
                        Globales.objpasardatosusuario.IdSucursal = logueo.Result.IdSucursal;
                        MDIPrincip frmPanel = new MDIPrincip();//crea una instancia del formulario
                        this.Hide();  //oculta el formulario
                        frmPanel.ShowDialog();//muestra el formulario forma modal
                        this.Close();//cierra el formulario
                    }
                }

                else
                {

                    MessageBox.Show("El usuario " + textUsuario.Text.Trim() + " y/o contraseña ingresado," + Environment.NewLine +
                    "no existe o son invalidos.Intente nuevamente", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
                }

            }//llave cierre del else1
            #endregion Permiteacceso
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
