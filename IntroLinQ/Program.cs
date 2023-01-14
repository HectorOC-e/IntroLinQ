using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroLinQ
{
    internal class Program
    {
        static void Main()
        {
            int[] valoresNumericos = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Numeros Pares: ");

            //List<int> numerosPares = new List<int>();

            //foreach (int item in valoresNumericos)
            //{
            //    if (item % 2 == 0)
            //    {
            //        numerosPares.Add(item);
            //    }
            //}

            IEnumerable<int> numerosPares = from numero in valoresNumericos where numero % 2 == 0 select numero;

            foreach (int item in numerosPares)
            {
                Console.WriteLine(item);
            }

            
        }
    }
}
