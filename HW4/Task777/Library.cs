public static class Library
{
    // 1. Метод ввода N
    public static int GetNumberByUser(string text)
    {
        Console.Write(text + ": ");
        return Convert.ToInt32(Console.ReadLine());
    }
// 2. Метод создания массива
    public static int [] CreateArray(int size)
    {
        return new int[size];
    }
// 3. Метод заполнения массива 0 и 1
    public static void GetBinArray(int[] colNumber)
    {
        int count = colNumber.Length; 
        colNumber[0] = 1;        // left number != 0              

        for (int i = 1; i < count; i++)   
        {
            colNumber[i] = Random.Shared.Next(2); 
        }
    }

// 4. Печать массива
    public static string PrintArray(int[] numbers)
    {
        string output = String.Empty;
        int size = numbers.Length;

        for (int j = 0; j < size; j++)
        {
            output = output + $"{numbers[j]} ";
        }
        return output;
    }

// 5. Конвертация из 2го в 10е
    public static int GetDecArray(int[] binNumber)
    { 
        int count = binNumber.Length;
        int exponent = binNumber.Length-1;
        int result = 0;
        
        for (int m = 0; m < binNumber.Length; m++)   
        {
            if (binNumber[m] == 1)
            {
                result += Convert.ToInt32(Math.Pow(2, exponent)); // result = result +
            } 
            exponent --;
        }
    return result;
    }

// 6. Красиво распечатать: 10110100 >> 180
// string <- (int[], int])
    public static string GoodPrint(int[] bin, int dec)
    {
        return $"{String.Join("", bin)} >> {dec}";
    }
}

