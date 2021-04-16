using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaListasString.ListaString
{
    class Lista
    {


        public Nodo primero;

        public Lista()
        {
            primero = null;
        }

        //private int leerEntero()

        //{

        //    Console.WriteLine("Ingrese Valor, -1 para finalizar");
        //    return Convert.ToInt32(Console.ReadLine());
        //}

        //public Lista crearLista()
        //{

        //    int x;
        //    primero = null;
        //    do
        //    {

        //        x = leerEntero();
        //        if (x != -1)
        //        {
        //            primero = new Nodo(x, primero);
        //        }
        //    } while (x != -1);
        //    return this;

        //}

        ////Nuevos metodos
        //public Nodo buscarPosicion(int posicion)
        //{
        //    Nodo indice;
        //    int i;
        //    if (posicion<0)
        //    {
        //        return null;

        //    }
        //    indice = primero;
        //    for (i = 1; (i < posicion) && (indice != null); i++)
        //    {
        //        indice = indice.enlace;
        //    }
        //    return indice;
        //}

        ////Insertar de ultimo
        //public Lista insertarUltimo(Nodo ultimo, string entrada)
        //{
        //    ultimo.enlace = new Nodo(entrada);
        //    ultimo = ultimo.enlace;
        //    return this;
        //}

        //public Lista insertarCabeza(Nodo cabeza, int valor)
        //{
        //    cabeza.enlace = new Nodo(valor);
        //    cabeza = cabeza.enlace;
        //    return this;
        //}

        //public Nodo buscarLista(int destino)
        //{
        //    Nodo indice;
        //    for (indice = primero; indice != null; indice = indice.enlace)
        //    {
        //        if (destino == indice.dato)
        //        {
        //            return indice;
        //        }
        //    }
        //    return null;
        //}

        //public void eliminar(int entrada)
        //{
        //    Nodo actual, anterior;
        //    bool encontrado;
        //    //inicializa os apuntadores
        //    actual = primero;
        //    anterior = null;
        //    encontrado = false;
        //    //Busqueda del nodo anterior
        //    while ((actual != null) && (!encontrado))
        //    {
        //        encontrado = (actual.dato == entrada);
        //        if (!encontrado)
        //        {
        //            anterior = actual;
        //            actual = actual.enlace;
        //        }
        //    }//Find While
        //     //enlace Nodo anterior con el siguiente
        //    if (actual != null)
        //    {
        //        //Distinguir si el Nodo inicial o cabeza 
        //        if (actual == primero)
        //        {
        //            primero = actual.enlace;
        //        }
        //        else
        //        {
        //            anterior.enlace = actual.enlace;
        //        }
        //        actual = null;
        //    }
        //}
        //public Lista insertarLista(int testigo, int entrada)
        //{
        //    Nodo nuevo, anterior;
        //    anterior = buscarLista(testigo);
        //    if (anterior != null)
        //    {
        //        nuevo = new Nodo(entrada);
        //        nuevo.enlace = anterior.enlace;
        //        anterior.enlace = nuevo;
        //    }
        //    return this;
        //}


        public void visualizar()
        {
            Nodo n;
            int k = 0;
            n = primero;
            while (n != null)
            {
                Console.WriteLine(n.dato + " ");
                n = n.enlace;
                k++;
                Console.WriteLine((k % 15 != 0 ? "" : "\n"));
            }



            
        }

    }
}
