// Task 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.WriteLine("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

int min = 1;
int num = N;
void ColNum(int num)
{
        if(num % num == 0)
        {
           Console.Write(num + " ");
        }
        num--;
    if(num < min) 
    return;
    ColNum(num);
}
ColNum(num);

