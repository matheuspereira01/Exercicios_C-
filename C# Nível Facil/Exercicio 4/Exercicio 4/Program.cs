using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
	class Program
	{
		static void Main(string[] args)
		{

			int a = 0;
			int b = 1;
			int contador = 0;

			while (contador <= 30)
			{
				Console.WriteLine("{0}", a);
				Console.WriteLine("{0}", b);

				a = a + b;
				b = b + a;
				contador++;

			}

			Console.ReadLine();
		}
	}
}

/*			int num1 = 0, num2 = 1, aux;

			for (int i = 0; i​​​​​​​ <= 30; i++)
			{
				aux = num1;
				num1 = num2;
				num2 = num1 + aux;
				Console.WriteLine("{0}", num2);

			}

*/