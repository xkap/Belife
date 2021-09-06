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
    public partial class VentanaModificarCliente : Form
    {
        public VentanaModificarCliente()
        {
            InitializeComponent();
            PanelResultados.Hide();

            RadioSoltero.Checked = true;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaClientes v = new VentanaClientes();
            v.ShowDialog();
            

        }

        public int CalcularEdad(DateTime f)
        {
            int years = DateTime.Now.Year - Fecha.Value.Year;
            if (f.Month > DateTime.Now.Month)
            {
                years--;
            }
            if (f.Month == DateTime.Now.Month && f.Day > DateTime.Now.Day)
            {
                years--;
            }
            return years;
        }


        private void BtnModificar_Click(object sender, EventArgs e)
        {
            string sexo;

            if (Cliente.clientes.Exists(i => TxtRut.Text == i.Rut) == false)
            {
                MessageBox.Show("Error el cliente no existe");
            }
            else
            {
                PanelResultados.Show();
                if (Cliente.clientes.Find(i => i.Rut == TxtRut.Text).IdSexo == 1)
                {
                    sexo = "Masculino";
                }
                else
                {
                    sexo = "Femenino";
                }
                    
                    LblRut.Text = Cliente.clientes.Find(i => i.Rut == TxtRut.Text).Rut;
                    LblNombre.Text = Cliente.clientes.Find(i => i.Rut == TxtRut.Text).Nombre;
                    LblApellidos.Text = Cliente.clientes.Find(i => i.Rut == TxtRut.Text).Apellidos;
                    LblSexo.Text = sexo;

                }

            
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            
            byte ecivil;
            
            
            if (RadioSoltero.Checked == true)
            {
                ecivil = 1;
            }
            else if (RadioCasado.Checked == true)
            {
                ecivil = 2;
            }
            else if (RadioDivorciado.Checked == true)
            {
                ecivil = 3;
            }
            else
            {
                ecivil = 4;
            }
            if (CalcularEdad(Fecha.Value.Date) >= 18)
            {
                Cliente.clientes.Find(i => i.Rut == TxtRut.Text).FechaNacimiento = Fecha.Value.Date;
                Cliente.clientes.Find(i => i.Rut == TxtRut.Text).IdEcivil = ecivil;
                PanelResultados.Hide();
                MessageBox.Show("Cliente Modificado con Éxito");
            }
            else
            {
                MessageBox.Show("ERROR: La edad debe ser mayor o igual a 18 años ");
            }
            

            
            
        }
    }
}
