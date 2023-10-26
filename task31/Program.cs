﻿/*Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20*/ 


Console.Clear();
int[] GetRandArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i]= new Random().Next(-9, 10);
    }
    return array;
}
void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if(i < arr.Length -1)
        System.Console.Write(", ");
    }
    System.Console.Write("]");
    System.Console.WriteLine();
}

void Sum(int[] array)
{
    int sum1 = 0;
    int sum2 = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        sum1 = sum1 + array[i];
        else
        sum2 = sum2 + array[i];
    }
    System.Console.WriteLine(sum1); 
    System.Console.WriteLine(sum2);
}
System.Console.WriteLine("Введите размер массива: ");
int userSize = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetRandArray(userSize);
PrintArray(userArray);
Sum(userArray);

