using System;

namespace produto_desconto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o nome do produto ? ");
            string produto = Console.ReadLine();
            string prooduto= produto.ToLower();
            Console.WriteLine("Qual a quantidade do produto ?");
            int quantidade =int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o preço do produto: ");
            double preco=double.Parse(Console.ReadLine());
            
            if (quantidade<=5)
            {
                double novoPreco = preco*0.2;
                double precoDisconto=preco-novoPreco;
                double precoTotal= precoDisconto*quantidade;
                Console.WriteLine("O prodoto "+produto+" que custava "+preco+" passou a custar "+ precoDisconto+" o total a se pagar é "+precoTotal);
                
            }

            else if (quantidade<=10)
            {
                
                double novoPreco = preco*0.3;
                double precoDisconto=preco-novoPreco;
                double precoTotal= precoDisconto*quantidade;
                Console.WriteLine("O prodoto "+produto+" que custava "+preco+" passou a custar "+ precoDisconto+" o total a se pagar é "+precoTotal);
                
                
            }
            
            else
            {
                 
                double novoPreco = preco*0.5;
                double precoDisconto=preco-novoPreco;
                double precoTotal= precoDisconto*quantidade;
                Console.WriteLine("O prodoto "+produto+" que custava "+preco+" passou a custar "+ precoDisconto+" o total a se pagar é "+precoTotal);
                
                
            }
            
            
            


            
            

        }
    }
}
