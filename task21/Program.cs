﻿/*21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. 
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/ 

Console.Clear();
System.Console.WriteLine("Введите координаты точки A (x,y,z): ");
int userAx = Convert.ToInt32(Console.ReadLine());
int userAy = Convert.ToInt32(Console.ReadLine());
int userAz = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты точки B (x,y,z): ");
int userBx = Convert.ToInt32(Console.ReadLine());
int userBy = Convert.ToInt32(Console.ReadLine());
int userBz = Convert.ToInt32(Console.ReadLine());

double squareX = Math.Pow(userBx - userAx, 2);
double squareY = Math.Pow(userBy - userAy, 2);
double squareZ = Math.Pow(userBz - userAz, 2);
double rootXYZ = Math.Sqrt(squareX + squareY + squareZ);
System.Console.WriteLine(Math.Round(rootXYZ, 2));