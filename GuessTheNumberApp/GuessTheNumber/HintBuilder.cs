
namespace GuessTheNumber
{
    public static class HintBuilder
    {
        public static string CheckNumberOfGuess(int numberOfTry, int guess, int numberToGuess)
        {
            switch (numberOfTry)
            {
                case 1:
                    return OddEvenHint(guess, numberToGuess);
                case 2:
                    return ComparisonHint(guess, numberToGuess);
                case 3:
                    return MultipleHint(guess, numberToGuess);
                case 4:
                    return ShowADigitHint(guess, numberToGuess);
                default:
                    return string.Empty;
            }           
        }

        public static string ComparisonHint(int guess, int numberToGuess)
        {
            if (numberToGuess < guess) return "The number is less than what you guessed";
            return "The number is greater than what you guessed";
        }

        public static string OddEvenHint(int guess, int numberToGuess)
        {
            if(numberToGuess % 2 == 0 && guess % 2 == 0)
            {
                return "Yes, It is an even number";
            }
            else if(numberToGuess % 2 != 0 && guess % 2 != 0)
            {
                return "Yes, It is an odd number";
            }
            else if(numberToGuess % 2 == 0 && guess % 2 != 0)
            {
                return "The number is an even number";
            }

            return "The number is an odd number";
        }

        public static string MultipleHint(int guess, int numberToGuess)
        {
            if (numberToGuess % 3 == 0 && numberToGuess % 5 == 0 && numberToGuess % 7 == 0)
                return "The number is a multiple of 3, 5, and 7";
            if (numberToGuess % 3 == 0 && numberToGuess % 5 == 0) return "The number is a multiple of 3 and 5";
            if (numberToGuess % 5 == 0 && numberToGuess % 7 == 0) return "The number is a multiple of 5 and 7";
            if (numberToGuess % 3 == 0 && numberToGuess % 7 == 0) return "The number is a multiple of 3 and 7";
            if (numberToGuess % 3 == 0) return "The number is a multiple of 3";
            if (numberToGuess % 5 == 0) return "The number is a multiple of 5";
            if (numberToGuess % 7 == 0) return "The number is a multiple of 7";

            return "The number is not a multiple of 3, 5, and 7";
        }

        public static string ShowADigitHint(int guess, int numberToGuess)
        {
            if(numberToGuess > 9 && numberToGuess < 100)
            {
                var numStr = numberToGuess.ToString();

                if(numStr.Length > 0 && !string.IsNullOrEmpty(numStr))
                {
                    return $"The first digit is {numStr[0]}";
                }
            }
            return "The number is a single digit number";
        }
    }
}
