

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Main();

void Main()
{
    Console.WriteLine("Введите начальную точку первой прямой b1: ");
    double b1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите конечную точку первой прямой k1: ");
    double k1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите начальную точку второй прямой b2: ");
    double b2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите конечную точку второй прямой k2: ");
    double k2 = double.Parse(Console.ReadLine());
    Points(k1, b1, k2, b2);
}


void Points(double K1, double B1, double K2, double B2)
{
    if (K1 == K2)
    {
        Console.WriteLine("Прямые паралельны");
    }
    else
    {
        double x = (B2 - B1) / (K1 - K2);
        Console.WriteLine($"x = {x}");

        double y = K1 * x + B1;
        Console.WriteLine($"y = {y}");
    }
}
