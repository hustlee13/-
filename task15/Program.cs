/*15 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.*/ 

System.Console.WriteLine("Введите число: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if(dayNumber <= 5 && dayNumber > 0)
{
    System.Console.WriteLine("Это рабочий день");
}
if (dayNumber == 6 || dayNumber == 7)
{
    System.Console.WriteLine("Выходной");
}
if (dayNumber < 1 || dayNumber > 7)
{
    System.Console.WriteLine("Такого дня недели нет");
}


