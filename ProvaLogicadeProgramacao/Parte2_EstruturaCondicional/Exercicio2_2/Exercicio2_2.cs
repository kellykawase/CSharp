using System;

namespace Exercicio2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b,c,x1,x2,delta;
           Console.Write("Digite o valor de A (COM VÍRGULA): ");
           a = double.Parse(Console.ReadLine());
           Console.Write("Digite o valor de B (COM VÍRGULA): ");
           b = double.Parse(Console.ReadLine());
           Console.Write("Digite o valor de C (COM VÍRGULA): ");
           c = double.Parse(Console.ReadLine());
          // calculando o valor de delta
           delta = Math.Pow(b,2) - (4 * a * c);
           if(a==0 || delta < 0 ){ //caso o valor de A=0 e delta negativo
               Console.WriteLine("Impossível calcular.");
           }
           else{//caso contrário
            x1 = ( - b + Math.Sqrt(delta)) / (2 * a);
            x2 = ( - b - Math.Sqrt(delta)) / (2 * a);
          
            Console.Write("X1 = ");
            Console.WriteLine(String.Format("{0:0.00000}",x1));//valor de x1
            Console.Write("X2 = ");
            Console.Write(String.Format("{0:0.00000}",x2));//valor de x2
            }            
        }
    }
}
