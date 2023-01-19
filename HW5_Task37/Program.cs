// Задача 37: 

// Найдите произведение пар чисел в одномерном массиве. 

// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 

// Результат запишите в новом массиве.

// СДЕЛАТЬ МИНИМУМ ТРИ МЕТОДА

// 1. Считываем данные от пользователя 
//  1. Считать целое число
// int <- (string)
//  2. Считать вещественное (double) число 
// double <- (string)
// 2. Метод создания массива
// double [] <- (int)
// int [] <- (int)

// 3. Заполнить массив
//  3.1.Случайным образом
// int[] <- (int, min, max)
// double[] <- (int)
//  3.3.С клавиатуры
// int[] <- (void)
// double[] <- (void)

//  int[] <- (int, min, max)

//  4. Печать массива
//  string <- (int[])

// 5. Найти произведение пар чисел в одномерном массиве (крайние числа и т.д.)
// int[] <- (int[])
// double[] <- (double[])

// 6. GoodPrint new array
// string <- (int[]) 
// Текстовый файл <- (int[])

// Красиво распечатать: произведение пар чисел
// string <- (int[], int])


    int GetNumberByUser(string text)
    {
        Console.Write(text + " ");
        return Convert.ToInt32(Console.ReadLine());
    }

    int [] CreateArray(int size)
    {
        return new int[size];
    }

    void FillArray(int[] colNumber)
    {
        int count = colNumber.Length; 
                
        for (int i = 0; i < count; i++)   
        {
            colNumber[i] = Random.Shared.Next(1, 10); 
        } 
    }

    string PrintArray(int[] numbers)
    {
        string output = String.Empty;
        int size = numbers.Length;

        for (int j = 0; j < size; j++)
        {
            output = output + $"{numbers[j]} ";
        }
        return output;
    }

    int[] newArray(int[] array)
    {   
        int[] result = new int [array.Length/2]; 
        int count = array.Length;
                
        for (int i = 0; i < count / 2; i++)   
        {
            result[i] = array[i] * array[count - 1 - i];
        } 
                
    return result;
    }

    // string PrintMult(int[] numb)
    // {
    //     string output = String.Empty;
    //     int size = numb.Length;

    //     for (int j = 0; j < size; j++)
    //     {
    //         output = output + $"{numb[j]} ";
    //     }
    //     return output;
    // }

    string GoodPrint(int[] arr, int[] colMult)
    {
        return $"{String.Join(" ", arr)} >> произведение пар чисел >>  {String.Join(" ", colMult)}"; 
        // {String.Join(" ", colMult)} потому что это не просто 1 число, а массив
    }

    int countByUser = GetNumberByUser("Введите число N: ");
    int[] arr = CreateArray(countByUser);
    FillArray(arr);
    string Print = PrintArray(arr);
    int[] colMult = newArray(arr);
    Console.WriteLine(Print);
    // Console.WriteLine(colMult);
    // string Print2 = PrintMult(arr);
    Console.WriteLine(GoodPrint(arr, colMult));