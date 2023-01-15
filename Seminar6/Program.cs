// Задача 45: Напишите программу,
// которая будет создавать копию заданного 
// массива с помощью поэлементного копирования


int GetNumberByUser(string text)
{
    Console.Write(text + ": ");
    return Convert.ToInt32(Console.ReadLine());
}

int [] CreateArray(int number)
{
    int[] arr = new int[number]     
     return arr;
}

void FillArray(int[] colNumber)
{
    int count = colNumber.Length; 
                
    for (int i = 0; i < count; i++)   
    {
    colNumber[i] = Random.Shared.Next(1, 10); 
    } 
}

void ClonArray(int[] filledArray, int[] x)
{
    int count = filledArray.Length; 
                
    for (int i = 0; i < count; i++)   
    {
    x[i] = filledArray[i]; 
    } 
}
int [] CreateArray2(int[] arr)
{
    int[] createdArray = new int[arr.Length];     
    return createdArray;
}

    int countByUser = GetNumberByUser("Введите число N: ");
    int[] arr = CreateArray(countByUser);
    int[] arr2 = CreateArray2(array);
    FillArray(arr);
    ClonArray(arr, arr2);

    
