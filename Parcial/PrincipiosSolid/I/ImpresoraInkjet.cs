using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.I
{
    // Clase ImpresoraInkjet que implementa solo las interfaces necesarias
    public class ImpresoraInkjet : ImprimirDocumento, ImprimirImagen, ImprimirCodigoBarras
    {
        public void ImprimirDocumento(string documento)
        {
            Console.WriteLine("Imprimiendo documento con tinta...");
        }

        public void ImprimirImagen(string imagen)
        {
            Console.WriteLine("Imprimiendo imagen con tinta...");
        }

        public void ImprimirCodigoBarras(string codigoBarras)
        {
            Console.WriteLine("Imprimiendo código de barras con tinta...");
        }
    }
}
