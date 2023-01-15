//

 int GetNumberByUser(string text)
    {
        Console.Write(text + " ");
        return Convert.ToInt32(Console.ReadLine());
    }

int [] CreateArray(int size)
    {
        return new int[size];
    }

void FillArray(int[] colNumber)
    {
        int count = colNumber.Length; 
                
        for (int i = 0; i < count; i++)   
        {
            colNumber[i] = Random.Shared.Next(1, 10); 
        } 
    }

int[] Mult(int[] array)
    {   
        int[] result = new int [array.Length/2]; 
        int count = array.Length;
                
        for (int i = 0; i < count / 2; i++)   
        {
            result[i] = array[i] * array[count - 1 - i];
        } 
                
    return result;
    }

int countByUser = GetNumberByUser("Введите число N: ");
int[] arr = CreateArray(countByUser);
FillArray(arr);
int[] result = Mult(arr);
PrintArray(array);
Console.WriteLine($"({arr}) => {result}");
 