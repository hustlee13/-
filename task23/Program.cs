/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.1
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/ 

Console.Clear();
System.Console.Write("Введи число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= userNumber; i++)
{
   System.Console.WriteLine($"{i} * {i} * {i} = {Math.Pow(i,3)}");
}
