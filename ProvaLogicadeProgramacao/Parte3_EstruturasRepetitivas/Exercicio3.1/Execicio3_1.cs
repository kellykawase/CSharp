using System;

namespace Exercicio3._1
{
    class Program
    {
        static void Main(string[] args)
        {//Obs.: dá para fazer das duas formas
         /*   int senha=0;
           do{ //toda a lista de comandos será executada pelo menos uma vez para depois
           //a condição ser testada. Enquanto essa condição for verdadeira, os comandos serão
           // repetidos.

                Console.Write("Digite a senha: ");
                senha = int.Parse(Console.ReadLine());
                Console.WriteLine("Senha inválida!");

            }while(senha != 2002);//Pós-teste -> enquanto a senha for difererente 2002
            //continua a repetição

            Console.WriteLine("Acesso permitido!");
        }*/

        
            int senha=0;
           while(senha != 2002){//Pré-teste -> enquanto a senha for difererente 2002
            //continua a repetição

                Console.Write("Digite a senha: ");
                senha = int.Parse(Console.ReadLine());
                Console.WriteLine("Senha inválida!");

            }

            Console.WriteLine("Acesso permitido!");
        }
    }
}
