// Задание 1. Задайте двухмерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Например. Задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получактся вот такой массив:
// 8 4 2 4 
// 5 9 2 3 
// 1 4 7 2
// Реализуем метод поинтереснее, он бдет менять любую строку с любой другой.


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

// int[,] ChangeRows(int[,] array, int row1, int row2)
// {
//   row1--;
//   row2--;
//   if (row1 > array.GetLength(0) || row2 > array.GetLength(0) || row1 < 0 || row2 < 0)
//   {
//     Console.WriteLine("Некоректнная строка");
//     return array;
//   }
//   else
//   {
//     for (int j = 0; j < array.GetLength(0); j++)
//     {
//       int temp = array[row1, j];
//       array[row1, j] = array[row2, j];
//       array[row2, j] = temp;
//     }
//   }
//   return array;
// }

// Console.WriteLine("Введите размер ряда");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите размер столбцов");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение элемента массива");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение элемента массива");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите какую строку будем менять");
// int row1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите на какую строку будем менять");
// int row2 = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(colums, rows, minValue, maxValue);
// Show2DArray(myArray);
// ChangeRows(myArray, row1, row2);
// Show2DArray(myArray);

// Задание 2. Задайте двухмерный массив. Напишите программу, которая заменяет строки на столбцы. В случае если это не возможно
// программа должна вывести сообщение.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// В итоге получается во такой массив:
// 1 5 8 5 
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7


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

// int [,] RowsToColumns(int[,] array)
// {
//   if (array.GetLength(0) != array.GetLength(1))
//   {
//     Console.WriteLine("Количество строк не совпадает количеству столбцов");
//     return array;
//   }
//   else
//   {
//     for (int i = 0; i < array.GetLength(0) - 1; i++)
//     {
//       for (int j = i + 1; j < array.GetLength(1); j++)
//       {
//         int temp = array[i, j];
//         array[i, j] = array[j, i];
//         array[j, i] = temp;
//       }
//     }
//   }
//     return array;  
// }

// Console.WriteLine("Введите размер ряда");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите размер столбцов");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение элемента массива");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение элемента массива");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите какую строку будем менять");

// int[,] myArray = Create2DRandomArray(colums, rows, minValue, maxValue);

// Show2DArray(myArray);
// Show2DArray(RowsToColumns(myArray));

// Задание 3: Создайте двухмерный массив. Найдите минимальный элемент массива и замените строку и ряд где он находится нулями.


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

// int[,] DeleteMinElement(int[,] array)
// {
//   int min = array[0,0];
//   int rowMin = 0;
//   int columnMin = 0;
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       if (array[i, j] < min)
//       {
//         min = array[i, j];
//         rowMin = i;
//         columnMin = j;
//       }
//     }
//   }
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     array[i, columnMin] = 0;
//   }
//   for (int j = 0; j < array.GetLength(1); j++)
//   {
//     array[rowMin, j] = 0;
//   }
//   return array;
// }

// Console.WriteLine("Введите размер ряда");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите размер столбцов");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение элемента массива");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение элемента массива");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите какую строку будем менять");

// int[,] myArray = Create2DRandomArray(colums, rows, minValue, maxValue);

// Show2DArray(myArray);
// Show2DArray(DeleteMinElement(myArray));