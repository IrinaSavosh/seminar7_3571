// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// ​
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.a

Console.Clear();

Random rowsRandom = new Random();    // рандомная строка 
int valueR = rowsRandom.Next(1, 10);

Random columnsRandom = new Random();        // рандобмный столбец
int valueC = columnsRandom.Next(1, 10);

double[,] GetMatrix(int rowsCount, int columsCount) // рандомный массив дабл   
{
   double[,] matr = new double[rowsCount, columsCount];
   Random rand = new Random();

   for (int i = 0; i < matr.GetLength(0); i++)     // 0 - это строка, 1 - это столбец
   {
      for (int j = 0; j < matr.GetLength(1); j++)
      {
         matr[i, j] = Math.Round((rand.NextDouble() * (9-0)+0), 0);
         // matr[i, j] = Math.Round(matr[i, j], 0); //округление
         // (max-min)+min
      }

   }
   return matr;

}

void ArithmeticMeanColumns(double[,] matr)
{

   for (int j = 0; j < matr.GetLength(1); j++)     // 0 - это строка, 1 - это столбец
   {
      double sum = 0;
      for (int i = 0; i < matr.GetLength(0); i++)
      {

         sum = sum + matr[i, j];

      }

      // double newI = Convert.ToDouble(i);   - не имеет смысла переводить int в double
      //                                        при необходимости в итоге получить double
      double am = sum / (matr.GetLength(0)); //(newI + 1);
      Console.Write($"{am:f1}" + " ");

      // Console.WriteLine(sum); - проверка
   }

}

void PrintMatrix(double[,] matr)
{
   for (int i = 0; i < matr.GetLength(0); i++)
   {
      for (int j = 0; j < matr.GetLength(1); j++)
      {

         Console.Write($"{matr[i, j]}" + "   ");
         // [-7.0, 13.0] (max-min)+min

      }
      Console.WriteLine();
      // Console.WriteLine();
   }
}

double[,] matrix = GetMatrix(valueR, valueC);    // метод случайного массива
PrintMatrix(matrix);
Console.WriteLine();
// Console.WriteLine(matrix[0, 0] + matrix[1, 0]); // - проверка
ArithmeticMeanColumns(matrix);