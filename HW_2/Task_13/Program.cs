// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите значение числа А ");
int A = Convert.ToInt32(Console.ReadLine());

if (A < 100)
{
    Console.WriteLine ("Третьей цифры нет");
}
else 
{
    if (A < 1000) 
    {
       int B = A % 100;    
    }
   
Console.Write ("Третья цифра чила: ");
Console.WriteLine (B);
}       