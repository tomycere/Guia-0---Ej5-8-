using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_0___Ej5_8_
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingreso;
            bool ok = false;
            int numero = 0;

            while(!ok)
            {
                Console.Write("Ingrese un numero mayor a 0:");
                ingreso = Console.ReadLine();
                ok = int.TryParse(ingreso , out  numero);
            }

            Console.WriteLine();

            for (int i = 0; i < numero; i++)
            {
                int a = 0;
                for (int j = 1; j < (i + 1); j++)
                {
                    if (i % j == 0)
                    {
                        a++;
                    }
                }
                if (a <= 2)
                {
                    Console.WriteLine(i);
                }
              

                
            }
            Console.ReadKey();
        }
    }
}
