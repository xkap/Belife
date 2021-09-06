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
    public partial class VentanaBuscarContrato : Form
    {
        public VentanaBuscarContrato()
        {
            InitializeComponent();
            PanelResultados.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaContratos v = new VentanaContratos();
            v.ShowDialog();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            string estavig;
            string declaracion;
            if(Contrato.contratos.Exists(i=> i.NumContrato == TxtNumero.Text))
            {
                PanelResultados.Show();

                if (Contrato.contratos.Find(i => TxtNumero.Text == i.NumContrato).EstaVig == true)
                {
                    estavig = "SI";
                }
                else
                {
                    estavig = "NO";
                }

                if (Contrato.contratos.Find(i => TxtNumero.Text == i.NumContrato).ConDeclaracionDeSalud == true)
                {
                    declaracion = "SI";

                }
                else
                {
                    declaracion = "NO";
                }

                LblNumeroContrato.Text = Contrato.contratos.Find(i => TxtNumero.Text == i.NumContrato).NumContrato;
                LblFechaCreacion.Text = Contrato.contratos.Find(i => TxtNumero.Text == i.NumContrato).FechaCreacion.Date.ToString();
                LblFechaTermino.Text = Contrato.contratos.Find(i => TxtNumero.Text == i.NumContrato).FechaTermino.Date.ToString();
                LblTitular.Text = Contrato.contratos.Find(i => TxtNumero.Text == i.NumContrato).Titular;
                LblPlan.Text = Contrato.contratos.Find(i => TxtNumero.Text == i.NumContrato).PlanAsociado;
                LblPoliza.Text = Contrato.contratos.Find(i => TxtNumero.Text == i.NumContrato).Poliza.ToString();
                LblInicioVig.Text = Contrato.contratos.Find(i => TxtNumero.Text == i.NumContrato).FechaInicioVig.Date.ToString();
                LblFinVig.Text = Contrato.contratos.Find(i => TxtNumero.Text == i.NumContrato).FechaTerminoVig.Date.ToString();
                LblEstaVig.Text = estavig;
                LblDeclaracionSalud.Text = declaracion;
                LblPrimaAnual.Text = Contrato.contratos.Find(i => TxtNumero.Text == i.NumContrato).PrimaAnual.ToString();
                LblPrimaMensual.Text = Contrato.contratos.Find(i => TxtNumero.Text == i.NumContrato).PrimaMensual.ToString();
                LblObservaciones.Text = Contrato.contratos.Find(i => TxtNumero.Text == i.NumContrato).Observaciones;



            }
            else
            {
                MessageBox.Show("El contrato no existe");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblNumeroContrato_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PanelResultados.Hide();
        }
    }
}
