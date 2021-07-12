using System;

namespace descontoCombustivel
{
    class Program
    {
        static void Main(string[] args)

        {
            
            Console.WriteLine("Você quer A-álcool ou G-gasolina ? ");
            string combustivel = Console.ReadLine();

            string coombustivel= combustivel.ToUpper();
            
            
            string  letra= coombustivel.Substring(0,1);

            switch(letra)
            {
                case "A":

                Console.WriteLine("Quantos litros deseja colocar ? ");
                int lAlcool = int.Parse(Console.ReadLine());

                if (lAlcool>20)
                {
                    double respostaA= lAlcool*4.655;
                    Console.WriteLine("O total a se pagar é: "+ respostaA);
                }

                else{

                    double respostaA= lAlcool*4.753;
                    Console.WriteLine("O total a se pagar é: "+ respostaA);


                }

                    break;


                case "G":

                Console.WriteLine("Quantos litros deseja colocar ? ");
                int lGasolina = int.Parse(Console.ReadLine());

                if (lGasolina>20)
                {
                    double respostaG= lGasolina*4.982;
                    Console.WriteLine("O total a se pagar é: "+ respostaG);
                    
                }

                else
                {
                    double respostaG= lGasolina*5.088;
                    Console.WriteLine("O total a se pagar é: "+ respostaG);
                    
                }

                    break;    

            }
                
            

            
        }
    }
}
