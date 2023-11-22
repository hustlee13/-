/*48. Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3 
1 2 3 4
2 3 4 5*/ 


Console.Clear();
int[,] GetRandomArray(int strg, int stlb)
{
    int[,] array = new int[strg, stlb];
    for (int i = 0; i < strg; i++)
    {
        for (int j = 0; j < stlb; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

void PrintArray(int[,] arr)
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
System.Console.WriteLine("Введите кол-во строк: ");
int userStrg = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите кол-то столбцов: ");
int userStlb = Convert.ToInt32(Console.ReadLine());
int[,] userArray = GetRandomArray(userStrg, userStlb);
PrintArray(userArray);