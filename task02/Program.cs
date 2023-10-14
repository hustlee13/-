/*02 Написать программу которая на вход принимает два числа и выводит, какое число большее, а какое меньшее.*/

Console.Clear();
System.Console.WriteLine("Введите первое число: ");
int numbOne = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int numbTwo = Convert.ToInt32(Console.ReadLine());

if (numbOne > numbTwo)
{
    System.Console.WriteLine("Первое число больше второго");
}
if (numbOne < numbTwo)
{
    System.Console.WriteLine("Второе число больше первого");
}
else
if (numbOne == numbTwo)
{
    System.Console.WriteLine("Числа равны!!!");
}