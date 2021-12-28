using System;

namespace ConsoleApp9
{
  class Program
  {
    static void Main(string[] args)
    {
      const int CellCount = 4;
      const int WallCount = CellCount + 1;

      var horWalls = new bool[CellCount, WallCount + 1];
      var vertWall = new bool[WallCount + 1, CellCount];

      // Заполнение стенами.
      var rnd = new Random();
      for (var row = 0; row <= WallCount; row++)
        for (var col = 0; col < CellCount; col++)
          horWalls[col, row] = rnd.Next(1, 100) > 50;
      for (var row = 0; row < CellCount; row++)
        for (var col = 0; col <= WallCount; col++)
          vertWall[col, row] = rnd.Next(1, 100) > 50;
      // Отрисовка.

      for (var row = 0; row <= WallCount; row++)
      {
        Console.WriteLine();
        // Отрисовка горизонтальных стен.
        for (var col = 0; col < CellCount; col++)
        {
          Console.Write(" ═ ");
        }
        Console.WriteLine();
        // Отрисовка вертикальных стен.
        if (row > CellCount)
          continue;

        for (var col = 0; col <= WallCount; col++)
        {
          Console.Write("║ ");
        }
      }

      Console.ReadLine();
    }
  }
}