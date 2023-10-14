/*06 Напишите программу которая на вход принимает число number и выводит, является ли число чётным (делится ли оно на два без остатка).*/

Console.Clear();
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    System.Console.WriteLine("Число чётное");
}
else
if (number % 2 == 1)
{
    System.Console.WriteLine("Число не четное");
}
