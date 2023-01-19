// даны координаты. нужно увеличить их в 10 раз 
using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)"     // пробелов в скобках быть не должно
                .Replace("(", "")         // заменяем в тексте ( на пустоту
                .Replace(")", "")         // заменяем в тексте ) на пустоту
                ;
Console.WriteLine(text);

var data = text.Split(" ")
                .Select(item => item.Split(','))   // делаем выборку, чтобы получить массив координат (массива)
                .Select(e=> (x: int.Parse(e[0]), y: int.Parse(e[1])))  // делаем выборку, чтобы превратить массив координат в кортеж чисел
                .Where(e=> e.x % 2 ==0) // если координата ч точки четная, то выполняется след.действие
                .Select(point => (point.x*10, point.y))  // x*10 т.е координата x умножается на 10
                .ToArray();

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]); // data[i] - это массив // получим столбец из цифр массива 

    // for (int k = 0; k < data[i].Length; k++)
    // {
    Console.WriteLine();
}
