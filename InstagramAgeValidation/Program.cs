using System;

namespace InstagramAgeValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsitab sünniaastat
            //programm kasutab kasutaja vanust
            //programm kontrollib kas kasutaja on vanem kui 13, või 13 aastane vana.
            //kui kasutaja on 13 aastat vana või vanem
            //SIIS Ta voib ig-d kasutada
            //kui tan noorem, siis ei tohi.

            Console.WriteLine("Tere! Palun sisestage oma sünniaasta.");

            int YearOfBirth = Convert.ToInt32(Console.ReadLine());

            int age = 2021 - YearOfBirth;

            if (YearOfBirth >= 13)
            {
                Console.WriteLine("Sa võid kasutada Instagrammi.");
            }
            else 
            {
                Console.WriteLine("Oled piisavalt noor ning ei tohi kasutada Instagrammi..");
            }

        }
    }
}
