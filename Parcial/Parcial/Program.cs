using Parcial.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Persona persona = new Persona("Juan", 30, "Calle 123");
            //await
            persona.MostrarInformacion();

            Console.WriteLine("----------------------------");

            Console.WriteLine($"Digite su nombre");
            string nombre = (Console.ReadLine());
            Console.WriteLine($"Digite su edad");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine($"Digite su direccion");
            string direccion = (Console.ReadLine());
            Console.WriteLine($"Digite su salario");
            double salario = double.Parse(Console.ReadLine());

            Empleado empleado = new Empleado(nombre,edad,direccion,salario);
            await empleado.LeerDatosAsync();
        }
    }
}
