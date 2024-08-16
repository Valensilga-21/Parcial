using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.S
{
    public class Calculadora
    {
        private OperacionesMatematicas operaciones;
        private ImpresoraDeResultados impresora;

        public Calculadora(OperacionesMatematicas operaciones, ImpresoraDeResultados impresora)
        {
            this.operaciones = operaciones;
            this.impresora = impresora;
        }

        public void realizarOperacion(int a, int b, String operacion)
        {
            int resultado = 0;
            if (operacion.Equals("sumar"))
            {
                resultado = operaciones.sumar(a, b);
            }
            else if (operacion.Equals("restar"))
            {
                resultado = operaciones.restar(a, b);
            }
            impresora.imprimirResultado(resultado);
        }
    }

    public class OperacionesMatematicas
    {
        public int sumar(int a, int b)
        {
            return a + b;
        }

        public int restar(int a, int b)
        {
            return a - b;
        }
    }

    public class ImpresoraDeResultados
    {
        public void imprimirResultado(int resultado)
        {
            Console.WriteLine("El resultado es: " + resultado);
        }
    }
}
