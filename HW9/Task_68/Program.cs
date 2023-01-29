// Task 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

Console.Write("Введите первое натуральное число m: ");
double m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе натуральное число n: ");
double n = Convert.ToInt32(Console.ReadLine());

double A (double m, double n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return A (m - 1, 1);
    else return A (m - 1, A (m, n - 1));
}
Console.WriteLine($" A({m},{n}) = {A(m, n)}");


