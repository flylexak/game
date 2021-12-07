using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int size, size1;
            Console.WriteLine("Введите размерность массива");
            string inputedSize = Console.ReadLine();
            size = int.Parse(inputedSize);
            size1 = int.Parse(inputedSize);

            string[,] names = new string[size, size1];
            string[,] familes = new string[size, size1];


            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Введите имя №{i + 1}");
                names[i, 0] = Console.ReadLine();

            }

            for (int n = 0; n < size1; n++)
            {
                Console.WriteLine($"Введите фамилию №{n + 1}");
                familes[n, 0] = Console.ReadLine();

            }
            Console.Clear();
            Console.WriteLine("Все фамилии и имена");




            foreach (var nm in names)
            {

                for (int l = 0; l < 1; l++)
                {
                    Console.WriteLine(nm + $"-имя №{l + 1}");
                }
            }

            foreach (string nm in familes)
            {

                for (int n = 0; n < 1; n++)
                {
                    Console.WriteLine(nm + $"-фамилия №{n + 1}");
                }
            }


            foreach (string nm in names)
            {

                Console.WriteLine(":)");
            }


        }
    }
}
