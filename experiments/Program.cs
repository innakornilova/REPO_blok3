//
Console.WriteLine("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

int num = 1;
void ColNum(int num)
{
        if(num % num == 0)
        {
           Console.Write(num + " ");
            // Console.WriteLine($"Все натуральные числа в промежутке от N до 1: {num}");
        }
        num++;
    if(num > N) 
    return;
    ColNum(num);
}
ColNum(num);