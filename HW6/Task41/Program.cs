// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

string[] data = Console.ReadLine().Split(' ');
for (int i = 0; i < data.Length; i++)
{
    Console.Write(" " + int.Parse(data[i]) + ",");
}
Console.WriteLine();


int[] Result(int[] origArray)
{
    int count = 0;
    
    for (int i = 0; i < origArray.Length; i++)
    {
        if (origArray[i] > 0) count++;
    }
}

string data;
int[] count = Result(data);
Console.WriteLine(count);


// Console.Write("Введите числа через запятую: ");
// string words = Console.ReadLine();
// origArray = words.Split(",");
// int[] arr = Count(origArray);
// Console.WriteLine(arr);


