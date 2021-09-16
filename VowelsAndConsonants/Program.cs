using System;

namespace VowelsAndConsonants
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada tähte
            //programm kontrollib kas sisestatud täht on;
            //täishäälik või kaashäälik
            //kui sisestatud täht on täishäälik siis kuvatatakse.
            //"täishäälik."
            //kyu sisestatud on kaashäälik siis kuvatatakse;
            //"kaashäälik."
            //kasutame switchi.

            Console.WriteLine("Sisesta täht.");
            char userCharacter = Convert.ToChar(Console.ReadLine().ToLower());

            
            switch (userCharacter) 
            {
                case 'a':
                    Console.WriteLine("Täishäälik");
                    break;
                case 'e':
                    Console.WriteLine("Täishäälik");
                    break;
                case 'i':
                    Console.WriteLine("Täishäälik");
                    break;
                case 'o':
                    Console.WriteLine("Täishäälik");
                    break;
                case 'u':
                    Console.WriteLine("Täishäälik");
                    break;
                default:
                    Console.WriteLine("Kaashäälik");
                    break;
               
            }

        }
    }
}
