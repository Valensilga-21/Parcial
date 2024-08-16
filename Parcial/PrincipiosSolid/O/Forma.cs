using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.O
{
    public abstract class Forma
    {
        public abstract double calcularArea();
    }

    public class Circulo : Forma
    {
        private double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public override double calcularArea()
        {
            
            return Math.PI * radio * radio;
        }
    }

    public class Rectangulo : Forma
    {
        private double ancho;
        private double alto;

        public Rectangulo(double ancho, double alto)
        {
            this.ancho = ancho;
            this.alto = alto;
        }

        public override double calcularArea()
        {
            return ancho * alto;
        }
    }
}
