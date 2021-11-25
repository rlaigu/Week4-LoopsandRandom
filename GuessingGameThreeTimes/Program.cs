using System;

namespace GuessingGameThreeTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab selle numbri ära arvama;
            //kui kasutaja suutis selle numbri ära arvata, siis on ta mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata,
            //siis mängu võidab arvuti;
            //programm genereerib juhuslikku numbrit üks kord;

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int i = 0; 

            while(i < 3) 
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
                    i++;
                    if (3 - i == 0)
                    {
                        Console.WriteLine($"Oled kaotaja!");
                    }
                    else
                    {
                    Console.WriteLine($"Juhuslik number {cpuNumber}. {3 - i} katset on jäänud. Proovi veel!");
                    }
                   
                }

            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
