Console.WriteLine("Введите значение числа N");
int N = Convert.ToInt32(Console.ReadLine());

int [] array = {1, 2, 3, 4, 5};
int N = array.Length;
int index = 0;

while (index < array.Length)
{
    if (array[index] % 2 == 0) 
    {
        Console.WriteLine (array[index]);
    }

    index ++;   

}