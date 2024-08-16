using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.D
{
    // Implementación concreta de la dependencia (Impresora de Consola)
    public class ConsolaImpresora : IImpresora
    {
        public void Imprimir(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}
