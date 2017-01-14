using System;
using System.Collections;

class Program
{
    static Hashtable GetHashtable()
    {
       
        Hashtable hashtable = new Hashtable();
        hashtable.Add("Nombre", "Palabra o conjunto de palabras con las que se  distinguen los seres vivos ");
        hashtable.Add("Lenguaje", "Capacidad propia del ser humano para expresar pensamientos.");
        hashtable.Add("Numero", "Concepto matemático que expresa una cantidad con relación a la unidad de cómputo");
        return hashtable;
    }

    static void Main()
    {
        Hashtable hashtable = GetHashtable();
        

        Console.WriteLine("Ingrese Palabra a buscar ");
        string buscar= Console.ReadLine();

        
        Console.WriteLine(hashtable.ContainsKey(buscar));
      
       
       

        Console.ReadKey();
    }
}