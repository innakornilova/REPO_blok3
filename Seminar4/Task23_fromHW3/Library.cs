public static class Library
{
    // 1. Метод считывания от пользователя N
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

    // 3. Метод получения кубов чисел
    public static void GetCubing(int[] colNumber)
    {
        int count = colNumber.Length;

        for (int i = 0; i < count; i++)
        {
            colNumber[i] = (i * i * i); // Math.Pow(i, 3);
        }
    }
    // 4. Распечатать результат
    public static string Print(int[] numbers)
    {
        string output = String.Empty;
        int size = numbers.Length;

        for (int i = 0; i < size; i++)
        {
            output = output + $"{i}^3 = {numbers[i]}\n";
        }

        return output;
    }

    // 5. Красиво распечатать результат
    public static string RanderMD(int[] numbers)
    {
        string output = String.Empty;
        int size = numbers.Length;

        for (int i = 0; i < size; i++)
        {
            output = output + $"- {i}<sup>3</sup> = **{numbers[i]}**\n";
        }

        return output;
    }
}