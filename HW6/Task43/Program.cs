// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// y1 = k1*x + b1
// y2 = k2*x + b2
// k1*x + b1 = k2*x + b2
// x = (b2 - b1) / (k1 - k2)


double GetValue(string text)
{
    System.Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}
    // Console.WriteLine("Введите значение первой точки прямой: ");
    // double x = double.Point(Console.ReadLine());
    // Console.WriteLine("Введите значение второй точки прямой: ");
    // double y = double.Point(Console.ReadLIne());
    // return (x, y);

(double, double) GetCrossLine(double k1, double b1, double k2, double b2)
{
    double x = (b2-b1) / (k1 - k2);
    double y = k1* x + b1;
    return (x, y);
} 

// void PrintRes(double x, double y)
// {
//     Console.WriteLine($"Координаты пересечения линий: {x}, {y}");
// }

double k1 = GetValue("k1 = ");
double b1 = GetValue("b1 = ");
double k2 = GetValue("k2 = ");
double b2 = GetValue("b2 = ");
var r = GetCrossLine(k1, b1, k2, b2);
System.Console.WriteLine(r.Item1);
System.Console.WriteLine(r.Item2);
System.Console.Write("Координаты точки пересечения линий: ");
System.Console.WriteLine(r);