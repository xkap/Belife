using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeLife
{
    class Contrato
    {
        private string numContrato;
        private DateTime fechaCreacion;
        private DateTime fechaTermino;
        private string titular;
        private string planasociado;
        private int poliza;
        private DateTime fechaInicioVig;
        private DateTime fechaTerminoVig;
        private bool estaVig;
        private bool conDeclaracionDeSalud;
        private double primaAnual;
        private double primaMensual;
        private string observaciones;


        //getters y setters
        public string NumContrato
        {
            get { return this.numContrato; }
            set { this.numContrato = value; }
        }

        public DateTime FechaCreacion
        {
            get { return this.fechaCreacion; }
            set { this.fechaCreacion = value; }
        }

        public DateTime FechaTermino
        {
            get { return this.fechaTermino; }
            set { this.fechaTermino = value; }
        }

        public string Titular
        {
            get { return this.titular; }
            set { this.titular = value; }
        }

        public string PlanAsociado
        {
            get { return this.planasociado; }
            set { this.planasociado = value; }
        }

        public int Poliza
        {
            get { return this.poliza; }
            set { this.poliza = value; }
        }

        public DateTime FechaInicioVig
        {
            get { return this.fechaInicioVig; }
            set { this.fechaInicioVig = value; }
        }

        public DateTime FechaTerminoVig
        {
            get { return this.fechaTerminoVig; }
            set { this.fechaTerminoVig = value; }
        }

        public bool EstaVig
        {
            get { return this.estaVig; }
            set { this.estaVig = value; }
        }

        public bool ConDeclaracionDeSalud
        {
            get { return this.conDeclaracionDeSalud; }
            set { this.conDeclaracionDeSalud = value; }
        }

        public double PrimaAnual
        {
            get { return this.primaAnual; }
            set { this.primaAnual = value; }
        }

        public double PrimaMensual
        {
            get { return this.primaMensual; }
            set { this.primaMensual = value; }
        }

        public string Observaciones
        {
            get { return this.observaciones; }
            set { this.observaciones = value; }
        }





        public Contrato(string numContrato, DateTime fechaCreacion, DateTime fechaTermino, string titular,
                string planasociado, int poliza, DateTime fechaInicioVig, DateTime fechaTerminoVig,
                bool EstaVig, bool conDeclaracionDeSalud, double primaAnual, double primaMensual, string observaciones)
        {
            this.numContrato = numContrato;
            this.fechaCreacion = fechaCreacion;
            this.fechaTermino = fechaTermino;
            this.titular = titular;
            this.planasociado = planasociado;
            this.poliza = poliza;
            this.fechaInicioVig = fechaInicioVig;
            this.fechaTerminoVig = fechaTerminoVig;
            this.EstaVig = EstaVig;
            this.conDeclaracionDeSalud = conDeclaracionDeSalud;
            this.primaAnual = primaAnual;
            this.primaMensual = primaMensual;
            this.observaciones = observaciones;
        }




        public static List<Contrato> contratos = new List<Contrato>();
    }
}