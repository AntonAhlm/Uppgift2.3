using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Hur många dagar vill du hyra bilen? ");
            int dagar = Convert.ToInt32(Console.ReadLine());

            Console.Write("Hur många kilometer kommer du köra? ");
            int km = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Det kommer kosta " + (300+km+500*(dagar-1)) + " kr");

        }
    }
}
