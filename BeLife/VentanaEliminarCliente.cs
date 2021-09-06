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
    public partial class VentanaEliminarCliente : Form
    {
        public VentanaEliminarCliente()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaClientes v = new VentanaClientes();
            v.ShowDialog();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if(Cliente.clientes.Find(i=> i.Rut == TxtRut.Text) == null)
            {
                MessageBox.Show("ERROR: El cliente no existe");
            }
            else if(Contrato.contratos.Find(i=> i.Titular == TxtRut.Text) != null)
            {
                MessageBox.Show("ERROR: El cliente posee contratos.");
            }
            else
            {
                Cliente.clientes.Remove(Cliente.clientes.Find(i => i.Rut == TxtRut.Text));
                MessageBox.Show("Cliente eliminado");
            }
        }
    }
}
