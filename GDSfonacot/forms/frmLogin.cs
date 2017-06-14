using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDSfonacot
{
    
    public partial class frmLogin : Form
    {
        GDSfonacotDatos.SupervisionesData objusuario = new GDSfonacotDatos.SupervisionesData();
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
            if (String.IsNullOrEmpty(textUsuario.Text.Trim()))
            {//primer if valida usuario

                MessageBox.Show("Usuario incorrecto,verifique nuevamente", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textUsuario.Focus();

            }//llave cierre del primer if que valida el usuario
            #endregion ValidacajasUser

            #region ValidacajasPassword
            else
            {//else1 para anidar un segundo if y validar solo la contraseña
                if (String.IsNullOrEmpty(textPass.Text.Trim()))
                {
                    MessageBox.Show("Contraseña Incorrecta,verifique nuevamente", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textPass.Focus();
                }
                #endregion ValidacajasPassword
           

                #region PermiteAcceso
                else
                {// este else2 va ligado al segundo if anidado  (linea27)
                    var logueo = objusuario.LoginUsuario(textUsuario.Text, textPass.Text);
                  
                    if (logueo.Result != null)
                    {
                                                
                        MessageBox.Show("Bienvenido " + logueo.Result.Nombre_Usuario, System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);// Mensaje en pantallas
                        MDIPrincip frmPanel = new MDIPrincip();//crea una instancia del formulario
                        this.Hide();  //oculta el formulario
                        frmPanel.ShowDialog();//muestra el formulario forma modal
                        this.Close();//cierra el formulario
                    }
                    else
                    {
                        MessageBox.Show("El usuario " + textUsuario.Text.Trim() + " y/o contraseña ingresado," + Environment.NewLine +
                        "no existe o son invalidos.Intente nuevamente", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);// Mensaje en pantallas
                    }
                }//llave cierre del else2
            }//llave cierre del else1
            #endregion Permiteacceso
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
