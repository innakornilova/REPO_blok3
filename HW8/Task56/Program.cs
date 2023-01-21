// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] matrix = new int[4, 4] {{1, 4, 7, 2},
                               {5, 9, 2, 3},
                               {8, 4, 2, 4},
                               {5, 2, 6, 7}};

void Pprint(int[,] m)
{
    for (int i = 0; i < m.GetLength(0); i++)
    {
        for (int j = 0; j < m.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3}"); // 3 - это отступы между выводом
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindMinRow(int[,] matrix)
    {
        int minRow = 0;
        int numRow = 0;
        int sumRow = 0;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            minRow = minRow + matrix[0, i];
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sumRow = sumRow + matrix[i, j];
            }
            if (sumRow < minRow)
            {
                minRow = sumRow;
                numRow = i;
            }
            sumRow = 0;
        }
        Console.WriteLine($"\nНомер строки с наименьшей суммой элементов: {numRow + 1}");
    }

Pprint(matrix);
FindMinRow(matrix);
