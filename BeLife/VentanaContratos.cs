using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeLife
{
    public partial class VentanaContratos : Form
    {
        public VentanaContratos()
        {
            InitializeComponent();
            
        }

        private void btnVolverClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaMain v = new VentanaMain();
            v.ShowDialog();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            VentanaCrearContrato v = new VentanaCrearContrato();
            this.Hide();
            v.ShowDialog();
        }

        private void BtnListado_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaListadoContratos v = new VentanaListadoContratos();
            v.ShowDialog();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaBuscarContrato v = new VentanaBuscarContrato();
            v.ShowDialog();
        }

        private void BtnTerminar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaTerminarContrato v = new VentanaTerminarContrato();
            v.ShowDialog();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaModificarContrato v = new VentanaModificarContrato();
            v.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VentanaContratos_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
