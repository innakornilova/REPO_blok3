// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет 
// 12821 -> да 
// 23432 -> да 
// НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ СТРОКИ

Console.WriteLine("Введите значение 5ти значного числа ");
int fiveDigitNum = Convert.ToInt32(Console.ReadLine());

palindrome(fiveDigitNum);

void palindrome(int fiveDigitNum)
{
    if (fiveDigitNum % 10 == fiveDigitNum / 10000)
    {
        if (fiveDigitNum / 10 % 10 == fiveDigitNum / 1000 % 10)
        {
            Console.WriteLine("Это число палиндром");
        }
        else Console.WriteLine("Это число не является палиндромом");
    }
    else Console.WriteLine("Это число не является палиндромом");
}

