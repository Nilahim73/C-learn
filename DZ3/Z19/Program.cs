// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Палиндромом называют любой симметричный относительно своей середины набор символов.");
Console.Write("Введите 5-ти значное число: ");
string numb = Console.ReadLine()!;

void CheckingNumber(string numb)
{
  if (numb[0]==numb[4] || numb[1]==numb[3])
  {
    Console.WriteLine($"Число: {numb} - палиндром.");
  }
  else Console.WriteLine($"Число: {numb} - Не палиндром.");
}

if (numb!.Length == 5)
{
  CheckingNumber(numb);
}
else Console.WriteLine($"Введите правильное число");