//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1 y = k2 * x + b2 значения b1, k1, b2 и k2 задаются пользователем.
Console.Clear();

Console.Write("Введите b1:");
double numberb1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите k1:");
double numberk1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите b2:");
double numberb2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите k2:");
double numberk2 = int.Parse(Console.ReadLine()!);

double x = (numberb2 - numberb1)/(numberk1 - numberk2);
double y = (numberk1 * x + numberb1);

Console.WriteLine($"Координаты точки пересеяения прямы X: {x}, Y: {y}");