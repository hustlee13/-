/*10 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.*/

Console.Clear();
System.Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
if (number < 1000 && number > 99)
{
    result = number / 10 % 10;
}
else
{
    System.Console.WriteLine("Число не трёхзначное");
}
System.Console.WriteLine(result);