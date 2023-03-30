using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L9_JFMP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        automovil myAutomovil = new automovil();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myAutomovil.DefinirPrecio(Convert.ToDouble(txtBxPrecio.Text));
            myAutomovil.DefinirModelo(Convert.ToInt32(txtBxModelo.Text));
            myAutomovil.DefinirMarca(txtBxMarca.Text);
            myAutomovil.DefinirCambioDolar(Convert.ToDouble(txtBxTipoDeCambio.Text));

            MessageBox.Show("Los Datos se guardaron exitosamente");

            txtBxDatosAutomovil.Text = myAutomovil.MostrarInformacion();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBxDatosAutomovil.Clear();
            txtBxDescuento.Clear();
            txtBxMarca.Clear();
            txtBxModelo.Clear();
            txtBxPrecio.Clear();
            txtBxTipoDeCambio.Clear();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void definirModelo(int unModelo)
        {

        }

        public void definirPrecio(double unPrecio)
        {

        }

        public void definirMarca(string unaMarca)
        {

        }

        public void definirTipoCambioDolar(double unTipoCambioDolar)
        {

        }

        public void aplicarDescuento()
        {
            
        }

        private void BtnAplicar_Click(object sender, EventArgs e)
        {
            myAutomovil.AplicarDescuento(Convert.ToDouble(txtBxDescuento.Text));
            txtBxDatosAutomovil.Text = myAutomovil.MostrarInformacion();
        }

        private void btnCambiarDisponibilidad_Click(object sender, EventArgs e)
        {
            myAutomovil.CambiarDisponibilidad(true);
            txtBxDatosAutomovil.Text = myAutomovil.MostrarInformacion();
        }

        private void txtBxDatosAutomovil_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
