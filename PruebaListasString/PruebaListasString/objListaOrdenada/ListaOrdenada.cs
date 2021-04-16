using PruebaListasString.ListaString;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaListasString.objListaOrdenada
{
    class ListaOrdenada : Lista
    {

        public ListaOrdenada()

             : base()
        {
            
        }

        public ListaOrdenada insertaOrden(string entrada)
        {
            Nodo nuevo;
            nuevo = new Nodo(entrada);
            if (primero == null)
            {
                primero = nuevo;

            }
            else if (entrada.CompareTo(primero.getDatos()) < 0)
            {
                nuevo.setEnlcae(primero);
                primero = nuevo;

            }
            else
            {
                Nodo anterior, p;
                anterior = p = primero;
                while ((p.getEnlace() != null) && (entrada.CompareTo( p.getDatos())>0))
                {
                    anterior = p;
                    p = p.getEnlace();

                }
                if (entrada.CompareTo(p.getDatos())>0)
                {
                    anterior = p;
                }
                nuevo.setEnlcae(anterior.getEnlace());
                anterior.setEnlcae(nuevo);
            }
            return this;
        }
    }
}
