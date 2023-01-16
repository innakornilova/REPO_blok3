//
int[] array = {3, 5, 8, 9, 2};
int[] result = {};

int[] Mult(int[] array)
{   
    result = new int[array.Length/2]; 
    int count = array.Length;
                
    for (int i = 0; i < count / 2; i++)   
    {
        Console.WriteLine(result[i] = array[i] * array[count - 1 - i]);
    } 
                
// return result;
}

// Console.WriteLine(result);

 