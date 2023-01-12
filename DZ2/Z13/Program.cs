// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");

int numb = Convert.ToInt32(Console.ReadLine());
string stringNumb = Convert.ToString(numb);

if (stringNumb.Length > 2)
{
  Console.WriteLine("Третья цифра : " + stringNumb[2]);
}
else {
  Console.WriteLine("!Третьей цифры нет!");
}
