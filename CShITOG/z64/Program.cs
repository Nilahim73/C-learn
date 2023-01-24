// Задайте значения M и N. Напишите программу, которая найдёт произведение натуральных элементов в промежутке от M до N.
// Сделал по комментарию в последнем семинаре(9) - тайминг 2:12:36

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine()!);
}
int CountNaturalSum(int m, int n)
{
    if (m == n)
        return n;
    return n * CountNaturalSum(m, n - 1);
}
int m = InputInt("Введите M: ");
int n = InputInt("Введите N: ");
Console.WriteLine($"Сумма элементов от {m} до {n} = {CountNaturalSum(m, n)}");