﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите значение числа A");
int A = Convert.ToInt32(Console.ReadLine());

int D = A / 10 % 10;

Console.Write("Вторая цифра числа:");
Console.WriteLine(D);