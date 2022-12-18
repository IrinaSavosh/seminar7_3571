// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// ​
// Например, задан массив:
// ​
// 1 4 7 2
// ​
// 5 9 2 3
// ​
// 8 4 2 4
// ​
// 1 7 -> такого числа в массиве нет

int[,] GetMatrix(int rowsCount, int columsCount, int leftRange = 0, int rightRange = 9)
{
   int[,] matr = new int[rowsCount, columsCount];
   Random rand = new Random();

   for (int i = 0; i < matr.GetLength(0); i++)     // 0 - это строка, 1 - это столбец
   {
      for (int j = 0; j < matr.GetLength(1); j++)
      {
         matr[i, j] = rand.Next(leftRange, rightRange + 1);
      }
   }
   return matr;
}

int GetNumber(string massege)
{
   Console.Write(massege);
   return Convert.ToInt32(Console.ReadLine());
}


void ElementValue(int[,] matr, int rows, int columns)
{
   if (rows >= matr.GetLength(0) || columns >= matr.GetLength(1))
   {
      Console.Write("такого числа в массиве нет");
   }
   for (int i = 0; i < matr.GetLength(0); i++)     // 0 - это строка, 1 - это столбец
   {
      for (int j = 0; j < matr.GetLength(1); j++)
      {
         if (rows == i && columns == j)
         {
            Console.Write(matr[i, j]);
         }
      }
   }
}
void PrintMatrix(int[,] matr)
{
   for (int i = 0; i < matr.GetLength(0); i++)
   {
      for (int j = 0; j < matr.GetLength(1); j++)
      {
         Console.Write(matr[i, j] + " ");
      }
      Console.WriteLine();
   }
}

Random rowsRandom = new Random();    // рандомная строка 
int valueR = rowsRandom.Next(1, 10);

Random columnsRandom = new Random();        // рандобмный столбец
int valueC = columnsRandom.Next(1, 10);

int[,] matrix = GetMatrix(valueR, valueC);    // метод случайного массива

int rows = GetNumber("Введите строку:");    // нужная строка для поиска элемента
int columns = GetNumber("Введите столбец:");  // нужный столбец для поиска элемента
PrintMatrix(matrix);                // печать рандомного массива
ElementValue(matrix, rows, columns);    
