// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] matrix = new int[3, 4] {{1, 4, 7, 2},
                               {5, 9, 2, 3},
                               {8, 4, 2, 4}};  //задали массив


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

Pprint(matrix);

double average = 0;
int count = 0;
for (int j = 0; j < matrix.GetLength(1); j++)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        average += matrix[i, j];
        count++;
    }
    average /= count;
    Console.WriteLine($"Среднее арифметическое столбца {j + 1}: {average}");
    average = 0;
    count = 0;
}