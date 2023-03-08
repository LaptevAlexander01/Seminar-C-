// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] Create2DRandomArray(int colums, int rows, int minValue, int maxValue)
// {
//   double [,] newArray = new double [rows, colums];
//   for (int i = 0; i < rows; i++)
//   {
//       for (int j = 0; j < colums; j++)
//       {
//         newArray[i, j] = Convert.ToDouble(new Random().Next(minValue, maxValue)) + Math.Round(new Random().NextDouble(),1); // Math.Round используется только для того что бы не выводить 8 знаков после запятой.
//       }
//   }
//  return newArray;
// }

// void Show2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// Console.WriteLine("Введите размер столбцов");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите размер ряда");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение элемента массива");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение элемента массива");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// double [,] array = Create2DRandomArray(colums, rows, minValue, maxValue);
// Show2DArray(array);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1;7 -> такого числа в массиве нет

// int[,] Create2DRandomArray(int colums, int rows, int minValue, int maxValue)
// {
//   int [,] newArray = new int [rows, colums];
//   for (int i = 0; i < rows; i++)
//   {
//       for (int j = 0; j < colums; j++)
//       {
//         newArray[i, j] = new Random().Next(minValue, maxValue+1);
//       }
//   }
//   return newArray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int SearchPosition(int[,] array, int position1, int position2)
// {
//  if (position1 > array.GetLength(0) || position2 > array.GetLength(1))
//  {
//   Console.WriteLine($"{position1};{position2} -> такого числа в массиве нет");
//  }
//  else
//  {
//  Console.Write($"Число с позициями {position1};{position2} --> ");
//  }
//  return array[position1, position2];
// }


// Console.WriteLine("Введите размер ряда");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите размер столбцов");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение элемента массива");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение элемента массива");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите позицию строки");
// int position1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите позицию столбца");
// int position2 = Convert.ToInt32(Console.ReadLine());

// int [,] array = Create2DRandomArray(colums, rows, minValue, maxValue);

// Show2DArray(array);
// Console.Write(SearchPosition(array, position1, position2));



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int[,] Create2DRandomArray(int colums, int rows, int minValue, int maxValue)
// {
//   int[,] newArray = new int[rows, colums];
//   for (int i = 0; i < rows; i++)
//   {
//     for (int j = 0; j < colums; j++)
//     {
//       newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//     }
//   }
//   return newArray;
// }

// void Show2DArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
//   }
//   Console.WriteLine();
// }

// void Arithmetic(int[,] array)
// {
//   for (int j = 0; j < array.GetLength(1); j++)
//   {
//     double sum = 0;
//     double division = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//       sum += array[i, j];
//       division = sum / array.GetLength(0);
//     }
//       Console.Write($"[{division}] ");
//   }

// }

// Console.WriteLine("Введите размер рядов");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите размер столбцов");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение элемента массива");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение элемента массива");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] array = Create2DRandomArray(colums, rows, minValue, maxValue);

// Show2DArray(array);
// Arithmetic(array);

