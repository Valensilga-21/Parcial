using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.L
{

    // Aplicando LSP (Principio de sustitución Liscov)
    public abstract class Animal
    {
        //Metodo sonido
        public abstract void Sonido();
    }

    //La clase Leon hereda el método de Animal
    public class Leon : Animal
    {

        public override void Sonido()
        {
            
            Console.WriteLine("El león ruge");
        }
    }

    //La clase Elefante hereda el método de Animal
    public class Elefante : Animal
    {
        public override void Sonido()
        {
            Console.WriteLine("El elefante trompetea");
        }
    }

    public class Zoo
    {
        public void HacerSonar(Animal animal)
        {
            animal.Sonido();
        }
    }
}
