using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            string PlayerOne = "Biden";
            string PlayerTwo = "Kasenurm";

            int BidenThrow = rnd.Next(1, 7);
            int KasenurmThrow = rnd.Next(1, 7);

            Console.WriteLine($"{PlayerOne} threw {BidenThrow}");
            Console.WriteLine($"{PlayerTwo} threw {KasenurmThrow}");
            
            if(BidenThrow > KasenurmThrow)
            {
                Console.WriteLine($"{PlayerOne} wins!");
            }
            else if(BidenThrow < KasenurmThrow)
            {
                Console.WriteLine($"{PlayerTwo} wins!");
            }
            else
            {
                Console.WriteLine("Draw! Try again");
            }


        }
    }
}
