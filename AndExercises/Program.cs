using System;

namespace AndExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //tingimused sisseastumiseks.
            //miinimum matemaatikas 85p.
            //miinimum keemias 90p
            //miinimum bioloogias 95p
            //programm küsib kasutajal sisestada tema
            //eksami punktid ja otsustab kas saab arstiks õppida.

            Console.WriteLine("Tere! Palun sisestage oma matemaatika eksami punktid.");
            int math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Palun sisestage oma keemia eksami punktid.");
            int chemistry = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Palun sisestage oma bioloogia eksami punktid.");
            int biology = Convert.ToInt32(Console.ReadLine());

            if(math >= 85 && chemistry >= 90 && biology >= 95)
            {
                Console.WriteLine("Sobite arstiks, ning saate õppima minna.");
            }
            else 
            {
                Console.WriteLine("Ei sobi.");
            }

        }

    }
}
