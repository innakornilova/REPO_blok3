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
        return new int[size + 1];
    }
// 3. Метод заполнения массива 0 и 1
    public static void GetBinArray(int[] colNumber)
    {
        int count = colNumber.Length; 
        colNumber[0] = 1;        // left number != 0              

        for (int i = 1; i < count; i++)   
        {
            colNumber[i] = Random.Shared.Next(1); 
        }
    }

// 4. Печать массива
    public static string PrintArray(int[] numbers)
    {
        string output = String.Empty;
        int size = numbers.Length;

        for (int i = 0; i < size; i++)
        {
            output = output + $"{("", numbers[i])}\n";
        }

        return output;
    }

// 5. Конвертация из 2го в 10е
    public static void GetDecArray(int[] decNumber)
    { 
        int degree = 0;
        int finalNumber = 0;
        int val1 = 0;
        
        while (output > 0)   
        {
            val1 = output % 10 * 2 ^ degree; 
            finalNumber = finalNumber + val1;
            output = output / 10;
            degree++;
        }
    }

// 6. Красиво распечатать: 10110100 >> 180

}