using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidaEleicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            bool brasileira;

            Console.Write("Digite sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            while(idade < 16)
            {
                Console.Clear();
                Console.WriteLine("Você só pode votar se tiver 16 anos ou mais !");
                Console.Write("Digite sua idade: ");
                idade = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();

            Console.WriteLine("Você é brasileiro(a) ? S/N");
            var brasileiraKey = Console.ReadKey();
            brasileira = brasileiraKey.Key == ConsoleKey.S ? true : false;

            Console.Clear();

            if(idade >= 16 && brasileira)
            {
                Console.WriteLine("Você está apto(a) a votar !");
            }
            else
            {
                Console.WriteLine("Você não está apto(a) a votar !");
            }

            Console.ReadKey();
        }
    }
}
