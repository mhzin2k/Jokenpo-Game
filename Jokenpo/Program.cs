using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] jokenpo = { "Pedra", "Papel", "Tesoura" };

            Random r = new Random();

            int posicao = r.Next(jokenpo.Length);

            string rnd_play = jokenpo[posicao];

            Console.WriteLine("Pedra \nPapel \nTesoura\n\nQual será sua jogada? ");
            string player = Console.ReadLine();

            if (rnd_play == player)
            {
                Console.WriteLine("\nSua jogada: " + player);
                Console.WriteLine("\nJogada do Computador: " + rnd_play + "\n");
                Console.WriteLine("Empate!");
            }
            else
            {
                if (rnd_play == "Pedra" && player == "Tesoura")
                {
                    Console.WriteLine("\nSua jogada: " + player);
                    Console.WriteLine("\nJogada do Computador: " + rnd_play + "\n");
                    Console.WriteLine("A maquina ganhou!");
                }
                else if (rnd_play == "Papel" && player == "Pedra")
                {
                    Console.WriteLine("\nSua jogada: " + player);
                    Console.WriteLine("\nJogada do Computador: " + rnd_play + "\n");
                    Console.WriteLine("A maquina ganhou!");
                }
                else if (rnd_play == "Tesoura" && player == "Papel")
                {
                    Console.WriteLine("\nSua jogada: " + player);
                    Console.WriteLine("\nJogada do Computador: " + rnd_play + "\n");
                    Console.WriteLine("A maquina ganhou!");
                }
                else
                {
                    Console.WriteLine("\nSua jogada: " + player);
                    Console.WriteLine("\nJogada do Computador: " + rnd_play + "\n");
                    Console.WriteLine("Você ganhou!");
                }
            }
        }
    }
}
