// Заполнение таблицы цифрами


void PrintArray(int[,] matr)
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

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // matrix.Get.Length(0) - это отсылка к количеству строк в матрице 
    {
        for (int j = 0; j < matr.GetLength(1); j++) //matrix.Get.Length(1) - это отсылка к количеству столбцов в матрице
        {
            matr[i, j] = new Random().Next(1, 10); // случайное заполнение числами от 1 до 9
        }
    }
}

int[,] matrix = new int [3, 4]; //размер массива задается сразу
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine(); // пропускаем строку для красоты печати
PrintArray(matrix);