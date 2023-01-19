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

Split (matrix); 
Select(e=> (x: int.Parse(e[0]), y: int.Parse(e[1]))); 

void Average(int[,] matrix2D)
{
    for (int k = 0; k < matrix.GetLength(0); k++)
    {  
        int result = 0;
        int size = matrix.GetLength(1);
        for (int i = 0; i < size - 1; i++)   // почему размер -1?
        {
            result = result ;
        }
    }
}

Pprint(matrix);
Average(matrix);
int result = ;
Pprint(result);