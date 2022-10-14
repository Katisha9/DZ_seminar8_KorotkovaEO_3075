//LВыполнение ДЗ к уроку 8. Как не нужно писать код. Часть 2. 

//Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] array = GetArray(3, 4, 0, 9);
PrintArray(array);
Console.WriteLine();

SortRowElements(array);
PrintArray(array);

void SortRowElements(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}


// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка.

/*
 int[,] array = GetArray(4, 4, 0, 9);
 PrintArray(array);

 int MinRowSumm = 37; // 36 - это максимально возможная сумма значений строке с 4 элементами и максимальным возможным значением элементов = 9
 int MinRowIndex = 0;

 for (int i = 0; i < 4; i++)
 {
     int RowSumm = 0;

     for (int j = 0; j < 4; j++)
     {
         RowSumm += array[i, j];
     }
     if (RowSumm < MinRowSumm)
     {
         MinRowSumm = RowSumm;
         MinRowIndex = i;
     }
 }

 Console.Write($"Номер строки с наименьшей суммой элементов: {MinRowIndex + 1}");
*/


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

/*
int[,] arrayFirst = GetArray(2, 2, 0, 9);
int[,] arraySecond = GetArray(2, 2, 0, 9);

PrintArray(arrayFirst);
Console.WriteLine();

PrintArray(arraySecond);
Console.WriteLine();

MultiplyArray(arrayFirst, arraySecond);

void MultiplyArray(int[,] arrayFirst, int[,] arraySecond)
{
    int[,] arrayResult = GetArray(2, 2, 0, 0);
    for (int i = 0; i < arrayResult.GetLength(0); i++)
    {
        for (int j = 0; j < arrayResult.GetLength(1); j++)
        {
            int summ = 0;
            for (int k = 0; k < arrayFirst.GetLength(1); k++)
            {
                summ += arrayFirst[i, k] * arraySecond[k, j];
            }
            arrayResult[i, j] = summ;
        }
    }
    PrintArray(arrayResult);
}
*/

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

/*
int[,,] array3dim = new int[2, 2, 2];
GetArray3dim(array3dim);
PrintArray3dim(array3dim);

void GetArray3dim(int[,,] array3dim)
{
    int[] fillNumbers = new int[8];
    int number = 0;
    for (int i = 0; i < fillNumbers.GetLength(0); i++)
    {
        fillNumbers[i] = new Random().Next(10, 100);
        number = fillNumbers[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (fillNumbers[i] == fillNumbers[j])
                {
                    fillNumbers[i] = new Random().Next(10, 100);
                    j = 0;
                    number = fillNumbers[i];
                }
                number = fillNumbers[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array3dim.GetLength(0); x++)
    {
        for (int y = 0; y < array3dim.GetLength(1); y++)
        {
            for (int z = 0; z < array3dim.GetLength(2); z++)
            {
                array3dim[x, y, z] = fillNumbers[count];
                count++;
            }
        }
    }
}

void PrintArray3dim(int[,,] array3dim)
{
    for (int k = 0; k < array3dim.GetLength(2); k++)
    {
        for (int i = 0; i < array3dim.GetLength(0); i++)
        {
            for (int j = 0; j < array3dim.GetLength(1); j++)
            {
                Console.Write($"{array3dim[i, j, k]} ({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
*/


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

/*
int[,] arraySpiral = new int[4, 4];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= arraySpiral.GetLength(0) * arraySpiral.GetLength(1))
{
  arraySpiral[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < arraySpiral.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= arraySpiral.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > arraySpiral.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(arraySpiral);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($"0{array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
*/

// Рекомендовано решить
//Задача с семинара. Отсортировать нечетные столбцы массива по возрастанию. Вывести массив изначальный и массив с отсортированными нечетными столбцами
/*
int[,] array = GetArray(3, 5, 0, 9);
PrintArray(array);
Console.WriteLine();

ArraySortedColums(array);
PrintArray(array);

void ArraySortedColums(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j+=2)
  {
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int k = 0; k < array.GetLength(0) - 1; k++)
      {
        if (array[k, j] > array[ k + 1, j])
        {
          int temp = array[k + 1,j];
          array[k + 1,j] = array[k,j];
          array[k,j] = temp;
        }
      }
    }
  }
}
*/


// методы по созданию и заполнению массивов
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
