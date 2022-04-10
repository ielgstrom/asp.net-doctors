using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Clases
{
    class Persona
    {
        int edad;
        private string nombre;
        public List<Persona> listaPersonas = new List<Persona>();


        public Persona(int _edad, string _nombre)
        {
            edad = _edad;
            nombre = _nombre;

        }
        public override string ToString()
        {
            return $"{nombre} tiene {edad} años";
        }
    }
}