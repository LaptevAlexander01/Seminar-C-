// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

// int[,] ArrangeElements(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < array.GetLength(1) - 1; k++)
//       {
//         if (array[i, k] < array[i, k + 1])
//         {
//           int temp = array[i, k + 1];
//           array[i, k + 1] = array[i, k];
//           array[i, k] = temp;
//         }
//       }
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

// int[,] myArray = Create2DRandomArray(colums, rows, minValue, maxValue);

// Show2DArray(myArray);
// Show2DArray(ArrangeElements(myArray));

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

// void MinSumElementsRow(int[,] array)
// {
//     int minRow = 0;
//     int minSumRow = 0;
//     int sumRow = 0;
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         minRow += array[0, i];
//     }
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
//         if (sumRow < minRow)
//         {
//             minRow = sumRow;
//             minSumRow = i;
//         }
//         sumRow = 0;
//     }
//     Console.Write($"{minSumRow + 1} строка");
// }

// Console.WriteLine("Введите размер ряда");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите размер столбцов");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение элемента массива");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение элемента массива");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(colums, rows, minValue, maxValue);

// Show2DArray(myArray);
// MinSumElementsRow(myArray);

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] Create2DRandomArray(int colums, int rows)
// {
//   int[,] newArray = new int[rows, colums];
//   for (int i = 0; i < rows; i++)
//   {
//     for (int j = 0; j < colums; j++)
//     {
//       newArray[i, j] = new Random().Next(1, 9);
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

// int[,] MultiplyMatrix(int[,] array, int[,] array1, int[,] myArrayMultiply)
// {
//   if (array.GetLength(0) != array1.GetLength(1))
// {
//     Console.WriteLine(" Строки не равны столбцам ");
//     return array;
// }
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array1.GetLength(1); j++)
//     {
//         myArrayMultiply[i, j] = 0;
//         for (int k = 0; k < array.GetLength(1); k++)
//         {
//             myArrayMultiply[i, j] += array[i, k] * array1[k, j];
//         }
//     }
// }
// return myArrayMultiply;
// }

// Console.WriteLine("Введите размер ряда");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите размер столбцов");
// int colums = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(colums, rows);
// int[,] array1 = Create2DRandomArray(colums, rows);
// int[,] myArrayMultiply = new int[rows, colums];

// Show2DArray(myArray);
// Show2DArray(array1);

// Show2DArray(MultiplyMatrix(myArray, array1, myArrayMultiply));

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// int[,,] array3D = new int[2,2,2];

// void Show3DArray(int[,,] arr)
// {
//     for (int i = 0; i < array3D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3D.GetLength(1); j++)
//         {
//             Console.WriteLine();
//             for (int k = 0; k < array3D.GetLength(2); k++)
//             {
//                 Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
//             }
//         }
//     }
// }

// void Array3DNum(int[,,] arr)
// {
//     int count = 10;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             for (int k = 0; k < arr.GetLength(2); k++)
//             {
//                 arr[k, i, j] += count;
//                 count += 3;
//             }
//         }
//     }
// }

// Array3DNum(array3D);
// Show3DArray(array3D);


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[size, size];

// int[,] SpiralArray(int[,] array, int size)
// {
//   int num = 1;
//   int i = 0;
//   int j = 0;

//   while (num <= size * size)
//   {
//     array[i, j] = num;
//     if (i <= j + 1 && i + j < size - 1) j++;
//     else 
//       if (i < j && i + j >= size - 1) i++;
//     else 
//       if (i >= j && i + j > size - 1) j--;
//     else i--;
//     num++;
//   }
//   return array;
// }

// void ShowArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
//   }
// }

// SpiralArray(array, size);
// ShowArray(array);