using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej4
{
    class Program
    {
        static void Main()
        {
            int agua;
            int luz;
            int cable;
            int telefono;
            int gas;

            Console.WriteLine("\t \t Ingrese Gastos del mes \n \n 0-Agua \n 1-Luz \n 2-Cable \n 3-Telefono \n 4-Gas ");
            
            int s = 0;
            int[] gastos = new int[5];


            for (int i = 0; i < gastos.Length; i++)
            {   

                Console.Write("Ingrese Gastos en orden indicado  ");
                gastos[i] = int.Parse(Console.ReadLine());
                Console.Write("\n");

            }
            Console.WriteLine("\t \t Orden Cronologico");
            for (int id = 0; id < gastos.Length; id++)
            {
                Console.WriteLine("Gasto {0}: {1}", id, gastos[id]);
                s += gastos[id];
            }

            Console.WriteLine("Su suma de los gastos es " + s);
          

            Array.Sort(gastos);
            Console.WriteLine("Gasto minimo es: " + gastos[0]);
            Array.Reverse(gastos);
            Console.WriteLine("Gasto maximo es: " + gastos[0]);




            Console.ReadKey();
        }
    }

}



