﻿/*13 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.*/


Console.Clear();
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;

for (int i = number;i>=100; i = i / 10)
{
    result = i % 10;
}
if (number < 100)
{
    System.Console.WriteLine("Третьей цифры нет");
}
else
{
    System.Console.WriteLine(result);
}