using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public static class RandomNumberGenerator
    {
        public static int CreateRandomNumber()
        {
            var random = new Random();
            return random.Next(1, 100);
        }
    }
}
