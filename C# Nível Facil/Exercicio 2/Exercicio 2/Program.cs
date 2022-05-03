using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("introduza um numero");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            }

            Console.ReadLine();
        }
    }
}
