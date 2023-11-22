/*47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.*/ 

int Message(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

Console.Clear();
double[,] GetRandom2Array(int start, int end, int strg, int stlb)
{
    double[,] array = new double[strg, stlb];
    for (int i = 0; i < strg; i++)
    {
        for (int j = 0; j < stlb; j++)
        {
            array[i, j] = Math.Round((new Random().Next(-10, 10) + new Random().NextDouble()),2);
        }
    }
    return array;
}

void PrintArray(double[,] arr)
{
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j]+ "\t");
           
        }
        System.Console.WriteLine();  
    }
}

int userStrg = Message("Введите кол-во строк: ");
int userStlb = Message("Введите кол-во строк: ");
int userStart = Message("Введите начало диапазона: ");
int userEnd = Message("Введите конец диапазона: ");
double[,] userArray = GetRandom2Array(userStart, userEnd, userStrg, userStlb);
PrintArray(userArray);
