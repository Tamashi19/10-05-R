using System;

namespace _10_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual ano você nasceu? ");
            int anoDeNascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("Que ano estamos? ");
            int anoDeHoje = int.Parse(Console.ReadLine());

            if (anoDeHoje-anoDeNascimento>=16)
            {
                Console.WriteLine("Você pode votar esse ano !!!");
            }

            else
            {
                Console.WriteLine("Você não pode votar esse ano !!!");
            }
            
        }
    }
}
