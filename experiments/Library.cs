// если используем Метод из библиотеки, то перед названием Метода пишем : public static (см. HW4\Task777)


// //Метод запроса числа у пользователя
// int GetNumberByUser(string text)
// {
//     Console.WriteLine("Введите значение числа N ");
//     double number = Convert.ToInt32(Console.ReadLine());
// }


// //Метод генерации случайного размера массива
// int[] CreateArr()
// {
//     int createArr = new int[Random.Shared.Next(10,20)];
//     return createArr;
// }


// // Метод ввода N
//  int GetNumberByUser(string text)
// {
//     Console.Write(text + ": ");
//     return Convert.ToInt32(Console.ReadLine());
// }


// //Метод создания массива n*1
// int [] CreateArray(int size)
// {
//     return new int[size];
// }


// //Метод создания массива n*2
// //     int [] <- (int [])
// int [] CreateArr(int number)
// {
//      int[] arr = new int[number]     
//      return arr;
// }


// //Метод заполнения массива рандомными числами (например, от 0 до 9)
    // void FillArray(int[] colNumber)
    // {
    //     int count = colNumber.Length; 
                
    //     for (int i = 0; i < count; i++)   
    //     {
    //         colNumber[i] = Random.Shared.Next(1, 10); 
    //     } 
    // }


// //Метод заполнения массива 0 и 1
// //    void <- (int[])
    // void FillBinArray(int[] colNumber)
    // {
    //     int count = colNumber.Length; 
    // //   colNumber[0] = 1;        // if left number != 0              

    //     for (int i = 0; i < count; i++)   
    //     {
    //         colNumber[i] = Random.Shared.Next(2); // Random.Shared.Next(2) - т.е. берет числа <2
    //// ex.int[] arr = Enumerable.Range(1, N).ToArray();
    //     }
    // }


// Метод копирования массива
// void ClonArray(int[] filledArray, int[] x)
// {
//     int count = filledArray.Length; 
                
//     for (int i = 0; i < count; i++)   
//     {
//     x[i] = filledArray[i]; 
//     } 
// }


// // Печать массива
// // string <- (int[])
//     string PrintArray(int[] numbers)
//     {
//         string output = String.Empty;
//         int size = numbers.Length;

//         for (int j = 0; j < size; j++)
//         {
//             output = output + $"{numbers[j]} ";
//         }
//         return output;
//     }


// // Красиво распечатать: 10110100 >> 180
// // string <- (int[], int])
//     string GoodPrint(int[] bin, int dec)
//     {
//         return $"{String.Join("", bin)} >> {dec}";
//     }


// // Конвертация из 2го в 10е
// // int [] <- (int[])
//     int GetDecArray(int[] binNumber)
//     { 
//         int count = binNumber.Length;
//         int exponent = binNumber.Length-1;
//         int result = 0;
        
//         for (int m = 0; m < binNumber.Length; m++)   
//         {
//             if (binNumber[m] == 1)
//             {
//                 result += Convert.ToInt32(Math.Pow(2, exponent)); // result = result +
//             } 
//             exponent --;
//         }
//     return result;
//     }


// //Метод перевода числа из 10 в 16 систему
// //0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15
//  //                    A  B  C  D  E  F 

// int val = 301231;
// // 16 система
// string res = "";
// while (val != 0)
// {
//     int b = val % 16;
//     if (b == 10) res = $"A{res}";
//     else if (b == 11) res = $"B{res}";
//     else if (b == 12) res = $"C{res}";
//     else if (b == 13) res = $"D{res}";
//     else if (b == 14) res = $"E{res}";
//     else if (b == 15) res = $"F{res}";
//     else res = $"{b}{res}";
//     val = val / 16;
// }
// Console.WriteLine(res);


// // Создание таблицы 2 row and 5 colomns

// string[,] table = new string [2, 5]; // двумерные массивы - обязательно нужна запятая в []
// table[1, 2] = "world"; // мы обращаемся к определенной ячейке таблицы

// // String.Empty
// // table [0, 0] [0, 1]....[0, 4]
// // table [1, 0] [1, 1]....[1, 4]

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine ($"-{table[rows, columns]}-");
//     }
// }


// // Создание таблицы с цифрами

// int[,] matrix = new int [3, 4];

// int[,] matrix = new int [3, 4]; //размер массива (матрицы) задается сразу

// for (int i = 0; i < matrix.GetLength(0); i++) // matrix.Get.Length(0) - это отсылка к количеству строк в матрице 
// {
//     for (int j = 0; j < matrix.GetLength(1); j++) //matrix.Get.Length(1) - это отсылка к количеству столбцов в матрице
//     {
//         Console.Write($" {matrix[i, j]} "); // пробегаем по всем элементам столбика
//     }
// Console.WriteLine(); // переход на новую строку для цифр следующей строчки
// }


// Void FillImage(int row, inr col) //метод закрашивания картинки внутри плюсов
// {
//      if (pic[row, col] ==0)
//      {
//          pic[row, col] = 1;
//          FillImage(row -1, col - 1);
//          FillImage(row +1, col);
//          FillImage(row, col + 1);
//      }
// }
//
// PrintImage(pic);
// FillImage (13, 13);  // указываем начальную точку внутри изображения
// PrintImage(pic);


// Метод нахождения факториала
// double Factorial(int n)
// {
//     if (n== 1) return 1;             // 1! = 1, 0! = 1 (n! - факториал)
//     else return n * Factorial(n - 1); // return пишем обязательно, так как выше тоже return
// }
// for (int i = 1; i < 40; i++)
// {
//      Console.WriteLine($"{i}! = {Factorial(i)}");
// } 


// Метод нахождения чисел Фибоначчи 
// double Fibonacci(int n) // int n - это аргумент
// {
//     if (n== 1 || n == 2) return 1;             // 1! = 1, 0! = 1 (n! - факториал)
//     else return Fibonacci(n-1) + Fibonacci(n-2);// return пишем обязательно, так как выше тоже return
// }
// for (int i = 1; i < 45; i++)
// {
//      Console.WriteLine($"f({i}) = {Fibonacci(i)}");
// } 