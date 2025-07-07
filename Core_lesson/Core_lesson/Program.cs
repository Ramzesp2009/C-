using System;


namespace Core_lesson
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[20,10];
            Random random = new Random();
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = random.Next(1, 100);
                }
            }
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i, j] + "\t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
