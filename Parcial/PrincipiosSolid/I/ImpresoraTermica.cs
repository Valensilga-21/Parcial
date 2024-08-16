using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.I
{
    // Clase ImpresoraTermica que implementa solo las interfaces necesarias
    public class ImpresoraTermica : ImprimirEtiqueta
    {
        public void ImprimirEtiqueta(string etiqueta)
        {
            Console.WriteLine("Imprimiendo etiqueta con térmica...");
        }
    }
}
