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
    public partial class VentanaBuscarCliente : Form
    {
        public VentanaBuscarCliente()
        {
            InitializeComponent();
            PanelResultados.Hide();
        }

        private void PanelPrincipal_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            string sex;// 1= Masculino     2= Femenino
            string ecivil;//1= Soltero 2=Casado 3=Divorciado 4= Viudo
            if (Cliente.clientes.Exists(i=> TxtRut.Text == i.Rut)){
               
                PanelResultados.Show();
                if(Cliente.clientes.Find(i => TxtRut.Text == i.Rut).IdSexo == 1)
                {
                    sex = "Masculino";
                }
                else
                {
                    sex = "Femenino";
                }

                if (Cliente.clientes.Find(i => TxtRut.Text == i.Rut).IdEcivil == 1)
                {
                    ecivil = "Soltero";

                }else if(Cliente.clientes.Find(i => TxtRut.Text == i.Rut).IdSexo == 2)
                {
                    ecivil = "Casado";

                }else if(Cliente.clientes.Find(i => TxtRut.Text == i.Rut).IdSexo == 3)
                {
                    ecivil = "Divorciado";
                }
                else
                {
                    ecivil = "Viudo";
                }

                
                LblRut.Text= Cliente.clientes.Find(i=> TxtRut.Text == i.Rut).Rut;
                LblNombre.Text = Cliente.clientes.Find(i => TxtRut.Text == i.Rut).Nombre;
                LblApellidos.Text = Cliente.clientes.Find(i => TxtRut.Text == i.Rut).Apellidos;
                LblFecha.Text = Cliente.clientes.Find(i => TxtRut.Text == i.Rut).FechaNacimiento.ToString();
                LblSexo.Text = sex ;
                LblEstado.Text = ecivil;

            }
            else
            {
                MessageBox.Show("El cliente no existe");
            }
        }

        private void PanelResultados_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            PanelResultados.Hide();

        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
