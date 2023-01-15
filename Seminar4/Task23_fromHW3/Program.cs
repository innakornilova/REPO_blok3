using static Library;

// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

// 1. Метод считывания от пользователя N
// 2. Метод создания массива
// 3. Метод получения кубов чисел
// 4. Распечатать результат
// 5. Красиво распечатать результат


void Task23()
{
    int countByUser = GetNumberByUser("Введите число N ");
    int[] list = CreateArray(countByUser);
    GetCubing(list);
    string result = Print(list);
    Console.WriteLine(result);
}

Task23();

// Console.WriteLine();
// Console.WriteLine();
// Console.WriteLine();
// File.WriteAllText("list.md", RanderMD(list));

// //OR// Console.WriteLine(Print2(list));
