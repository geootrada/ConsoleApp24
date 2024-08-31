using System;

namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[,] data = new int[10, 10];

            int maxRandomNumber = 50;
            int minRandomNumber = 1;
            int maxElement = 0;
            int insertElement = 0;

            Console.WriteLine("Первоначальный массив");

            for (int i = 0; i < data.GetLength(0); i++) 
            {
                for (int j = 0; j < data.GetLength(1); j++) 
                {
                    data[i, j] = random.Next(minRandomNumber,maxRandomNumber);
                    Console.Write(data [i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Наибольший элемент ");

            for (int i = 0; i < data.GetLength(0); i++)
            {
                for(int j = 0;j < data.GetLength(1); j++)
                {
                   if (maxElement < data[i, j])

                   {
                        maxElement = data[i, j];
                   }
                }
            }
            Console.WriteLine(maxElement);
            Console.WriteLine();
            Console.WriteLine("Новый массив");

           for(int i = 0;i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++) 
                {
                    if(maxElement == data[i, j])
                    {
                        data[i, j] = insertElement;
                    }
                    Console.Write(data[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
