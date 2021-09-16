using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kasutab kasutaja tunnust ja parool.
            //programm kontrollib sisestatud andmeid
            //kui sisestatud kasutaja tunnus on "admin" ja
            //sisestatud parool on ka "admin1234"
            //siis kuvab see programm "Tere tulemast!"
            //muul juhul ytleb see "Vale parool ja kasutaja tunnus, proovi uuesti."

            Console.WriteLine("Tere, palun sisestage oma kasutaja tunnus ja parool.");

            string userName = Console.ReadLine();
            string password = Console.ReadLine();

            if(userName == "admin" && password == "admin1234")
            {
                Console.WriteLine("Tere tulemast süsteemi.");
            }
            else
            {
                Console.WriteLine("Valed andmed, proovige uuesti.");
            }

        }
    }
}
