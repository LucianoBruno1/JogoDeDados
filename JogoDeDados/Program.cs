using System;

class Program
{
    static void Main()
    {
        int rodadas = 3;
        int[] firstPlayersMove = new int[3];
        int[] secondPlayersMove = new int[3];
        int FirstPlayerWins = 0;
        int SecondPlayerWins = 0;

        Random rd = new Random();
        int qtdValores = 6;

        Console.WriteLine("Informe o nome do primeiro jogador: ");
        string firstPlayer = Console.ReadLine();

        Console.WriteLine("\nInforme o nome do segundo jogador: ");
        string secondPlayer = Console.ReadLine();

        if (secondPlayer.Equals(firstPlayer))
        {
            Console.WriteLine("Os jogadores não podem ter o mesmo nome. Insira outro nome para o jogador 2");
        }
        else
        {
            for (int i = 0; i < rodadas; i++)
            {
                int randomNumber1 = rd.Next(1, 6); // Gere números entre 1 e qtdValores
                int randomNumber2 = rd.Next(1, 6);

                Console.WriteLine($"\n{firstPlayer} tirou o número: {randomNumber1}");
                firstPlayersMove[i] = randomNumber1;

                Console.WriteLine($"{secondPlayer} tirou o número: {randomNumber2}");
                secondPlayersMove[i] = randomNumber2;

                if (firstPlayersMove[i] == secondPlayersMove[i])
                {
                    Console.WriteLine($"EMPATE! Nenhum jogador pontua na {i} rodada!");
                }
                else
                {
                    if (firstPlayersMove[i] > secondPlayersMove[i])
                    {
                        Console.WriteLine($"{firstPlayer} venceu a {i+1}° rodada!");
                        FirstPlayerWins++;
                    }
                    else
                    {
                        Console.WriteLine($"{secondPlayer} venceu a {i+1}° rodada!");
                        SecondPlayerWins++;
                    }
                }
            }
            if (FirstPlayerWins > SecondPlayerWins)
            {
                Console.WriteLine($"\n{firstPlayer} venceu a partida com {FirstPlayerWins} pontos!");

            }
            else if (SecondPlayerWins > FirstPlayerWins)
            {
                {
                    Console.WriteLine($"\n{secondPlayer} venceu a partida com {SecondPlayerWins} pontos!");
                }
            }
        }
    }

}
       

