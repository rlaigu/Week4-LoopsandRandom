using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab selle numbri ära arvama;
            //kui kasutaja suutis selle numbri ära arvata, siis on ta mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata, siis mängu võidab arvuti;
            //programm genereerib juhuslikku numbrit üks kord;

            int cpuNumber;
            Random rnd = new Random();
             cpuNumber = rnd.Next(0, 10);
            int guess = 3;

            while (guess < 3)
            {
                Console.WriteLine("Palun arva number ära vahemikus 1 kuni 10!");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess == cpuNumber)
                {
                    Console.WriteLine($"Oled võitja!");
                    break;
                }
                else
                {
                    
                    Console.WriteLine($"Vabandust, {cpuNumber} on õige number. {3 - i} katset on jäänud.");
                }


            }



        }
    }
}
