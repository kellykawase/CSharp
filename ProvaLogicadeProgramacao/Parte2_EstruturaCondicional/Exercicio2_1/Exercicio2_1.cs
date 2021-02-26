using System;

namespace Exercicio2_1
{
    class Program
    {
        static void Main(string[] args)
        { 
            int codigo, quantidade;
            double total,esp=0;
            Console.Write("Digite o código do produto que deseja ( 1, 2, 3, 4 ou 5): ");
            codigo = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade que deseja: ");
            quantidade = int.Parse(Console.ReadLine());
            if(codigo == 1){
                //caso escolha o cachorro quente            
            esp = 4;            
            }
            if(codigo == 2){
                //caso escolha X-Salada            
            esp = 4.50;          
            }
            if(codigo == 3){
                //caso escolha X-Bacon            
            esp = 5.00;
           
            }
            if(codigo == 4){
                //caso escolha Torrada simples            
            esp = 2.00;            
            }
            if(codigo == 5){
                //caso escolha refrigerante            
            esp = 1.50;
            } 
            total = esp * quantidade;
            Console.Write("O total a pagar é: ");
            Console.Write(String.Format("{0:0.00}",total));

        }
    }
}
