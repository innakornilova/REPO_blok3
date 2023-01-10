// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
//между ними в 3D пространстве.

double GetDistance(double xa, double ya, double za, double xb, double yb, double zb)
{
    return Math.Sqrt(Math.Pow(xa - xb, 2) + 
                     Math.Pow(ya - yb, 2) + 
                     Math.Pow(za - zb, 2));
       
}

double GetNumber(string text)
{
System.Console.WriteLine(text);
return Convert.ToDouble(Console.ReadLine());
}
double xa = GetNumber("xa = ");
double ya = GetNumber("ya = ");
double za = GetNumber("za = ");
double xb = GetNumber("xb = ");
double yb = GetNumber("yb = ");
double zb = GetNumber("zb = ");

double distance = GetDistance(xa, ya, za, xb, yb, zb);
Console.Write("Расстояние между точками ");
Console.WriteLine(distance);

