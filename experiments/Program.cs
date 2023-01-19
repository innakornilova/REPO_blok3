//

string[] data = Console.ReadLine().Split(' ');
for (int i = 0; i < data.Length; i++)
{
    Console.Write(" " + int.Parse(data[i]) + ",");
}
Console.WriteLine();


int Count(int[] origArray)
{
    int count;
    count = 0;

    for (int i = 0; i < origArray.Length; i++)
    {
        if (origArray[i] > 0) count++;
    }
return count;
}


Console.WriteLine(count);