// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите значение числа А ");
int A = Convert.ToInt32(Console.ReadLine());


int B = A % 100 % 10;

if (A < 100)
{
    Console.WriteLine ("Третьей цифры нет");
}
else 
{
    Console.Write ("Третья цифра чила: ");
    Console.WriteLine (B);
}       