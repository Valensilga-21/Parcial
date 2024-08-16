using PrincipiosSolid.D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ArchivoImpresora : IImpresora
{
    public void Imprimir(string mensaje)
    {
        // Código para escribir a un archivo
        Console.WriteLine("Escribiendo a un archivo: " + mensaje);
    }
}
