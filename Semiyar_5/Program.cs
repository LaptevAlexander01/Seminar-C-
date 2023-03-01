// Задача 1: Задайте массив из 12 элеентов, заполненый случайными числами из промежутка (-9, 9).
//           Найдите сумму положительных и отрицательных элементов массива.


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

// void FindPosNegSum(int[] array)
// {
//   int sumPositive = 0;
//   int sumNegative = 0;
//   for (int i = 0; i < array.Length; i++)
//   {
//     if (array[i] >= 0) sumPositive += array[i];
//     else sumNegative += array[i];
//   }
//   Console.WriteLine($"Сумма положительных чисел в массиве -> {sumPositive}, отрицательных-> {sumNegative}");
// }

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение элемента массива");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение элемента массива");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(myArray);
// FindPosNegSum(myArray);

// Задача 2: Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные и наоборот.

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

// int[] InvertArray(int[] array)
// {
//   for(int i = 0; i < array.Length; i++)
//   {
//     array[i] *= -1;
//   }
//   return array;
// }

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение элемента массива");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение элемента массива");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(myArray);
// myArray = InvertArray(myArray);
// ShowArray(myArray);

// Задача 3: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 343, 3] -> нет

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

// bool SeachNum(int[] array, int num)
// {
//   for (int i = 0; i < array.Length; i++)
//   {
//     if (array[i] == num) return true; //Console.WriteLine("Вот оно");
//   }
//   return false;
// }

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение элемента массива");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение элемента массива");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число которое ищем");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(myArray);
// Console.WriteLine(SeachNum(myArray, num));

// Задача 4: Создайте массив из 123 случайных чисел. Найдите количество элементов массива значения которых лежат в отрезке [10,99].

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

// void FindNums(int[] array)
// {
//   int count = 0;
//   for (int i = 0; i < array.Length; i++)
//   {
//     if (array[i] >= 10 && array[i] <= 99)
//     count++;
//   }
//   Console.WriteLine(count);
// }

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение элемента массива");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение элемента массива");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);

// FindNums(myArray);