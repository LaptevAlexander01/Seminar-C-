// Задача 19:  Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// void Polindrom(int num)
// {
// if (num < 10000 || num > 99999)  
// {
//   Console.WriteLine("Вы ввели не пятизначное число");
// }
//   else
//   {
//     int firstDec = (num / 1000) % 100;
//     int fourDigit = (num % 100) / 10;
//     int fiveDigit = num % 10;
//     int secondDec = (fiveDigit * 10) + fourDigit;
//       if (firstDec == secondDec) 
//       {
//         Console.WriteLine("Число является полиндромом");
//       }
//       else 
//       {
//         Console.WriteLine("Число не является полиндромом");
//       }
//     }
// }

// Console.WriteLine("Введите пятизначное число чтобы проверить является ли оно палиндромом.");
// int num = Convert.ToInt32(Console.ReadLine());

// Polindrom(num);


// Задача 21:  Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double Distance3D(double xa, double ya, double za, double xb, double yb, double zb)
// {
//   return Math.Round(Math.Sqrt((Math.Pow(xa - xb,2) + Math.Pow(ya - yb,2) + Math.Pow(za - zb,2))),2);
// }

// Console.WriteLine("Введите первую координату точки по х");
// double xa = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите первую координату точки по y");
// double ya = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите первую координату точки по z");
// double za = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите вторую координату точки по х");
// double xb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите вторую координату точки по y");
// double yb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите вторую координату точки по z");
// double zb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine(Distance3D(xa, ya, za, xb, yb, zb));

// Задача 23:  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void CubNum(int n)
// {
//   Console.Write($"Кубы до числа {n}: ");
//   int cube = 1;
//   while (cube <= n)
//   {
//     int cube1 = cube * cube * cube;
//     Console.Write(cube1 + " -> ");
//     cube++;
//   }
// }
// Console.WriteLine("Введите число");
// int n = Convert.ToInt32(Console.ReadLine());

// CubNum(n);