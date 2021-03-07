using System;
using System.Threading;



Main();
void Main()
{

    Random random = new Random();
    int computerChoice = random.Next(1, 3);

    int playerPoints = 0;

    int computerPoints = 0;


    Console.WriteLine("---------------------------");
    Console.WriteLine($"| Player: {playerPoints} | Computer: {computerPoints} |");
    Console.WriteLine("---------------------------");


    int choice()
    {
        Console.WriteLine("Choose wisely...");
        Console.WriteLine("(1) Rock");
        Console.WriteLine("(2) Paper");
        Console.WriteLine("(3) Scissors");
        int playerChoice = 0;
        string playerSelect = Console.ReadLine();
        if (playerSelect != "1" && playerSelect != "2" && playerSelect != "3")
        {
            Console.WriteLine("You've made an invalid choice");
            Thread.Sleep(3000);
            Console.Clear();
            Main();
        }
        else
        {
            playerChoice = Int32.Parse(playerSelect);
        }
        return playerChoice;
    }
    choice();
}



