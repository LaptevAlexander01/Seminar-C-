//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Input first number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 > num2) 
// {
//   Console.WriteLine($"The number {num1} is greater than {num2}");
// }
// else 
// {
//   Console.WriteLine($"The number {num2} is greater than {num1}");
// }

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Input first number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input third number");
// int num3 = Convert.ToInt32(Console.ReadLine());
// int max = num1;
// if (max < num2)
// {
//   max = num2;
// }
// if (max < num3)
// {
//   max = num3;
// }
// else Console.WriteLine($"The max number {max}"); 

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num % 2 == 1)
// {
//   Console.WriteLine($"Число {num} является нечетным");
// }
// else{
//   Console.WriteLine($"Число {num} являтся четным");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
Console.Write($"Четные числа от {i} до {num} ");
while (i <= num)
{
  if (i % 2 == 0)
  {
  Console.Write(i + " ");
  }

i++;
}