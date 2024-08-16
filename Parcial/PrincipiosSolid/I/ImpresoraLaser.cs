using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.I
{
    // Clase ImpresoraLaser que implementa solo las interfaces necesarias
    public class ImpresoraLaser : ImprimirDocumento, ImprimirImagen
    {
        public void ImprimirDocumento(string documento)
        {
            Console.WriteLine("Imprimiendo documento con láser...");
        }

        public void ImprimirImagen(string imagen)
        {
            Console.WriteLine("Imprimiendo imagen con láser...");
        }
    }
}
