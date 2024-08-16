using PrincipiosSolid.D;
using PrincipiosSolid.I;
using PrincipiosSolid.L;
using PrincipiosSolid.O;
using PrincipiosSolid.S;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Principio de responsabilidad única");
            Console.WriteLine("----------------------------------");
            OperacionesMatematicas operaciones = new OperacionesMatematicas();
            ImpresoraDeResultados impresora = new ImpresoraDeResultados();
            Calculadora calculadora = new Calculadora(operaciones, impresora);

            calculadora.realizarOperacion(15, 5, "sumar");
            calculadora.realizarOperacion(23, 5, "restar");

            Console.WriteLine("Principio abierto/cerrado");
            Console.WriteLine("----------------------------------");
            Circulo circulo = new Circulo(5.0);
            Rectangulo rectangulo = new Rectangulo(4.0, 6.0);

            Console.WriteLine("Área del círculo: " + circulo.calcularArea());
            Console.WriteLine("Área del rectángulo: " + rectangulo.calcularArea());

            Console.WriteLine("Principio de sustitución Liscov");
            Console.WriteLine("----------------------------------");
            var zoo = new Zoo();
            
            var Leon = new Leon();
            var Elefante = new Elefante();

            zoo.HacerSonar(Leon);
            zoo.HacerSonar(Elefante);

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Principio de Segregación de Interfaces");
            Console.WriteLine("----------------------------------");
            // Crear instancias de las clases que implementan las interfaces

            ImpresoraLaser laserPrinter = new ImpresoraLaser();
            ImpresoraInkjet inkjetPrinter = new ImpresoraInkjet();
            ImpresoraTermica thermalPrinter = new ImpresoraTermica();

            // Utilizar las interfaces para imprimir documentos
            ImprimirDocumento documentPrinter = laserPrinter;
            documentPrinter.ImprimirDocumento("Documento de prueba");

            documentPrinter = inkjetPrinter;
            documentPrinter.ImprimirDocumento("Documento de prueba");

            // Utilizar las interfaces para imprimir imágenes
            ImprimirImagen imagePrinter = laserPrinter;
            imagePrinter.ImprimirImagen("Imagen de prueba");

            imagePrinter = inkjetPrinter;
            imagePrinter.ImprimirImagen("Imagen de prueba");

            // Utilizar las interfaces para imprimir códigos de barras
            ImprimirCodigoBarras barcodePrinter = inkjetPrinter;
            barcodePrinter.ImprimirCodigoBarras("Código de barras de prueba");

            // Utilizar las interfaces para imprimir etiquetas
            ImprimirEtiqueta labelPrinter = thermalPrinter;
            labelPrinter.ImprimirEtiqueta("Etiqueta de prueba");

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Principio de inversión de dependencias");
            Console.WriteLine("----------------------------------");

            Documento doc1 = new Documento(new ConsolaImpresora());
            doc1.Imprimir(); 
            Documento doc2 = new Documento(new ArchivoImpresora());
            doc2.Imprimir();

            Console.ReadLine();

        }
    }
}
