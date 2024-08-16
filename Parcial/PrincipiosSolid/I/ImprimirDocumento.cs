using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.I
{
    //Interface ImprimirDocumento
    public interface ImprimirDocumento
    {
        void ImprimirDocumento(string documento);
    }

    //Interface ImprimirImagen
    public interface ImprimirImagen
    {
        void ImprimirImagen(string imagen);
    }

    //Interface ImprimirCodigoBarras
    public interface ImprimirCodigoBarras
    {
        void ImprimirCodigoBarras(string codigoBarras);
    }

    //Interface ImprimirEtiqueta
    public interface ImprimirEtiqueta
    {
        void ImprimirEtiqueta(string etiqueta);
    }
}
