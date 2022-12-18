// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// ​
// m = 3, n = 4.
// ​
// 0,5 7 -2 -0,2
// ​
// 1 -3,3 8 -9,9
// ​
// 8 7,8 -7,1 9

double[,] GetMatrix(int rowsCount, int columsCount)
{
   double[,] matr = new double[rowsCount, columsCount];
   Random rand = new Random();

   for (int i = 0; i < matr.GetLength(0); i++)     // 0 - это строка, 1 - это столбец
   {
      for (int j = 0; j < matr.GetLength(1); j++)
      {
         matr[i, j] = rand.NextDouble();

      }

   }
   return matr;

}

int GetNumber(string massege)
{
   Console.Write(massege);
   return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(double[,] matr)
{
   for (int i = 0; i < matr.GetLength(0); i++)
   {
      for (int j = 0; j < matr.GetLength(1); j++)
      {
         Console.Write($"{matr[i, j] * (9.9 + 9.9) - 9.9:f1}" + " ");
         // [-7.0, 13.0] (max-min)+min

      }
      Console.WriteLine();
   }
}

int rows = GetNumber("Введите число строк:");
int columns = GetNumber("Введите число столбцов:");

double[,] matrix = GetMatrix(rows, columns);
PrintMatrix(matrix);



// Random rand = new Random();
// Console.WriteLine($"{rand.NextDouble() * 10 - 5:f2}"); // [-5.0, 5.0]
// Console.WriteLine($"{rand.NextDouble() * (13.0 + 7.0) - 7.0:f2}"); // [-7.0, 13.0] (max-min)+min

