// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int A = 22;
int B = 3;
int C = 9;

int max = A;

if (A > max) max = A;
if (B > max) max = B;
if (C > max) max = C;
{
    Console.Write("max = ");
    Console.WriteLine(max);
}

