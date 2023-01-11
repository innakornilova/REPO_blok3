// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

string GetInfoByDayOfWeek (int day)
{
    if (day < 6)
        return "Рабочий день"; 
    else if (day > 5 && day < 8)
        return "Выходной день";     
    else 
        return "Введите другое число"; 
}

Console.WriteLine(GetInfoByDayOfWeek(day));