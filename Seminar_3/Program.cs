// Напишите программу, которая на вход принимает данные координаты точки (x, y), а на выходе показывает номер четверти плоскости.

// int FindQuard(double x, double y)
// {
//   if (x > 0 && y > 0) return 1;
//   if (x < 0 && y > 0) return 2;
//   if (x < 0 && y < 0) return 3;
//   if (x > 0 && y < 0) return 4;

//   return 0;
// }

// Console.WriteLine("Введите x");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y");
// int y = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine(FindQuard(x, y));

// Напишите программу, которая на вход принимает координвты двух точек и находит растояние между ними в 2D пространстве.

// double FindDistance(double xa, double ya, double xb, double yb)
// {
//   return Math.Round(Math.Sqrt((Math.Pow(xa - xb,2) + Math.Pow(ya - yb,2))),2);
// }

// Console.WriteLine("Введите первую координату x");
// double xa = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите первую координату y");
// double ya = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите вторую координату x");
// double xb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите вторую координату y");
// double yb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Растояние между точками --> {FindDistance(xa, ya, xb, yb)}");

// Напишите программу, которая по номеру четверти показывает диапазон возможных координат точек этой четверти.

// void NumQuarter(int a)
// {
//   if (a == 1) Console.WriteLine("от X > 0 ; Y > 0");
//   if (a == 2) Console.WriteLine("от X < 0 ; Y > 0");
//   if (a == 3) Console.WriteLine("от X < 0 ; Y < 0");
//   if (a == 4) Console.WriteLine("от X > 0 ; Y < 0");
//   if (a > 4)  Console.WriteLine("Такой четверти нет");
// }

// Console.WriteLine("Введите про какие координаты четверти вы хотите знать");
// int a = Convert.ToInt32(Console.ReadLine());

// NumQuarter(a);

// Напишите программу, которая принимает на вход число и выдает на консоль квадраты чисел от одного до N.

// void NumQuad(int x)
// {
//   int quad = 1;
//   while (quad <= x)
//   { 
//   int quadX = quad * quad;
//   Console.Write(quadX +" --> ");
//   quad++;
//   }
// }

// Console.WriteLine("Введите число");
// int x = Convert.ToInt32(Console.ReadLine());

// NumQuad(x);