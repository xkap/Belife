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
    public partial class ListadoClientes : Form
    {
        public ListadoClientes()
        {
            InitializeComponent();

            List<string> sexos = new List<string>() { "Masculino", "Femenino" };
            List<string> estados = new List<string>() { "Soltero", "Casado", "Divorciado", "Viudo" };
            Lista.Items.Clear();
            ComboSexo.Items.Clear();
            ComboEstados.Items.Clear();

            //Lista.DataSource = Cliente.clientes;
            foreach (Cliente c in Cliente.clientes)
            {
                Lista.Items.Add(c);
            }
            Lista.DisplayMember = "Rut";
            Lista.ValueMember = "Rut";

            foreach (string s in sexos)//agregando sexos a combo box para filtrar
            {

                ComboSexo.Items.Add(s);

                /* string y = Lista.GetItemText(Lista.TopIndex+1);
                 Lista.Items.Add(Cliente.clientes.Find(i => i.Rut != y).Rut);*/
            }

            foreach (string e in estados)//agregando estados civiles a combobox para filtrar
            {
                ComboEstados.Items.Add(e);

            }





        }

        private void ListadoClientes_Load(object sender, EventArgs e)
        {

        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool ValidaSeleccion()
        {

            if (Lista.SelectedItem != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sex;// 1= Masculino     2= Femenino
            string ecivil;//1= Soltero 2=Casado 3=Divorciado 4= Viudo


            if (ValidaSeleccion() == true)
            {


                if (Cliente.clientes.Find(i => Lista.GetItemText(Lista.SelectedItem) == i.Rut).IdSexo == 1)
                {
                    sex = "Masculino";
                }
                else
                {
                    sex = "Femenino";
                }

                if (Cliente.clientes.Find(i => Lista.GetItemText(Lista.SelectedItem) == i.Rut).IdEcivil == 1)
                {
                    ecivil = "Soltero";

                }
                else if (Cliente.clientes.Find(i => Lista.GetItemText(Lista.SelectedItem) == i.Rut).IdEcivil == 2)
                {
                    ecivil = "Casado";

                }
                else if (Cliente.clientes.Find(i => Lista.GetItemText(Lista.SelectedItem) == i.Rut).IdEcivil == 3)
                {
                    ecivil = "Divorciado";
                }
                else
                {
                    ecivil = "Viudo";
                }


                LblRut.Text = Cliente.clientes.Find(i => Lista.GetItemText(Lista.SelectedItem) == i.Rut).Rut;
                LblNombre.Text = Cliente.clientes.Find(i => Lista.GetItemText(Lista.SelectedItem) == i.Rut).Nombre;
                LblApellidos.Text = Cliente.clientes.Find(i => Lista.GetItemText(Lista.SelectedItem) == i.Rut).Apellidos;
                LblFecha.Text = Cliente.clientes.Find(i => Lista.GetItemText(Lista.SelectedItem) == i.Rut).FechaNacimiento.ToString();
                LblSexo.Text = sex;
                LblEstado.Text = ecivil;

            }
            else
            {
                MessageBox.Show("Error debe seleccionar un item");
            }
        }

        private void ComboSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnFiltrarSexo_Click(object sender, EventArgs e)
        {
            if (ComboSexo.Text == "Masculino")
            {

                /*Lista.Items.Clear();
                Lista.DataSource = Cliente.clientes.Find(i=> i.IdSexo==2);
                Lista.DisplayMember = "Id";
                Lista.ValueMember = "Id";*/

                /*for (int j = 0; j < y; j++)
                {
                    
                    //Lista.GetItemText(Lista.T)
                    Lista.Items.Add(Cliente.clientes.Find(i => i.IdSexo == 1 && i.));

                CÓDIGO QUE NO FUNCIONO
                }*/
                //Lista.Items.Remove(Cliente.clientes.Find(i => i.IdSexo != 1));




                Lista.Items.Clear();//me limpia la lista
                foreach(Cliente c in Cliente.clientes) //foreach para recorrer la lista de clientes y ver cual es hombre
                {
                    if (c.IdSexo == 1) // si es hombre se agrega al listbox que está vacío.
                    {
                        Lista.Items.Add(c);
                    }
                    
                }




            }
            else if (ComboSexo.Text == "Femenino")
            {
                Lista.Items.Clear();
                foreach(Cliente c in Cliente.clientes)
                {
                    if (c.IdSexo == 2)
                    {
                        Lista.Items.Add(c);
                    }
                }
            }
            else
            {
                MessageBox.Show("Error debe seleccionar un sexo");
            }



        }

        private void BtnFiltrarEstado_Click(object sender, EventArgs e)
        {
            if (ComboEstados.Text == "Soltero")
            {
                Lista.Items.Clear();
                foreach (Cliente c in Cliente.clientes)
                {
                    if (c.IdEcivil == 1)
                    {
                        Lista.Items.Add(c);
                    }
                }
            
        
            } else if (ComboEstados.Text == "Casado")
            {
                Lista.Items.Clear();
                foreach (Cliente c in Cliente.clientes)
                {
                    if (c.IdEcivil == 2)
                    {
                        Lista.Items.Add(c);
                    }
                }
            } else if (ComboEstados.Text == "Divorciado")
            {
                Lista.Items.Clear();
                foreach (Cliente c in Cliente.clientes)
                {
                    if (c.IdEcivil == 3)
                    {
                        Lista.Items.Add(c);
                    }
                }
            }
            else if (ComboEstados.Text == "Viudo")
            {
                Lista.Items.Clear();
                foreach (Cliente c in Cliente.clientes)
                {
                    if (c.IdEcivil == 4)
                    {
                        Lista.Items.Add(c);
                    }
                }
            }
            else
            {
                MessageBox.Show("Error debe seleccionar un estado civil");
            }
        }

        private void BtnLista_Click(object sender, EventArgs e)
        {

            /*this.Hide();
            ListadoClientes L = new ListadoClientes();
            L.ShowDialog();*/
            
            /* if (Lista.Items.Count == Cliente.clientes.Count)
            {
                MessageBox.Show("Lista actual en pantalla");
            }
            else*/
                Lista.Items.Clear();
            foreach (Cliente c in Cliente.clientes)
            {
                Lista.Items.Add(c);
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaClientes v = new VentanaClientes();
            v.ShowDialog();
        }
    }
}
