// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите значение числа А ");
int A = Convert.ToInt32(Console.ReadLine());

if (A < 100)
    Console.WriteLine ("Третьей цифры нет");

else 
{
    while (A >= 100) 
    {
       A = A / 10;    
    }    
    Console.Write ("Третья цифра числа: ");
    Console.WriteLine (A % 10);
}
 