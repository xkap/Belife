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
    public partial class VentanaModificarContrato : Form
    {
        public VentanaModificarContrato()
        {
            InitializeComponent();
            PanelResultados.Hide();
            

            if (Plan.planes.Count < 3)
            {
                Plan.planes.Add(new Plan(1, "Plan 1", 15, 10)); //precios en UF
                Plan.planes.Add(new Plan(2, "Plan 2", 21, 20));
                Plan.planes.Add(new Plan(3, "Plan 3", 28, 30));
            }

            ComboPlan.Items.Clear();
            foreach (Plan p in Plan.planes)
            {
                ComboPlan.Items.Add(p.Nombre);
            }

           

            RadioSi.Checked = true;
        }

        private int CalcularEdad(DateTime f, DateTime Fecha)
        {
            int years = DateTime.Now.Year - Fecha.Date.Year;
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

        private double CalculaRecargoEdad()
        {
            double recargo = 0;
            if (CalcularEdad(DateTime.Now, Cliente.clientes.Find(i => i.Rut == LblTitular.Text).FechaNacimiento) >= 18
                && CalcularEdad(DateTime.Now, Cliente.clientes.Find(i => i.Rut == LblTitular.Text).FechaNacimiento) <= 25)
            {
                recargo += 3.6;
                return recargo;

            }
            else if (CalcularEdad(DateTime.Now, Cliente.clientes.Find(i => i.Rut == LblTitular.Text).FechaNacimiento) >= 26
               && CalcularEdad(DateTime.Now, Cliente.clientes.Find(i => i.Rut == LblTitular.Text).FechaNacimiento) <= 45)
            {
                recargo += 2.4;
                return recargo;

            }
            else
            {
                recargo += 6.0;
                return recargo;

            }
        }

        private double CalculaRecargoSexo()
        {
            double recargo = 0;
            if (Cliente.clientes.Find(i => i.Rut == LblTitular.Text).IdSexo == 1)
            {
                recargo += 2.4;
                return recargo;

            }
            else
            {
                recargo += 1.2;
                return recargo;

            }
        }

        private double CalculaRecargoEstado()
        {
            double recargo = 0;
            if (Cliente.clientes.Find(i => i.Rut == LblTitular.Text).IdEcivil == 1)
            {
                recargo += 4.8;
                return recargo;

            }
            else if (Cliente.clientes.Find(i => i.Rut == LblTitular.Text).IdEcivil == 2)
            {
                recargo += 2.4;
                return recargo;

            }
            else
            {
                recargo += 3.6;
                return recargo;

            }
        }


        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if(Contrato.contratos.Exists(i=> i.NumContrato == TxtNumero.Text) == false ||
                Contrato.contratos.Find(i => i.NumContrato == TxtNumero.Text).EstaVig==false)
            {
                MessageBox.Show("Error el contrato no existe o no está vigente");
            }
            else
            {
                PanelResultados.Show();
                LblNumContrato.Text = Contrato.contratos.Find(i => i.NumContrato == TxtNumero.Text).NumContrato;
                LblTitular.Text = Contrato.contratos.Find(i => i.NumContrato == TxtNumero.Text).Titular;
                LblPoliza.Text = Contrato.contratos.Find(i => i.NumContrato == TxtNumero.Text).Poliza.ToString();
                LblIniVig.Text=Contrato.contratos.Find(i => i.NumContrato == TxtNumero.Text).FechaInicioVig.Date.ToString();
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaContratos v = new VentanaContratos();
            v.ShowDialog();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            double recargo = CalculaRecargoEdad() + CalculaRecargoSexo() + CalculaRecargoEstado();
            double primaanual = 0;
            double primamensual = 0;
            bool declarasalud = true;//se le parte asignanado esto pq no acepta nulos, sería cm un null
            string observacion = "";
            


            if (recargo > 0 && ComboPlan.Text != "")
            {
                primaanual = Plan.planes.Find(i => i.Nombre == ComboPlan.Text).PrimaBase + recargo;
                primamensual = primaanual / 12;
                LblPrimaAnual.Text = primaanual.ToString();
                LblPrimaMensual.Text = primamensual.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione un plan por favor");
            }

        
            if (RadioSi.Checked == true)
            {
                declarasalud = true;
            }
            else
            {
                declarasalud = false;
            }
            if (TxtObservaciones.Text == "")
            {
                MessageBox.Show("Ingrese una observación por favor");
            }
            else
            {
                observacion = TxtObservaciones.Text;
            }

            if (recargo > 0 && ComboPlan.Text != "" && TxtObservaciones.Text != "")
            {

                Contrato.contratos.Find(i => i.NumContrato == TxtNumero.Text).PlanAsociado = ComboPlan.Text;
                Contrato.contratos.Find(i => i.NumContrato == TxtNumero.Text).ConDeclaracionDeSalud = declarasalud;
                Contrato.contratos.Find(i => i.NumContrato == TxtNumero.Text).Observaciones = TxtObservaciones.Text;
                Contrato.contratos.Find(i => i.NumContrato == TxtNumero.Text).PrimaAnual = primaanual;
                Contrato.contratos.Find(i => i.NumContrato == TxtNumero.Text).PrimaMensual = primamensual;
                MessageBox.Show("Contrato Modificado");
                TxtObservaciones.Text = "";
                ComboPlan.SelectedItem = null;
                RadioSi.Checked = true;
                PanelResultados.Hide();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PanelResultados.Hide();
        }
    }
}

