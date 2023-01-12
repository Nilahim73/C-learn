// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введи трёхзначное число: ");

int numb = Convert.ToInt32(Console.ReadLine());
string stringNumb = Convert.ToString(numb);

Console.WriteLine("Вторая цифра числа >?> "+stringNumb[1]);
