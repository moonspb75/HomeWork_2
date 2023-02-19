// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) 
{
  if (dayNumber == 6 || dayNumber == 7) 
  {
  Console.WriteLine("(этот день выходной) -> да");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("это вообще не день недели");
  }
  else Console.WriteLine("(этот день не выходной) -> нет");
}

CheckingTheDayOfTheWeek(dayNumber);










// int Prompt(string message)
//{
   // Console.Write(message);
    // string value = Console.WriteLine();
    // int result = Convert.ToInt32(value);
    // return result;
//}
// bool IsWeekend(int weekDay)
// {
   // if (weekDay > 5)
   // {
     //   return true;
   // }
  //  return false;
//}
//bool ValidateWeekday(int number)
//{
   // if (number > 0 && number <= 7)
  //  {
   //     return true;
   // }
   // Console.WriteLine("Это не день недели!");
   // return false;
//}

//int weekDay = Prompt("Введите день недели >");
//if (ValidateWeekday(weekDay))
//{
 //   Console.WriteLine("Выходной");
//}
//else
//{
 //   Console.WriteLine("Рабочий день");
//}