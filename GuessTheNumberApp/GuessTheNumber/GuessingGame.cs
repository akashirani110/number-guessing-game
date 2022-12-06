
namespace GuessTheNumber
{
    public static class GuessingGame
    {
        public static void Game(string? userName)
        {           
            var numberOfTry = 1;
            var totalTries = 5;
            bool isCorrect = false;
            bool playAgain = false;

            do
            {
                var numberToGuess = RandomNumberGenerator.CreateRandomNumber();
                while (numberOfTry <= totalTries && !isCorrect)
                {
                    int userInput;
                    bool isValidNumber;
                    do
                    {
                        if (numberOfTry == 1)
                        {
                            Console.Write("Give your first shot: ");
                        }
                        else
                        {
                            Console.Write("Please guess the number again: ");
                        }
                        var nextGuess = Console.ReadLine();
                        isValidNumber = int.TryParse(nextGuess, out userInput);
                        if (!isValidNumber)
                        {
                            Console.WriteLine("Please enter a valid (int) number");
                        }
                    } while (!isValidNumber);

                    if (isValidNumber)
                    {
                        isCorrect = CheckUserInput(userInput, numberToGuess, userName);
                        if (isCorrect)
                        {
                            playAgain = ContinuePlaying();
                            numberOfTry = 1;
                            isCorrect = false;
                            break;
                        }
                        if(numberOfTry == 5 && !isCorrect)
                        {          
                            Console.WriteLine($"The correct answer is: {numberToGuess}");
                            playAgain = ContinuePlaying();
                            if (playAgain)
                            {
                                numberOfTry = 1;
                                isCorrect = false;
                                break;
                            }
                            else
                            {
                                break;
                            }                            
                        }
                    }
                    var hint = HintBuilder.CheckNumberOfGuess(numberOfTry, userInput, numberToGuess);
                    if(numberOfTry != 5)
                    {
                        Console.WriteLine($"You missed it! Your hint is: {hint}");
                        Console.WriteLine("");
                    }
                    
                    numberOfTry++;
                } 
            } while (playAgain);

            Console.WriteLine("*******************************************************");
            Console.WriteLine($"See you again, {userName}!");
            Console.WriteLine("*******************************************************");
            
        }
        public static bool CheckUserInput(int input, int numberToGuess, string userName)
        {
            if (input == numberToGuess)
            {
                Console.WriteLine("**************************************************");
                Console.WriteLine($"Congratulations {userName}, you guessed it right!");
                Console.WriteLine($"The number is {numberToGuess}");
                Console.WriteLine("**************************************************");
                Console.WriteLine("");
                return true;
            }

            return false;
        }

        public static bool ContinuePlaying()
        {
            var response = string.Empty;
            string yes = "yes";
            string no = "no";
            do
            {
                Console.Write("Do you want to continue playing? (yes/no) ");
                response = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(response))
                {
                    Console.WriteLine("Please enter yes to continue or no to quit");
                } 
            } while (string.IsNullOrWhiteSpace(response) 
                && (!string.Equals(yes, response, StringComparison.OrdinalIgnoreCase) 
                || !string.Equals(no, response, StringComparison.OrdinalIgnoreCase)));

            if(string.Equals(yes, response, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            return false;
        }

    }
}
