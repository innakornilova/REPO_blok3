// Напишите программу, которая выводит вторую цифру заданного числа или сообщает, что второй цифры нет.

Console.WriteLine("Введите значение числа А ");
int A = Convert.ToInt32(Console.ReadLine());

if (A < 10)
    Console.WriteLine ("Второй цифры нет");

else 
{
    while (A >= 100) 
    {
       A = A / 10;    
    }    
    Console.Write ("Вторая цифра числа: ");
    Console.WriteLine (A % 10);
}
