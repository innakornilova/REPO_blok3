// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//Достаточно было index присвоить значение 1б в условии цикла прописать index <= N, 
// а в консоль, соответственно, выводить значение index, если он имеет четное значение

Console.WriteLine("Введите значение числа N");
int N = Convert.ToInt32(Console.ReadLine());

int[] arr = Enumerable.Range(1, N).ToArray();
int index;
index = 1;

while (index < N)
{
    if (arr[index] % 2 == 0) 
    {
        Console.WriteLine (arr[index]);
    }

    index ++;   

}
