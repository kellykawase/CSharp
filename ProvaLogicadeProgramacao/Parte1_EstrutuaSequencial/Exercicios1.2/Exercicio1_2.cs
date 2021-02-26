using System;

namespace Exercicios1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio,area, pi=3.14159;
            Console.Write("Digite o valor do raio (COM VÍRGULA): ");
            raio = double.Parse(Console.ReadLine());
            area = pi * Math.Pow(raio,2);
            Console.Write("O valor da área do círculo é: ");
            Console.Write( string.Format("{0:0.0000}", area));
        }
    }
}
