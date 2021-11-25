using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab selle numbri ära arvama;
            //kui kasutaja suutis selle numbri ära arvata, siis on ta mängu võitnud;
            //katsete arv on piiramatu;
            //programm genereerib juhuslikku numbrit üks kord;

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int guess;
            bool loopActive = true;

            Console.WriteLine("Palun arva number ära vahemikus 1 kuni 10!");
            
            while (loopActive)
            {
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess == cpuNumber) 
                {
                    Console.WriteLine($"Oled võitja!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Juhuslik number on {cpuNumber}. Proovi uuesti!");
                }
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
