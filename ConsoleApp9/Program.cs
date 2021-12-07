using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows;
            const int cols = 2;
            Console.WriteLine("Введите количество строк");
            string inputedSize = Console.ReadLine();
            rows = int.Parse(inputedSize);

            string[,] namesInfo = new string[rows, cols];


            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Введите имя №{i + 1}");
                namesInfo[i, 0] = Console.ReadLine();

                Console.WriteLine($"Введите фамилию №{i + 1}");
                namesInfo[i, 1] = Console.ReadLine();
            }

            Console.Clear();
            Console.WriteLine("Все фамилии и имена");
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Имя №{i + 1} - {namesInfo[i, 0]} Фамилия №{i + 1} - {namesInfo[i, 1]}");
            }
            Console.ReadLine();
        }
    }
}
