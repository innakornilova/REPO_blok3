// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите значение числа N");
int N = Convert.ToInt32(Console.ReadLine());

int [] array = {1, 2, 3, 4, 5};
int index;
index = 0;

while (index < N)
{
    if (array[index] % 2 == 0) 
    {
        Console.WriteLine (array[index]);
    }

    index ++;   

}
