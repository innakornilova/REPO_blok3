//

    int[] Mult(int[] array)
    {   
        int[] array = {1, 3, 4, 5, 6};
        int[] result = new int [array.Length/2]; 
        int count = array.Length;
                
        for (int i = 0; i < count / 2; i++)   
        {
            result[i] = array[i] * array[count - 1 - i];
        } 
                
    return result;
    }

    
    Console.WriteLine(result);