using System;

namespace Desafio
{
    class Program
    {
        static void Main()
        {
            Jogador1();
        }
        static public void Jogador1()
        {
            int tentativa;
            Console.WriteLine("Escolha um numero de 1 a 100 para o jogador 2 acertar:");
            int numEscolhido = int.Parse(Console.ReadLine());
            Console.Clear();

            do
            {
                Console.Clear();
                Console.WriteLine("Tente advinhar o numero agora");
                tentativa = int.Parse(Console.ReadLine());
                if(tentativa < numEscolhido)
                    Console.WriteLine("Errou! o numero escolhido pelo jogador 1 é maior!");
                if(tentativa > numEscolhido)
                    Console.WriteLine("Errou! o numero escolhido pelo jogador 1 é menor!");
                Thread.Sleep(2000);
            }while(tentativa != numEscolhido);
            Console.WriteLine("Acertou!!!");

        }
    }
}