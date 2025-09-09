using Microsoft.VisualBasic;

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            SystemArrayFunctonality();
        }

        static void SystemArrayFunctonality()
        {
            Console.WriteLine("=> Woorking with System.Array. <=");
            string[] gothicBands = { "Tones on Tail", "Bauhaus", "Sisters of Mercy" };
            Console.WriteLine("-> Here is the array:");
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");

            }
            Console.WriteLine("\n");

            Array.Reverse(gothicBands);
            Console.WriteLine("-> The reversed Array <-");
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");

            }
            Console.WriteLine("\n");

            Console.WriteLine("-> Cleared out all but one... <-");
            Array.Clear(gothicBands, 1, 2);
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine("\n");
        }
    }

}
