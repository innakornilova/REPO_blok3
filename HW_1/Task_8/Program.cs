// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int [] array = {1, 2, 3, 4, 5};
int N = array.Length;
int index = 0;

while (index < N)
{
    if (array[index] % 2 == 0) 
    {
        Console.WriteLine (array[index]);
    }

    index ++;   

}
