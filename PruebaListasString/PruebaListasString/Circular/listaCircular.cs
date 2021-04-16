using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaListasString.Circular
{
    class listaCircular
    {
        public NodoC lc;
        public int info;

        public listaCircular()
        {
            lc = null;
        }

        public listaCircular insertar(String entrada)
        {
            NodoC nuevo;
            nuevo = new NodoC(entrada);
            if (lc != null) // lista circular no vacía
            {
                nuevo.enlace = lc.enlace;
                lc.enlace = nuevo;
            }
            lc = nuevo;
            return this;
        }
        public listaCircular insertaDespues(NodoC anterior, String entrada)//Cambie tipo de dato a String
        {
            NodoC nuevo;
            nuevo = new NodoC(entrada);
            nuevo.dato = anterior.dato;
            if (anterior.dato != null)
            {


                anterior.enlace.dato = nuevo.dato;
            }
            anterior.dato = nuevo.dato;
            nuevo.enlace.dato = anterior.enlace.dato;
            return this;

        }

        public void eliminar(String entrada)
        {
            NodoC actual;
            actual = lc;
            while ((actual.enlace != lc) && !(actual.enlace.dato.Equals(entrada)))
            {
                if (!actual.enlace.dato.Equals(entrada))
                {
                    actual = actual.enlace;
                }
            }
            // Enlace de nodo anterior con el siguiente
            // si se ha encontrado el nodo.
            if (actual.enlace.dato.Equals(entrada))
            {
                NodoC p;
                p = actual.enlace; // Nodo a eliminar
                if (lc == lc.enlace) // Lista con un solo nodo
                {
                    lc = null;
                }
                else
                {
                    if (p == lc)
                    {
                        lc = actual; // Se borra el elemento referenciado por lc,   
                                     // el nuevo acceso a la lista es el anterior
                    }
                    actual.enlace = p.enlace;
                }
                p = null;
            }
        }

       

        public void borrarLista()
        {
            NodoC p;
            if (lc != null)
            {
                p = lc;
                do
                {
                    NodoC t;
                    t = p;
                    p = p.enlace;
                    t = null; // no es estrictamente necesario
                } while (p != lc);
            }
            else
            {
                Console.WriteLine("\n\t Lista vacía.");
            }
            lc = null;
        }

        public void recorrer()
        {
            NodoC p;
            if (lc != null)
            {
                p = lc.enlace; // siguiente nodo al de acceso
                do
                {
                    Console.WriteLine("\t" + p.dato);
                    p = p.enlace;
                } while (p != lc.enlace);
            }
            else
            {
                Console.WriteLine("\t Lista Circular vacía.");
            }
        }

    }
}
