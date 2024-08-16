using Parcial.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Object;

namespace Parcial.models
{
    public class Empleado : Persona, ICalculable
    {
        public double Salario { get; set; }
        public int DiasTrabajados { get; set; }

        public Empleado(string nombre, int edad, string direccion, double salario)
            : base(nombre, edad, direccion)
        {
            Salario = salario;
            DiasTrabajados = 0;
        }

        //Metodo calcular salario
        public double CalcularSalarioDiario()
        {
            return Salario / 30;
        }

        public double CalcularSalarioPorDiasTrabajo()
        {
            return CalcularSalarioDiario() * DiasTrabajados;
        }

        public void agregarDiasTrabajados(int Dias)
        {
            DiasTrabajados += Dias;
        }
        public void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Salario: {Salario}");
            Console.WriteLine($"Días Trabajados: {DiasTrabajados}");
            Console.WriteLine($"Salario por los días trabajados: {CalcularSalarioPorDiasTrabajo():F2}");
        }

        public async Task LeerDatosAsync()
        {
            
            Console.WriteLine($"Digita el numero de días trabajados");
            DiasTrabajados = int.Parse( Console.ReadLine());
            if (DiasTrabajados >=0 && DiasTrabajados <= 30)
            {
                Console.WriteLine("Leyendo datos...");
                Console.WriteLine("----------------------------");
                await Task.Delay(5000);
                MostrarInformacion();
            }else
            {
                Console.WriteLine("El dato ingresado es invalido");
            }
            
        }
    }
}
