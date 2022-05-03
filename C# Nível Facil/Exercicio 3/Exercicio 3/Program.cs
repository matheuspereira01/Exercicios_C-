using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {

            string linha = "*";
            for(int i = 1; i < 5; i++)
            {
                Console.WriteLine(linha);
                linha = linha + "*";
            }
            Console.ReadLine();
        }
    }
}
