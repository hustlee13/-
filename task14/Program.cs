﻿/*14 Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.*/


Console.Clear();
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0)
{
    System.Console.WriteLine("Да");
}
else
System.Console.WriteLine("Нет");