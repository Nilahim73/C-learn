﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 2;
if(n > 1)
{
    while(i <= n)
    {
        Console.Write(i + " ");
        i = i + 2;
    }
}
Console.WriteLine(" ");