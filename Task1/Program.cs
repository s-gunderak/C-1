﻿// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

Console.Clear();
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine();
int num2 = int.Parse(Console.ReadLine());
int num2SQR = num2 * num2;
if (num2SQR == num1)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}
