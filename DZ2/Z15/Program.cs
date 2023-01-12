// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите цифру, обозначающую день недели: ");
int dayNumb = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumb) 
{
  if (dayNumb == 6 || dayNumb == 7) 
  {
  Console.WriteLine("Да, выходной");
  }
  else if (dayNumb < 1 || dayNumb > 7) 
  {
    Console.WriteLine("!Введена несоответствующая цифра!");
  }
  else Console.WriteLine("Рабочий день");
}

CheckingTheDayOfTheWeek(dayNumb);
