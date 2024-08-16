using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.D
{
    public class Documento
    {
        private readonly IImpresora _impresora;

        public Documento(IImpresora impresora)
        {
            _impresora = impresora;
        }

        public void Imprimir()
        {
            _impresora.Imprimir("Imprimiendo un documento...");
        }
    }
}
