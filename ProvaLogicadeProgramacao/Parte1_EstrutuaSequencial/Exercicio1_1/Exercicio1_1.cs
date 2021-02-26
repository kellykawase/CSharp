using System;

namespace Parte1_Estrutura_Sequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod1, quant1 ,cod2, quant2;
            float val1=0, val2=0, total;
        //dados da peça 1
            Console.WriteLine("DIGITE OS DADOS DA PEÇA 1");
            Console.Write("Digite o codigo: ");
            cod1 = int.Parse(Console.ReadLine());
            Console.Write("Digite quantidade:");
            quant1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor (COM VÍRGULA): ");
            val1 = float.Parse(Console.ReadLine());
        //dados da peça 2
            Console.WriteLine("DIGITE OS DADOS DA PEÇA 2");
            Console.Write("Digite o codigo: ");
            cod2 = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade:");
            quant2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor (COM VÍRGULA): ");
            val2 = float.Parse(Console.ReadLine());
        //calculando a saída
            total = (quant1 * val1) + (quant2 * val2);    
        //saído do valor total
            Console.Write("O total a pagar é: "+total);
        }
        }
    }
