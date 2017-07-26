﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDSfonacotDatos;

namespace GDSfonacot
{
    public partial class SeguimientoSup : Form
    {
        public int valor1 = 0;
        public String valor2 = "";
        public SeguimientoSup()
        {
            InitializeComponent();//
        }

        private void SeguimientoSup_Load(object sender, EventArgs e)
        {
            LlenarDatos();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textSupervision_KeyPress(object sender, KeyPressEventArgs e)
        {


        }
        private void LlenarDatos()
        {
            int[] varstatus = { 1, 2 };
            var objSupervision = new SupervisionesData();
            var busqueda = objSupervision.ObtenerDatosSupervision(valor1, valor2, varstatus);
            if (busqueda.Result != null)
            {
                txthidIdSup.Text = busqueda.Result.IdSupervisiones.ToString();
                txthidIdSeg.Text = "0";
                txtNoSupervision.Text = busqueda.Result.NoSupervision.ToString();
                txtDirectorRegional.Text = busqueda.Result.Director_Regional.ToString();
                txtDirectorEstatal.Text = (busqueda.Result.Director_Estatal != null ? busqueda.Result.Director_Estatal.ToString() : "");
                txtSucursal.Text = busqueda.Result.NoSucursal.ToString() + "- " + busqueda.Result.DescripcionSucursal.ToString();
                textDireccRegional.Text = busqueda.Result.DireccionRegional.ToString();
                textRepresentaciones.Text = (busqueda.Result.Representaciones !=null ? busqueda.Result.Representaciones.ToString() : "");

                // (String.IsNullOrEmpty(busqueda.Result.Representaciones.ToString()),"", busqueda.Result.Representaciones.ToString())
                toolButGuardar.Enabled = true;
                toolButImprimir.Enabled = false;

            }
        }

        private void toolButGuardar_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                return;
            }

            // MessageBox.Show("pASO VALIDACION");
            if (MessageBox.Show("¿La información es correcta? por favor verifique antes de ser registrada", System.Windows.Forms.Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                ;// Mensaje en pantallas)
                var objSeguimiento = new SeguimientoSupervision_Supervisores();
                objSeguimiento.Idseguimiento = Convert.ToInt32(txthidIdSeg.Text.Trim());
                objSeguimiento.Idsupervision = Convert.ToInt32(txthidIdSup.Text.Trim());
              
                objSeguimiento.IdusuarioCreador = Globales.objpasardatosusuario.IdUsuario;
                objSeguimiento.FechaSeguimCreacion = DateTime.Now;

        var gdSupervisiones = new SupervisionesData().GuardarSeguimientoSupervisor(objSeguimiento);
                if (gdSupervisiones.Code != 0)
                {
                    //Mensage de error con g
                    toolButGuardar.Enabled = true;
                    MessageBox.Show(gdSupervisiones.Message.ToString(), System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    toolButImprimir.Enabled = false;

                }
                else
                {

                    toolButGuardar.Enabled = false;
                    toolButImprimir.Enabled = true;
                    MessageBox.Show("El Seguimiento ha sido guardada correctamente", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //  LimpiarDatos();
                    var obactualizarsup = new HistorialSupervisiones();
                    obactualizarsup.IdSupervisiones = Convert.ToInt32(txthidIdSup.Text.Trim());
                    obactualizarsup.Idstatus = 2;
                    var actualizarsup = new SupervisionesData().ActualizarSupervision(obactualizarsup);
                    if (actualizarsup.Code != 0)
                    {

                        MessageBox.Show(gdSupervisiones.Message.ToString(), System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        //La supervision se actualizo a estatus 2, ahora falta la contestacion de la sucursal
                    }
                }

            }
            else
            {
                MessageBox.Show("El Seguimiento no fue guardado, por favor intente nuevamente", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                toolButGuardar.Enabled = true;
                toolButImprimir.Enabled = false;
            }
        }

        private bool validarDatos()
        {
            if (string.IsNullOrEmpty(txtNoSupervision.Text.Trim()) || txtNoSupervision.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa un numero de supervision", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNoSupervision.Focus();
                return true;
            }

            return false;
        }

        private void txtSegSupervisor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
