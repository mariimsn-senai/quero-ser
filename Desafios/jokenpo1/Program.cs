using System;

namespace jokenpo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int jogador1 = 0;
            int jogador2 = 0;
            var array = new bool?[3, 3];

            array[0, 1] = false;
            array[0, 2] = true;

            array[1, 0] = true;
            array[1, 2] = false;

            array[2, 0] = false;
            array[2, 1] = true;

            do
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Escolha um item:");
                    Console.WriteLine("1 = Pedra");
                    Console.WriteLine("2 = Papel");
                    Console.WriteLine("3 = Tesouro");

                    Console.WriteLine("Jogador 1 escolha um item: ");
                    jogador1 = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Jogador 2 escolha um item: ");
                    jogador2 = Int32.Parse(Console.ReadLine());

                    Console.WriteLine();
                    switch (array[jogador1, jogador2])
                    {
                        case true:
                            Console.WriteLine("Jogador 1 é o vencedor!");
                            break;
                        case false:
                            Console.WriteLine("Jogador 2 é o vencedor!");
                            break;
                        default:
                            Console.WriteLine("Empatou.");
                            break;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Deseja jogar novamente:");
                    Console.WriteLine("1 = Sim");
                    Console.WriteLine("2 = Não");
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Ocorreu um erro");
                    Console.WriteLine("Deseja jogar novamente:");
                    Console.WriteLine("1 = Sim");
                    Console.WriteLine("2 = Não");
                }

            } while (Console.ReadLine() == "1");
            }
        }
    }

