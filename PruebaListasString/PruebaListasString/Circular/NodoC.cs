using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaListasString.Circular
{
    class NodoC
    {

        public String dato;
        public NodoC enlace;

        public NodoC(String entrada)
        {
            dato = entrada;
            enlace = this; // se apunta asímismo

        }
    }
}
