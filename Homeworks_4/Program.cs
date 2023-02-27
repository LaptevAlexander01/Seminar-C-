// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// void Defree(int a, int b)
// {
//   int ab = 1;
//   int count = 1;
//   while (count <= b)
//   {
//     ab = ab * a;
//     count++;
//   }
//   Console.WriteLine($"Число {a} в степени {b} равно {ab}");
// }

// Console.WriteLine("Введите число A");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B");
// int b = Convert.ToInt32(Console.ReadLine());

// Defree(a, b);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// void SumDigit(int num)
// {
//   Console.Write($"Сумма чисел числа {num} равна ");
//   int sum = 0;
//   while (num > 0)
//   {
//     sum = (num % 10) + sum;
//     num = num / 10;
//   }
//   Console.Write(sum);
// }

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// SumDigit(num);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//   int[] array = new int [size]; // выделяем память для массива
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

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение элемента массива");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение элемента массива");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// // int[] myArray = CreateRandomArray(size, minValue, maxValue);

// // ShowArray(myArray);

// ShowArray(CreateRandomArray(size, minValue, maxValue));