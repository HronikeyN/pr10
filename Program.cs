//*********************************************************
//*Практическая работа №10                                *
//*Выполнил:Алексеев Н.М., группа 2ИСП                    *
//*Задание:Составить программу работу линейного алгоритма *
//*********************************************************
using System;


namespace пр10
{
    class Program
    {
        private const bool V = true;

        static void Main(string[] args)
        {
            Console.WriteLine("Доброго времени суток мой дорогой друг!!");
            Console.WriteLine("Практическая работа №10");

            const int m = 4, n = 5;
            int[,] Mas = new int[m, n];
            int i = 0, j = 0;
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                { 
                  Console.Write("Введите [" + i + "," + j + "] Элемент массива:");
                  Mas[i, j] = Convert.ToInt32(Console.ReadLine());
                    double sum = 0;
                 for (i = 0; i< n ;  i++)
                    {
                    i = 0
                    }

                }
                
            }
            



            Console.ReadKey();
        }
    }
}
