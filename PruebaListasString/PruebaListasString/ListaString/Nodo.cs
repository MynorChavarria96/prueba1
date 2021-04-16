using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaListasString.ListaString
{
    class Nodo
    {
        
    
    
   public object dato;
   public Nodo enlace;
    
    public Nodo(object x)
    {
    dato=x;
    enlace=null;
    }
    public Nodo (object x, Nodo n)
    {
    dato=x;
    enlace = n;
    }
    public object getDatos()
    {
    return dato;
    }
    public Nodo getEnlace()
    {
    return enlace;
    }
    public void setEnlcae (Nodo enlace)
    {
    this.enlace = enlace;
    }
    }
}
