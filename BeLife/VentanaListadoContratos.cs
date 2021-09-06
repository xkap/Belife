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
    public partial class VentanaListadoContratos : Form
    {
        public VentanaListadoContratos()
        {
            InitializeComponent();

            ComboPoliza.Items.Clear();
            ComboRut.Items.Clear();
            Lista.Items.Clear();
            ComboNumero.Items.Clear();
            Lista.DisplayMember = "NumContrato";
            Lista.ValueMember = "NumContrato";
            foreach(Contrato c in Contrato.contratos)
            {
                ComboNumero.Items.Add(c.NumContrato);
                
            }
            foreach(Plan p in Plan.planes)
            {
                ComboPoliza.Items.Add(p.PolizaActual);
            }
            foreach(Cliente c in Cliente.clientes)
            {
                ComboRut.Items.Add(c.Rut);
            }
            
        }
        private bool ValidaSeleccion()
        {
            
            if(Lista.SelectedItem != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            string estavig;// 1= Masculino     2= Femenino
            string declaracion;//1= Soltero 2=Casado 3=Divorciado 4= Viudo
            /*if (Lista.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un item");
            }*/
            if (ValidaSeleccion() == true)
            {

                if (Contrato.contratos.Find(i => Lista.GetItemText(Lista.SelectedItem) == i.NumContrato).EstaVig == true)
                {
                    estavig = "SI";
                }
                else
                {
                    estavig = "NO";
                }

                if (Contrato.contratos.Find(i => Lista.GetItemText(Lista.SelectedItem) == i.NumContrato).ConDeclaracionDeSalud == true)
                {
                    declaracion = "SI";

                }
                else
                {
                    declaracion = "NO";
                }


                LblNumeroContrato.Text = Contrato.contratos.Find(i => Lista.GetItemText(Lista.SelectedItem) == i.NumContrato).NumContrato;
                LblFechaCreacion.Text = Contrato.contratos.Find(i => Lista.GetItemText(Lista.SelectedItem) == i.NumContrato).FechaCreacion.Date.ToString();
                LblFechaTermino.Text = Contrato.contratos.Find(i => Lista.GetItemText(Lista.SelectedItem) == i.NumContrato).FechaTermino.Date.ToString();
                LblTitular.Text = Contrato.contratos.Find(i => Lista.GetItemText(Lista.SelectedItem) == i.NumContrato).Titular;
                LblPlan.Text = Contrato.contratos.Find(i => Lista.GetItemText(Lista.SelectedItem) == i.NumContrato).PlanAsociado;
                LblPoliza.Text = Contrato.contratos.Find(i => Lista.GetItemText(Lista.SelectedItem) == i.NumContrato).Poliza.ToString();
                LblInicioVig.Text = Contrato.contratos.Find(i => Lista.GetItemText(Lista.SelectedItem) == i.NumContrato).FechaInicioVig.Date.ToString();
                LblFinVig.Text = Contrato.contratos.Find(i => Lista.GetItemText(Lista.SelectedItem) == i.NumContrato).FechaTerminoVig.Date.ToString();
                LblEstaVig.Text = estavig;
                LblDeclaracionSalud.Text = declaracion;
                LblPrimaAnual.Text = Contrato.contratos.Find(i => Lista.GetItemText(Lista.SelectedItem) == i.NumContrato).PrimaAnual.ToString();
                LblPrimaMensual.Text = Contrato.contratos.Find(i => Lista.GetItemText(Lista.SelectedItem) == i.NumContrato).PrimaMensual.ToString();
                LblObservaciones.Text = Contrato.contratos.Find(i => Lista.GetItemText(Lista.SelectedItem) == i.NumContrato).Observaciones;

            }
            else
            {
                MessageBox.Show("Error debe seleccionar un item");
            }
          
        }

        private void BtnFiltrarNumero_Click(object sender, EventArgs e)
        {
            if (ComboNumero.SelectedItem == null)
            {
                MessageBox.Show("Error debe seleccionar un numero de contrato");
            }
            else
            {
                Lista.Items.Clear();
                Lista.Items.Add(ComboNumero.GetItemText(ComboNumero.SelectedItem));
                
                
                
            }
        }

        private void BtnFiltrarRut_Click(object sender, EventArgs e)
        {
            if (ComboRut.SelectedItem == null)
            {
                MessageBox.Show("Error debe seleccionar un Rut");
            }
            else
            {
                Lista.Items.Clear();
                foreach(Contrato c in Contrato.contratos)
                {
                    if(c.Titular == ComboRut.GetItemText(ComboRut.SelectedItem))
                    {
                        Lista.Items.Add(c.NumContrato);
                        //Lista.Items.Add(Contrato.contratos.Find(i=> i.Titular == ComboRut.GetItemText(ComboRut.SelectedItem)).NumContrato);
                    }
                }
                



            }
        }

        private void BtnFiltrarPoliza_Click(object sender, EventArgs e)
        {
            if (ComboPoliza.SelectedItem == null)
            {
                MessageBox.Show("Error debe seleccionar una Poliza");
            }
            else
            {
                Lista.Items.Clear();
                foreach(Contrato c in Contrato.contratos)
                {
                    if(c.Poliza.ToString() == ComboPoliza.GetItemText(ComboPoliza.SelectedItem))
                    {
                        Lista.Items.Add(c.NumContrato);
                        //Lista.Items.Add(Contrato.contratos.Find(i => i.Poliza.ToString() == ComboPoliza.GetItemText(ComboPoliza.SelectedItem)).NumContrato);
                    }
                }
                
                


            }

        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaContratos v = new VentanaContratos();
            v.ShowDialog();
        }
    }
}
