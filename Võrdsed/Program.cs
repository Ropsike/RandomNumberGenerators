using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int RandomNumber1 = rnd.Next(1, 7);

            int RandomNumber2 = rnd.Next(1, 7);

            if (RandomNumber1 > RandomNumber2)
            {
                Console.WriteLine($"{RandomNumber1} on suurem, kui {RandomNumber2}");
            }
            else if (RandomNumber1 < RandomNumber2)
            {
                Console.WriteLine($"{RandomNumber1} in väiksem, kui {RandomNumber2}");
            }
            else
            {
                Console.WriteLine($"Mõlemad on {RandomNumber1} ehk võrdsed");
            }
        }
    }
}
