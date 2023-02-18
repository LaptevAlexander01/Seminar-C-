// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// void SecondDigit(int num)
// {
//   int dec = num % 100;
//   int ed = dec / 10;
//   Console.WriteLine($"Вторая цифра числа {num} -> {ed}");
// }

// Console.WriteLine("Введите техзначное число");
// int num = Convert.ToInt32(Console.ReadLine());

// SecondDigit(num);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// void ThirdDigit(int num)
// {
//   if (num / 100 == 0)
//   {
//     Console.WriteLine("Третьей цифры нет");
//   }
//   else
//   {
//     Console.Write($"Третья цифра числа {num} --> ");
//     while (num > 1000)
//     {
//       num = (num / 10);
//     }
//     int sot = num % 10;
//     Console.Write(sot);
//   }
// }  

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// ThirdDigit(num);

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// void Weekdays(int num)
// {
//   if (num <= 5)
//   {
//     Console.WriteLine("Будень");
//   }
//   if (num == 6)
//   {
//     Console.WriteLine("Выходной день ");
//   }
//   if (num == 7)
//   {
//     Console.WriteLine("Выходной день");
//   }
//   if (num > 7)
//   {
//     Console.WriteLine("Такого дня нет");
//   }
// }

// Console.WriteLine("Введите день недели");
// int num = Convert.ToInt32(Console.ReadLine());

// Weekdays(num);