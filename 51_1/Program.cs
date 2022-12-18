// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// Доп. условие для 51 задачи: сделать суммирование в один цикл. Матрица может быть прямоугольный

int[,] GetMatrix(int rowsCount, int columsCount, int leftRange = 0, int rightRange = 50)
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


int Task(int[,] matr)
{
   int sum = 0;
   int length = 0;
   if (matr.GetLength(0) > matr.GetLength(1))
   {
      length = matr.GetLength(1);
   }
   else
   {
      length = matr.GetLength(0);
   }
   for (int i = 0; i < length; i++)
   {
      sum += matr[i, i];

   }
   return sum;
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

int[,] matr = GetMatrix(6, 2, 0, 9);
PrintMatrix(matr);
int sum = Task(matr);
Console.WriteLine();
Console.WriteLine(sum);


