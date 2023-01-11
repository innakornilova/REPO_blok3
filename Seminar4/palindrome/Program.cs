// Напишите программу, которая принимает на вход любое число и проверяет, является ли оно палиндромом.

// Для любого числа: abcde = a * 10000 + b * 1000 + c * 100 + d * 10 + e
//                  edcba = e * 10000 + d * 1000 + c * 100 + b * 10 + a

bool Check(long val1)    // long, потому что число может быть более 9ти знаков
{
    long val2 = 0;
    long t = val1;
    while (val1 != 0)  // or (val1 > 0)
    {
        long b = val1 % 10;
        val1 = val1 /10;
        val2 = val2 * 10  + b;
    }
return t == val2;
}
Console.WriteLine(Check(12987678921));