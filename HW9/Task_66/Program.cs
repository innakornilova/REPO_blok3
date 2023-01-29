// Task 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.


Console.Write("Введите первое натуральное число: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе натуральное число: ");
int N = Convert.ToInt32(Console.ReadLine());

int sum = 0;

void SumNumber(int M)
{
    sum += M;
    M++;
    if(M > N)
    {
        Console.Write($"Сумма всех натуральных чисел в этом промежутке: {sum}");
        return;
    }
    SumNumber(M);
}
SumNumber(M);
