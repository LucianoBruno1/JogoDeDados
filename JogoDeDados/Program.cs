using System;

class Program
{
    static void Main()
    {
        int rounds = 3;
        int[] firstPlayersMove = new int[3];
        int[] secondPlayersMove = new int[3];
        int firstPlayerWins = 0;
        int secondPlayerWins = 0;

        Random rd = new Random();

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
            for (int i = 0; i < rounds; i++)
            {
                int randomNumber1 = rd.Next(1, 6); 
                int randomNumber2 = rd.Next(1, 6);

                Console.WriteLine($"\n{firstPlayer} tirou o número: {randomNumber1}");
                firstPlayersMove[i] = randomNumber1;

                Console.WriteLine($"{secondPlayer} tirou o número: {randomNumber2}");
                secondPlayersMove[i] = randomNumber2;

                if (firstPlayersMove[i] == secondPlayersMove[i])
                {
                    Console.WriteLine($"EMPATE! Nenhum jogador pontua na {i+1}° rodada!");
                }
                else
                {
                    if (firstPlayersMove[i] > secondPlayersMove[i])
                    {
                        Console.WriteLine($"{firstPlayer} venceu a {i+1}° rodada!");
                        firstPlayerWins++;
                    }
                    else
                    {
                        Console.WriteLine($"{secondPlayer} venceu a {i+1}° rodada!");
                        secondPlayerWins++;
                    }
                }
            }
            if (firstPlayerWins > secondPlayerWins)
            {
                Console.WriteLine($"\n{firstPlayer} venceu a partida com {firstPlayerWins} pontos!");

            }
            else if (secondPlayerWins > firstPlayerWins)
            {  
                    Console.WriteLine($"\n{secondPlayer} venceu a partida com {secondPlayerWins} pontos!");
            }
            else
            {
                Console.WriteLine("\nO jogo empatou!");
            }
        }
    }

}
       

