// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.Write("Большее число:");
    Console.WriteLine(num1);
    Console.Write("Меньшее число:");
    Console.WriteLine(num2);
}

else {
    Console.Write("Большее число:");
    Console.WriteLine(num2);
    Console.Write("Меньшее число:");
    Console.WriteLine(num1);
}