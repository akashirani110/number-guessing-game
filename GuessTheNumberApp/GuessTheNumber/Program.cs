// See https://aka.ms/new-console-template for more information
using GuessTheNumber;
Console.WriteLine("*********************************");
Console.WriteLine("Welcome to Guess the Number game!");
Console.WriteLine("*********************************");

Console.WriteLine("");

Console.WriteLine("************************* Rules ******************************");

Console.WriteLine("**************************************************************");
Console.WriteLine("You get 5 tries to guess the number correctly between 1 to 100");
Console.WriteLine("**************************************************************");

Console.WriteLine("");

Console.WriteLine("**************************************************************");
Console.WriteLine("You will also get hints along the way");
Console.WriteLine("**************************************************************");

var userName = string.Empty;
do
{
    Console.Write("Please enter your name to start the game: ");
    userName = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(userName))
    {
        Console.WriteLine("Please enter a valid name");
    }
    else
    {
        Console.WriteLine($"Alright {userName}, let's start!");
        Console.WriteLine("");
    }
}while(string.IsNullOrWhiteSpace(userName));

GuessingGame.Game(userName);
