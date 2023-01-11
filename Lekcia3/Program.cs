// Методы c#

// Метод 1. Ничего не вызывает и ничего не возращает

void Method1()
{
    Console.WriteLine("Author ");
}

Method1(); //вызываем этот метод


// Метод 2. Ничего не возращает, но может принимать

void Method2 (string msg)
{
    Console.WriteLine(msg);
}

Method2("Text");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Text", count: 4);

// Метод 3. Метод, который что-то возращает, но не принимает.

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3(); // вызов метода

Console.WriteLine(year);

//Метод 4. Метод, который принимает и возвращает что-то.

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = string.Empty;
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "abc");
// Console.WriteLine(res);

string Method4(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "a");
Console.WriteLine(res);

for (int i = 2; i < 10; i++)
{
    for (int j = 2; j < 10; j++)
    {
        Console.WriteLine ($"{i} * {i} = {i*j}");
    }
    Console.WriteLine ();
}