/*27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/ 

Console.Clear();
System.Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int Result(int number)
{
    int count = 0;
    for (int i = number; i > 0; i /= 10)
    {
        count = count + i % 10;
    }
    return count;
}
int userCount = Result(n);
System.Console.WriteLine(userCount);