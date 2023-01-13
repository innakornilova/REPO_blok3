using static Library;

// Напишите программу, которая выводит массив из N элементов,
// заполненный нулями и единицами в случайном порядке.
// Самое левое число != 0
// Данный массив есть двоичное представление десятичного числа
// [1,0,1,1,0,1,0,0]
// Реализовать перевод двоичного числа в десятичное

// 1. Ввод N
// int <- (string)
// 2. Метод создания массива
// int[] <- (int)
// 3. Метод заполнения массива 0 и 1
// void <- (int[])
// 4. Печать массива
// string <- (int[])
// 5. Конвертация из 2го в 10е
// int <- (int[])
// 6. Красиво распечатать: 10110100 >> 180
// string <- (int[] bin, int dec)

// 76543210 - разряды числа
// 10110100 - число двоичное, т.е.
// 10110100 = 1*2^7 + 0*2^6 + 1*2^5 + 1*2^4 + 0*2^3 + 1*2^2 + 0*2^1 + 0*2^0


async void Task777()
{
    int countByUser = GetNumberByUser("Введите число N: ");
    int[] arr = CreateArray(countByUser);
    GetBinArray(arr);
    int result = GetDecArray(arr);
    string binPrint = PrintArray(arr);
    Console.WriteLine(binPrint);
    Console.WriteLine(GoodPrint(arr, result));
}

Task777();

