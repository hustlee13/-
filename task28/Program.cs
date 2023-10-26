/*28. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120*/

Console.Clear();
System.Console.WriteLine("Введите число: ");
int userNum = Convert.ToInt32(Console.ReadLine());

int Sum(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        result = result * i;
    }
    return result;
}
int userSum = Sum(userNum);
System.Console.WriteLine(userSum);