/*04 Напишите программа которая принимает на вход три числа и выдаёт максимальное из этих чисел.*/

Console.Clear();
System.Console.WriteLine("Введите первое число: ");
int numbOne = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int numbTwo = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третье число:");
int numbThree = Convert.ToInt32(Console.ReadLine());

int max = numbOne;

if (max < numbTwo) 
max = numbTwo;

if (max < numbThree) 
max = numbThree;

System.Console.WriteLine($"Максимальное число:{max}");

