// если берем Метод из библиотеки, то перед названием Метода пишем : public static 

// Метод создания массива n1
// int [] CreateArray(int size)
// {
//     return new int[size];
// }

// Метод создания массива n2
// //     int [] <- (int [])
// int [] CreateArr(int number)
// {
//      int[] arr = new int[number]//     
//      return arr;
// }

// Метод заполнения массива 0 и 1
// //    void <- (int[])
    // void GetBinArray(int[] colNumber)
    // {
    //     int count = colNumber.Length; 
    //     colNumber[0] = 1;        // left number != 0              

    //     for (int i = 1; i < count; i++)   
    //     {
    //         colNumber[i] = Random.Shared.Next(2); // Random.Shared.Next(2) - т.е. берет числа <2
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

// // Конвертация из 2го в 10е
//     public static int GetDecArray(int[] binNumber)
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

// Метод перевода числа из 10 в 16 систему
// 0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15
//                      A  B  C  D  E  F 

// int val = 301;
// // 16 система
// while (val != 0)
// {
//     int b = val % 16;
//     if (b == 10) res = $"A{res}";
//     else if (b == 11) res = $"B{res}";
//     else if (b == 12) res = $"C{res}";
//     else if (b == 13) res = $"D{res}";
//     else if (b == 14) res = $"E{res}";
//     else res = $"{b}{res}";
//     val = val / 16;
// }
// Console.WriteLine(res);