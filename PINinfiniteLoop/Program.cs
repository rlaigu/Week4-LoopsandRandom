using System;

namespace PINinfiniteLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada PIN-koodi;
            //programm võrdleb sisestatud PIN-koodi arvuga 1234;
            //kui sisestatud PIN-kood on 1234, siis konsool kuvab "Tere tulemast!";
            //kui sisestatud PIN-koodi on midagi muud, siis konsool kuvab " vale PIN. Proovi uuesti.";
            //katsete arv piiramatu;

            bool loopActive = true; //boolean ==> true/false
            int i = 0;

            while (loopActive) 
            {
                Console.WriteLine("Sisesta PIN:"); //cw+double TAB
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if(userPIN == 1234) 
                {
                    Console.WriteLine("Tere tulemast!");
                    loopActive = false;
                }
                else 
                {
                    i++; // i = i + 1;
                    Console.WriteLine("Vale PIN. Proovi uuesti.");
                    Console.WriteLine($"Oled vale PIN-koodi {i} korda sisestanud.");
                }
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
