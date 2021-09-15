using System;

namespace RandomNumberGenerators
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int MyRandomNumber1 = rnd.Next(1, 101);


            //Numbri kontroll:

            if (MyRandomNumber1 < 5)
            {
                Console.WriteLine($"Mängija 1 juhuslik number on {MyRandomNumber1}, see on väiksem kui 5");
            }
            else if (MyRandomNumber1 > 5)
            {
                Console.WriteLine($"Mängija 1 juhuslik number on {MyRandomNumber1}, see on suurem kui 5");
            }
            else
            {
                Console.WriteLine("Mängija 1 juhuslik number on 5");
            }






        }
    }
}

