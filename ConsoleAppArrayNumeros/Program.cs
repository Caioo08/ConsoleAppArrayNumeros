using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrayNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont_mn = 999999999;
            int cont_ma = 0;

            Console.WriteLine("Insira a quantidade de números");
            int qtd = int.Parse(Console.ReadLine());

            int[] num = new int[qtd];

            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine("Digite o número: ");
                num[i] = int.Parse(Console.ReadLine());

                if (cont_mn > num[i])
                {
                    cont_mn = num[i];
                }

                if (cont_ma < num[i])
                {
                    cont_ma = num[i];
                }
            }

            Console.Write("Os números digitados foram ");
            for (int j = 0; j < qtd; j++)
            {
                Console.Write(" " +num[j]);
            }


            Console.WriteLine("\n O menor número digitado foi " + cont_mn);
            Console.WriteLine("O maior número digitado foi " + cont_ma);
            Console.ReadKey();
        }
    }
}
