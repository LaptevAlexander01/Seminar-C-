// Напишите программу, которая на вход принимает число (А) и выдает сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// int FindSum(int a)
// {
//   int sum = 0;
//   for (int current = 1; current <= a; current++)
//   {
//     sum+=current; // sum = sum + current
//   }
//   return sum;
// }

// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(FindSum(a));

// Задача 2: Напишите программу, которая выводит массив из восьми элементов, заполненый нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,1]

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

// Задача 3: Напишите программу, которая принимает на вход число и выдает количество цифр в числе. (можно записать при помощи while).

// void QuanlityDigit(int num)
// {
//   int count = 0;
//   while (num > 0)
//   {
//     num = num / 10;
//     count++; 
//   }
//   Console.WriteLine($"Количество цифр: {count}");
// }

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// QuanlityDigit(num);

// Задача 4: Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N. (факториал)

// void Factorial(int num)
// {
//   Console.Write($"Произведения числа {num} --> ");
//   int n = 1;
//   int count = 1;
//   while (num >= count)
//   {
//     n = n * count;
//     count++;
//     Console.Write(n + " ");
//   }
// }

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// Factorial(num);