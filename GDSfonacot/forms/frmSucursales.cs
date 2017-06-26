using GDSfonacot.Helpers;
using GDSfonacotDatos;
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
    public partial class frmSucursales : Form
    {
        private int SucursalInt = 0;
        public frmSucursales(int Sucursal)
        {
            InitializeComponent();
            SucursalInt = Sucursal;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void brsImagen_HelpRequest(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            // Se muestra al usuario esperando una acción
            DialogResult result = dialog.ShowDialog();

            // Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)
            // la mostramos en el PictureBox de la inferfaz
            if (result == DialogResult.OK)
            {
                pbxSucursal.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Archivo JPG|*.jpg|Archivo PNG (*.png)|*.png";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pbxSucursal.Image = Image.FromFile(fileDialog.FileName);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            new SupervisionesData().GuardarImagen(SucursalInt, ImageHelper.ImageToByteArray(pbxSucursal.Image));
        }
    }
}
