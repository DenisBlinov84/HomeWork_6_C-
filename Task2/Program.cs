// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1 ; y = k2 * x + b2 ;
// значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();

double b1, k1, b2, k2;

Console.Write("Enter b1: ");
b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter k1: ");
k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter b2: ");
b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter k2: ");
k2 = Convert.ToDouble(Console.ReadLine());

void Intersection(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Intersection point: ({x}; {y})");
}
Intersection(b1, k1, b2, k2);

// Console.Clear();

// double b1, k1, b2, k2, x, y;

// Console.Write("Enter b1: ");
// b1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Enter k1: ");
// k1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Enter b2: ");
// b2 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Enter k2: ");
// k2 = Convert.ToDouble(Console.ReadLine());

// x = (b2 - b1) / (k1 - k2);
// y = k1 * x + b1;

// Console.WriteLine($"Intersection point: ({x}; {y})");
     







