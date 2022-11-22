/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

int Read(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}


int number = Read("Введите цифру от 1 до 7: ");

if (number <= 5 && number >= 1)
{
    Console.WriteLine("Нет");
}

else if (number == 6 || number == 7)
{
    Console.WriteLine("Ура, да это же выходной!");
}

else
{
    Console.WriteLine("Эта цифра не является обозначением дня недели");
}
