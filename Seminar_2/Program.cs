// Задача 1: Напишите программу, которая выводит случайное число из отрезка (10, 99),  показывает наибольшую цифру числа.

// void maxDecimal (int num)
// {
//   int ed = num % 10; // показывает еденицы
//   int dec = num / 10; // показывает десятки
//   if (ed > dec)
//   {
//     Console.WriteLine($"Большая цифра числа {num} -> {ed}");
//   }
//   else
//   {
//     Console.WriteLine($"Большая цифра числа {num} -> {dec}");
//   }
// }
// int randomnumber = new Random().Next(10, 100);
// maxDecimal(randomnumber);

// Задача 2: Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// int DeleteDecimal(int num)
// {
//   int sot = num / 100;
//   int ed = num % 10;
//   return sot*10 + ed;
// }
// int randomnumber = new Random().Next(100, 1000);
// Console.WriteLine(randomnumber);
// // int result = DeleteDecimal(randomnumber);
// // Console.WriteLine(result);
// Console.WriteLine(DeleteDecimal(randomnumber));

// Задача 3: Напишите программу, которая на вход принимает число, и проверяет кратно ли оно 7 и 23 одновременно.

// void Devid7i23(int num)
// {
//   if (num % 7 ==0 && num % 23 == 0)
//   {
//     Console.WriteLine("Кратно");
//   }
//   else
//   {
//     Console.WriteLine("Не кратно");
//   }
// }
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// Devid7i23(num);

// Задача 4: Напишите программу, которая на вход принимает два числа и выводит, является ли второе число кратное первому. 
// Если второе число не кратно первому, то программа выводит остаток от деления.

// void Kratnost(int num1, int num2)
// {
//   if (num1 % num2 == 0)
//   {
//     Console.WriteLine("кратно");
//   }
//   else
//   {
//     Console.WriteLine($"Остаток от деления {num1} / {num2} = {num1 % num2}");
//   }
// }
// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Kratnost(num1, num2);