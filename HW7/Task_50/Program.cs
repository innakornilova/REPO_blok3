// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] matrix = new int[3, 4] {{1, 4, 7, 2},
                               {5, 9, 2, 3},
                               {8, 4, 2, 4}};  //задали массив

Console.Write("Введите позицию строки элемента: ");
int point_i = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите позицию столбца элемента: ");
int point_j = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

for (int i = 0; i < matrix.GetLength(0); i++)
{
    if (point_i == i + 1)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (point_j == j + 1)
            {
                Console.WriteLine($"Значение [{point_i}, {point_j}] элемента массива: {matrix[i, j]}");
            }
        }
    }

}
if (point_i > matrix.GetLength(0) || point_j > matrix.GetLength(1))
{
    Console.WriteLine("Указанного элемента в данном массиве нет:(");
}


// Внешний цикл заходит в первую строку, 
// ищет по столбцам этой строки при помощи внутреннего цикла нужный элемент, и так по всем строкам.
