using System;

namespace WeatherReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis temperatuur on täna väljas?");
            int temp = Convert.ToInt32(Console.ReadLine());

            if (temp >= 35)
            {
                Console.WriteLine("Õues on boiling hot.");
            }
            else if (temp >= 30 && temp < 35)
            {
                Console.WriteLine("Õues on hot.");
            }
            else if (temp >= 20 && temp < 30)
            {
                Console.WriteLine("Õues on päris nice.");
            }
            else if (temp >= 10 && temp < 20)
            {
                Console.WriteLine("Õues on quite chilly.");
            }
            else if (temp >=0 && temp < 10)
            {
                Console.WriteLine("Õues on päris cold.");
            }
        }
    }
}
