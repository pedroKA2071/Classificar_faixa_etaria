using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faixa_eteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float idade;


            Console.WriteLine("Qual a Sua idade: ");
            idade = float.Parse(Console.ReadLine());

            if (idade <= 12)
            {
                Console.WriteLine("CRIANÇA");
            }
            else if (idade >= 13  && idade <= 17)
            {
                Console.WriteLine("ADOLECENTE");
            }
            else if (idade >= 18 && idade <= 59)
            {
                Console.WriteLine("ADULTO");
            }
            else 
            {
                Console.WriteLine("IDOSO");
            }

            Console.ReadKey();
            





        }
    }
}
