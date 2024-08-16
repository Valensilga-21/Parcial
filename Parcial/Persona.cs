using Parcial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    //1. Clase y Atributos
    public class Persona : Empleado
    {
        //Atributos Nombre,Edad y Direccion
        public string Nombre { get; set; }
        public int Edad {  get; set; }
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

        //constructor sin parametros
        public Persona()
        {
            Nombre = "Valentina";
            Edad = 18;
            Direccion = "Cll 2B sur 2-51";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Persona persona = new Persona();
        Console.WriteLine(persona.Nombre);
        Console.WriteLine(persona.Edad);
        Console.WriteLine(persona.Direccion);
    }
}
