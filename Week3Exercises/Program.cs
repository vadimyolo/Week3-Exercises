using System;

namespace Week3Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib, kasutaja sisestada PIN koodi.
            //programm võrdleb sisestatud PIN koodi arvuga 1234.
            //kui sisestatud PIN kood on 1234.
            //siis programm kuvab konsoolis "Tere tulemast!"
            //kui sisestatud PIN on vale, programm kuvab konsoolis
            //"Vale PIN, proovige uuesti."

            Console.WriteLine("Palun sisestage oma PIN-kood.");

            int pin = Convert.ToInt32(Console.ReadLine());
            /*if (pin == 1234)
            {
                Console.WriteLine("Sisestatud kood on õige, tere tulemast.");
            }
            else
            {
                Console.WriteLine("Sisestatud kood on vale, proovige uuesti.");
            }*/
            if (pin != 1234)
            {
                Console.WriteLine("Tere tulemast")
            }
        }
    }
}
