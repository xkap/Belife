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
    public partial class VentanaCrearContrato : Form
    {
        public VentanaCrearContrato()
        {
            InitializeComponent();
            ComboTitular.Items.Clear();
            foreach(Cliente c in Cliente.clientes)
            {
                ComboTitular.Items.Add(c.Rut);
            }

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

            ComboPoliza.Items.Clear();
            foreach (Plan p in Plan.planes)
            {
                
                ComboPoliza.Items.Add(p.PolizaActual);
            }

            RadioSi.Checked = true;
        }


        private bool ValidaInicio(DateTime d)
        {
            DateTime hoy = DateTime.Today;
            DateTime maxmes; //var para sacar la condicion de la fecha de inicio que sea max 1 mes dsps de la actual
            if (DateTime.Now.Year == 12)//si es el mes 12 le sumo 1 año y el mes que sea el 1, sino quedaria como 13
            {
                maxmes = new DateTime(DateTime.Now.Year+1, 1, DateTime.Now.Day);
            }
            else //si no, basta con sumarle un mes
            {
                maxmes = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);
            }
            
            if(DateTime.Compare(hoy,d)<=0 && DateTime.Compare(d,maxmes)<=0)
            {//aquí comparo las fechas con el método compare, diciendo que la fecha de inicio de vigencia
                //debe ser mayor o igual a la de hoy y menor a 1 mes desde hoy.
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public string getMes()
        {
            string x;
            if (DateTime.Now.Month < 10)
            {
                x = "0" + DateTime.Now.Month;
            }
            else
            {
                x = DateTime.Now.Month.ToString();
            }
            return x;
        }

        public string getDia()
        {
            string x;
            if (DateTime.Now.Day < 10)
            {
                x = "0" + DateTime.Now.Day;
            }
            else
            {
                x = DateTime.Now.Day.ToString();
            }
            return x;
        }

        public string getHora()
        {
            string x;
            if (DateTime.Now.Hour < 10)
            {
                x = "0" + DateTime.Now.Hour;
            }
            else
            {
                x = DateTime.Now.Hour.ToString();
            }
            return x;
        }
        public string getMin()
        {
            string x;
            if (DateTime.Now.Minute < 10)
            {
                x = "0" + DateTime.Now.Minute;
            }
            else
            {
                x = DateTime.Now.Minute.ToString();
            }
            return x;
        }

        public string getSeg()
        {
            string x;
            if (DateTime.Now.Second < 10)
            {
                x = "0" + DateTime.Now.Second;
            }
            else
            {
                x = DateTime.Now.Second.ToString();
            }
            return x;
        }

        private bool ValidaTitular()
        {
            
            if (ComboTitular.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private int CalcularEdad(DateTime f, DateTime Fecha)
        {
            int years = DateTime.Now.Year - Fecha.Date.Year;
            if (Fecha.Month > DateTime.Now.Month)
            {
                years--;
            }
            if (Fecha.Month == DateTime.Now.Month && Fecha.Day > DateTime.Now.Day)
            {
                years--;
            }
            return years;
        }

        private double CalculaRecargoEdad()
        {
            double recargo = 0;
            if (ValidaTitular() == false)
            {
                MessageBox.Show("Debe seleccionar un titular");
                return 0;
            }
            else if (CalcularEdad(DateTime.Now, Cliente.clientes.Find(i => i.Rut == ComboTitular.Text).FechaNacimiento) >= 18
                && CalcularEdad(DateTime.Now, Cliente.clientes.Find(i => i.Rut == ComboTitular.Text).FechaNacimiento) <= 25)
            {
                recargo += 3.6;
                return recargo;

            }
            else if (CalcularEdad(DateTime.Now, Cliente.clientes.Find(i => i.Rut == ComboTitular.Text).FechaNacimiento) >= 26
               && CalcularEdad(DateTime.Now, Cliente.clientes.Find(i => i.Rut == ComboTitular.Text).FechaNacimiento) <= 45)
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
            if (ValidaTitular() == false)
            {
                
                return 0;
            }
            else if (Cliente.clientes.Find(i => i.Rut == ComboTitular.Text).IdSexo == 1)
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
            if (ValidaTitular() == false)
            {
                
                return 0;
            }
            else if (Cliente.clientes.Find(i => i.Rut == ComboTitular.Text).IdEcivil == 1)
            {
                recargo += 4.8;
                return recargo;

            }
            else if (Cliente.clientes.Find(i => i.Rut == ComboTitular.Text).IdEcivil == 2)
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

        private void VentanaCrearContrato_Load(object sender, EventArgs e)
        {

        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            

            DateTime inivig=DateTime.Today;//se le parte asignanado esto pq no acepta nulos, sería cm un null
            DateTime finvig=DateTime.Today;//se le parte asignanado esto pq no acepta nulos, sería cm un null
            string numcontrato=DateTime.Now.Year.ToString() + getMes() +getDia() + getHora() + getMin() + getSeg();
            /*NUMCONTRATO obtenido con métodos que capturan partes de la fecha x separado y le agregan un 0 dependiendo
            else valor de estas partes*/
            DateTime feccreacion = DateTime.Now;
            DateTime fectermino=DateTime.Today;//se le parte asignanado esto pq no acepta nulos, sería cm un null
            bool estavig=true;//se le parte asignanado esto pq no acepta nulos, sería cm un null
            double recargo = CalculaRecargoEdad() + CalculaRecargoSexo() + CalculaRecargoEstado();
            double primaanual=0;
            double primamensual=0;
            bool declarasalud=true;//se le parte asignanado esto pq no acepta nulos, sería cm un null
            string observacion="";
            int poliza;


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
            if (ValidaInicio(FecIniVig.Value.Date))
            {
                
                inivig = FecIniVig.Value.Date;
                finvig = new DateTime(FecIniVig.Value.Year + 1, FecIniVig.Value.Month, FecIniVig.Value.Day);
                fectermino = finvig;
                LblNumContrato.Text = numcontrato;
                
            }
            else
            {

                
                MessageBox.Show("Fecha de inicio de vigencia INCORRECTA");
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
            if (ComboPoliza.Text == "")
            {
                poliza = 0;
                MessageBox.Show("Seleccione una Póliza por favor");
            }
            else
            {
                poliza = int.Parse(ComboPoliza.SelectedItem.ToString());
            }


            //if para que todo esté correcto
            if (Contrato.contratos.Exists(i => i.NumContrato == numcontrato))
            {
                MessageBox.Show("El contrato ya existe");
            }
            else if((recargo > 0 && ComboPlan.Text != "" && ValidaInicio(FecIniVig.Value.Date)) && ComboPoliza.Text != ""
               && TxtObservaciones.Text != "")
            {
                
                Contrato.contratos.Add(new Contrato(numcontrato, feccreacion, fectermino, ComboTitular.Text, ComboPlan.Text,
                    poliza, inivig, finvig, estavig, declarasalud, primaanual, primamensual, observacion));
                MessageBox.Show("Contrato añadido");
            }
            
            

            
        }

        private void FecIniVig_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaContratos v = new VentanaContratos();
            v.ShowDialog();
        }
    }
}
