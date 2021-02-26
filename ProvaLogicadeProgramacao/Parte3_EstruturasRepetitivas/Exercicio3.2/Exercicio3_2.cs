using System;

namespace Exercicio3._2
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] x;
             int n, dentro=0, fora=0;
            
            Console.Write("Digite a quantidade de números inteiros: ");
            n = int.Parse(Console.ReadLine());
            
            x = new int[n];

            for(int i=0;i<n;i++)
            {
                Console.Write("Digite o número inteiro: "); 
                x[i] =  int.Parse(Console.ReadLine());             

                if(x[i] < 21 && x[i] > 9)
                {
                    dentro = dentro +1;    
                }
                else{
                   fora = fora + 1;
                }
                 
            }
            Console.WriteLine(dentro +" in");
            Console.Write(fora + " out");

        }
    }
}
