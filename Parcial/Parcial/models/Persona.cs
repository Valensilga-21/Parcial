using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.models
{
    public class Persona
    {
        //Atributos Nombre,Edad y Direccion
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }

        //Metodo mostrar informacion
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Dirección: {Direccion}");
        }

        //constructor 
        public Persona(string nombre, int edad, string direccion)
        {
            Nombre = nombre;
            Edad = edad;
            Direccion = direccion;
        }

        //constructor sin parámetros
        public Persona()
        {
            Nombre = "Carlos Julio";
            Edad = 30;
            Direccion = "Calle 678B";
        }

    }
}
