using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Clases
{
    class Paciente : Persona
    {
        private int edad;
        private DateTime fechaBaja;
        private string nombre;
        public Paciente(int _edad, DateTime _fechaBaja, string _nombre) : base(_edad, _nombre)
        {
            nombre = _nombre;
            edad = _edad;
            fechaBaja = _fechaBaja;

        }
        public string getNombre() { return nombre; }

        public int getEdad() { return edad; }

        public void setEdad(int newEdad) { edad = newEdad; }
        public void setNombre(string newNombre) { nombre = newNombre; }
        public override string ToString()
        {
            return base.ToString() + $" es un paciente";
        }

    }
}