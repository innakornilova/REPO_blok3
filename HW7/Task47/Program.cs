// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // matrix.Get.Length(0) - это отсылка к количеству строк в матрице 
    {
        for (int j = 0; j < matr.GetLength(1); j++) //matrix.Get.Length(1) - это отсылка к количеству столбцов в матрице
        {
            Console.Write($" {matr[i, j]} "); // пробегаем по всем элементам столбика
        }
    Console.WriteLine(); // переход на новую строку для цифр следующей строчки
    }
}

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // matrix.Get.Length(0) - это отсылка к количеству строк в матрице 
    {
        for (int j = 0; j < matr.GetLength(1); j++) //matrix.Get.Length(1) - это отсылка к количеству столбцов в матрице
        {
            matr[i, j] = new Random().Next(-30, 30); // случайное заполнение вещественными числами
        }
    }
}

double[,] matrix = new double [3, 4]; //размер двумерного массива задается сразу
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine(); // пропускаем строку для красоты печати
PrintArray(matrix);
