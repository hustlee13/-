/* 7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

456 -> 6
782 -> 2
918 -> 8 */

Console.Clear();
System.Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;

if(number > 99 && number < 1000)
{
    result = number % 10;
}
else 
{
    System.Console.WriteLine("Число не трехзначное");
}
System.Console.WriteLine(result);
