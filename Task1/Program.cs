/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

int Read(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}

int Exam (int n)
{
    int s = n / 100;
    return s;
}

int number = Read("Введите целое число: ");
if(Exam (number) >= 1 || Exam (number) <= (-1))
{
Console.WriteLine(((number % 1000) - number % 100) / 100);
}
else
{
Console.WriteLine ("Третьей цифры нет");
}