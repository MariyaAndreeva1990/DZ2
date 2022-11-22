/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

int Read(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}

int number = Read("Введите целое трехзначное число: ");
if((999 > number && number > 99) || number < (-99) && number > (-999))
{
Console.WriteLine(((number % 100) - number % 10) / 10);
}
else
{
Console.WriteLine ("Вы ввели не трехзначное число");
}