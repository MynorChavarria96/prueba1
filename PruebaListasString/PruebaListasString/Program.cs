using PruebaListasString.Circular;
using PruebaListasString.objListaOrdenada;
using System;
using System.Collections;
using System.Collections.Generic;

namespace PruebaListasString
{
    class Program
    {
       
        static void Main(string[] args)
        {
            listaCircular lista;
            lista = new listaCircular();
            string[] nombre = { "Mynor", "Pedro", "Luis" , "Javier", "Karla" };
            string[] nombres = { "Patricia", "Juan", "Carina", "Nixon", "Max" };
            List<String> listaNombres = new List<String>(nombre);
            string eliminar;

            foreach (string nom in listaNombres)
            {
                lista.insertar(nom);
                
            }


           

          //  int pause = 0;

            //lista.insertaOrden("Mynor Estuardo");
            //lista.insertaOrden("mynor antonio");
            //lista.insertaOrden("Pedro");
            //lista.insertaOrden("Luis");
            //lista.insertaOrden("Javier");
            //lista.insertaOrden("Karla");

            lista.recorrer();

            Console.WriteLine("Ingrese dato a eliminar");
            eliminar= Console.ReadLine();

            lista.eliminar(eliminar);
            lista.recorrer();


            //Console.WriteLine("Lista Ordenada");
           // lista.visualizar();
            Console.ReadKey();


        }
    }
}
