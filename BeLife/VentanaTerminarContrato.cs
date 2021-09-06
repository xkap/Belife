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
    public partial class VentanaTerminarContrato : Form
    {
        public VentanaTerminarContrato()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaContratos v = new VentanaContratos();
            v.ShowDialog();
        }

        private void BtnTerminar_Click(object sender, EventArgs e)
        {
            if(Contrato.contratos.Exists(i=> i.NumContrato == TxtNumero.Text))
            {
                Contrato.contratos.Find(i => i.NumContrato == TxtNumero.Text).EstaVig = false;
                Contrato.contratos.Find(i => i.NumContrato == TxtNumero.Text).FechaTermino = DateTime.Now;
                Contrato.contratos.Find(i => i.NumContrato == TxtNumero.Text).FechaTerminoVig = DateTime.Now;
                MessageBox.Show("El contrato ha sido terminado");



            }
            else
            {
                MessageBox.Show("ERROR: El contrato no existe");
            }
        }
    }
}
