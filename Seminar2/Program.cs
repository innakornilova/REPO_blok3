//  Написать программу, которая на вход получает массив,
//  а на выходе собирает новый массив только из чисел, кратных 5

// метод создания массива
// diagram
// метод заполнения массива
// diagram
// метод подсчета чисел кратных 5
// diagram
// решение задачи 
// diagram
// печать


int [] array = {45, 80, 33, 75, 60, 13};

int count = 0;
int index;
index = 0;

while(index < array.Length)
{
    if (array[index] % 5 == 0)
    {
        count++;
    }
    index++;
}

int [] arrayNew = new int[count];
index = 0;
int indexNew = 0;

while (index < array.Length)
{
   if (array[index] % 5 == 0)
   {
        arrayNew[indexNew] = array[index];
        indexNew++;
   }
    index ++;   
}
Console.WriteLine(arrayNew);
index=0;
while(index <array.Length)
{
System.Console.WriteLine(arrayNew[index]);
index++;
}

