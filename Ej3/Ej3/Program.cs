using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue fila = new Queue();
            int id, turno = 1;
            while (turno == 1)
            {
                Console.WriteLine("ingrese id ");
                id = int.Parse(Console.ReadLine());
                fila.Enqueue(id);
                Console.WriteLine("Coloque 0 si no ingresaran mas personas de lo contrario ingrese 1 ");
                turno = int.Parse(Console.ReadLine());


            }
            while (fila.Count > 0)
                // Thread.Sleep(2000);
                Console.WriteLine("El tuno es de " + (int)fila.Dequeue());

            Console.ReadKey();
        }


    }
}
