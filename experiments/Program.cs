// 

Console.WriteLine("Введите значение числа ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
    Console.WriteLine ("Третьей цифры нет");

else 
{
    while (number >= 1000) 
    {
       number = number / 10;    
    }    
    Console.Write ("Третья цифра числа: ");
    Console.WriteLine (number % 10);
}