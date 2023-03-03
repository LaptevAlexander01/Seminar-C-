//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//   int[] array = new int [size]; 
//   for (int i = 0; i < size; i++)
//   {
//     array[i] = new Random().Next(minValue, maxValue + 1);
//   }
//   return array;
// }

// void ShowArray(int[] array)
// {
//   for (int i = 0; i < array.Length; i++)
//   {
//     Console.Write(array[i] + " ");
//   }
//   Console.WriteLine();
// }

// void EvenNum(int[] array)
// {
//   int count = 0;
//   for (int i = 0; i < array.Length; i++)
//   {
//     if (array[i] % 2 == 0) count++;
//   }
//   Console.WriteLine($"Количество четных чисел в массиве -> {count}");
// }

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение элемента массива");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение элемента массива");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(myArray);
// EvenNum(myArray);

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//   int[] array = new int [size]; 
//   for (int i = 0; i < size; i++)
//   {
//     array[i] = new Random().Next(minValue, maxValue + 1);
//   }
//   return array;
// }

// void ShowArray(int[] array)
// {
//   for (int i = 0; i < array.Length; i++)
//   {
//     Console.Write(array[i] + " ");
//   }
//   Console.WriteLine();
// }

// void SumNegativePositions(int[] array)
// {
//   int sum = 0;
//   for (int i = 0; i < array.Length; i++)
//   {
//     if (i % 2 == 1) sum += array[i];
//   }
//   Console.WriteLine($"Сумма элементов стоящих на нечетных позициях равна {sum}");
// }

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение элемента массива");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение элемента массива");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(myArray);
// SumNegativePositions(myArray);

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

// void CreateRandomDoubleArray(double[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         {
//             array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
//         }
// }

// void ShowArray(double[] array)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < array.Length; i++)
//         {
//             Console.Write(array[i] + " ");
//         }
//     Console.Write("]");
//     Console.WriteLine();
// }

// void DifferenceNum(double[] array)
// {
//   double minNum = array[0];
//   double maxNum = array[0];
//   for (int i = 0; i < array.Length; i++)
//   {
//     if (array[i] <= minNum) 
//     {
//       minNum = array[i];
//     }
//     if (array[i] >= maxNum) 
//     {
//       maxNum = array[i];
//     }
//   }

//   double diff = maxNum - minNum;
//   Console.WriteLine($"Разница между максимальным и минимальным элементами равна -> {diff}");
// }

// Console.WriteLine("Введите размер массива  ");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] array = new double[size];

// CreateRandomDoubleArray(array);
// ShowArray(array);
// DifferenceNum(array);