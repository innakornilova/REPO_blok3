// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int cubing(int number, int[] arr, int index)
{
    while (index < number)
    {
        Console.WriteLine(Math.Pow(arr[index], 3));
        index++;
    }

    return index;
}

Console.WriteLine("Введите значение числа N ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Таблица кубов чисел от 1 до ");
Console.WriteLine(number);

int[] arr = Enumerable.Range(1, number).ToArray();
int index;
index = 0;

index = cubing(number, arr, index);



