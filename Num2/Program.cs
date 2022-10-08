/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6*/


Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());
if (num > 99)
{
Console.WriteLine("Третья цифра "+num.ToString()+" = "+num.ToString()[2]);
}
else
Console.WriteLine("Нет третьей цифры");