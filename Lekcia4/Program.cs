// Заполнение таблицы 2 row and 5 colomns

string[,] table = new string [2, 5];
table[1, 2] = "world"; // мы обращаемся к определенной ячейке таблицы

// String.Empty
// table [0, 0] [0, 1]....[0, 4]
// table [1, 0] [1, 1]....[1, 4]

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine ($"-{table[rows, columns]}-");
    }
}
