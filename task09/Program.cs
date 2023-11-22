/*09 Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.*/

Console.Clear();
int number = new Random(). Next(10, 100);
System.Console.WriteLine(number);


int first = number / 10;
int last = number % 10;
if(first > last)
{
    System.Console.WriteLine("Наибольшая " + first);
}
else
{
    System.Console.WriteLine("Наибольшая " + last);
}   





 