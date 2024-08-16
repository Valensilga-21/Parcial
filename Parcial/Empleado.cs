using Parcial.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    public class Empleado : ICalculable
    {
        public string Nombre {  get; set; }
        public int Edad {  get; set; }
        public string Direccion { get; set; }
        public double Salario { get; set; }

        public void CalcularSalario()
        {
            Salario *= 1.10;
        }
        public void MostarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Dirección: {Direccion}");
            Console.WriteLine($"Salario: {Salario}");
        }
    }
}
