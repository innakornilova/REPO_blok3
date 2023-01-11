// Напишите программу, которая принимает на вход координаты двух 
//точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

double xa = 3; 
double ya = 6;
double xb = 2; 
double yb = 1;
double za = 8;
double zb = 3; 

// int х1 = ReadInt("Введите координату X первой точки: ");
// int y1 = ReadInt("Введите координату Y первой точки: ");

double distance = GetDistance2D (xa, xb, ya, yb);
System.Console.WriteLine(distance);

double GetDistance2D(double xa, double xb, double ya, double yb)
{
    return Math.Sqrt(Math.Pow(xa-xb, 2) +
                     Math.Pow(ya-yb, 2));
                    
}
double distance = GetDistance3D(xa, xb, ya, yb, za, zb);
System.Console.WriteLine(distance);

double GetDistance3D(double xa, double xb, double ya, double yb, double za, double zb);
{
    return Math.Sqrt(Math.Pow(xa-xb, 2) +
                     Math.Pow(ya-yb, 2) +
                     Math.Pow(za-zb));
                    
}
// Math.Pow (x, 2)
//sum == A*A + B*B;

//Math.Sqrt(sum);

//Console.WriteLIine(Math.Sqrt(sum));
