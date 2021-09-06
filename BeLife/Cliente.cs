using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeLife
{
    class Cliente
    {
        private string nombre;
        private string apellidos;
        private string rut;
        private DateTime fechaNacimiento;
        private byte idSexo; // 1= Masculino     2= Femenino
        private byte idEcivil;//1= Soltero 2=Casado 3=Divorciado 4= Viudo


        //getters y setters
        public string Nombre
        {
            get {return nombre; }
            set {this.nombre = value; }
        }

        public string Apellidos
        {
            get { return this.apellidos; }
            set { this.apellidos = value; }
        }

        public string Rut
        {
            get { return this.rut; }
            set { this.rut = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return this.fechaNacimiento; }
            set { this.fechaNacimiento = value; }
        }

        public byte IdSexo
        {
            get { return this.idSexo; }
            set { this.idSexo = value; }
        }

        public byte IdEcivil
        {
            get { return this.idEcivil; }
            set { this.idEcivil = value; }
        }



         public static List<Cliente> clientes = new List<Cliente>();




        public Cliente(string rut,string nombre, string apellidos, DateTime fechaNacimiento, byte idSexo, byte idEcivil)
        {
            this.rut = rut;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNacimiento = fechaNacimiento;
            this.idSexo = idSexo;
            this.idEcivil = idEcivil;
        }
    }
}
