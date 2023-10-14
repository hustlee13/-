/* Напишите программу, которая принимает на вход координаты двух точек и находит
расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21 */

Console.Clear();
System.Console.WriteLine("Введите координаты точки A (x,y): ");
int userAx = Convert.ToInt32(Console.ReadLine());
int userAy = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты точки B (x,y): ");
int userBx = Convert.ToInt32(Console.ReadLine());
int userBy = Convert.ToInt32(Console.ReadLine());

//int squareX = (userBx - userAx) * (userBx - userAx);
double squareX = Math.Pow(userBx - userAx, 2);//Math.Pow(a,2) функция возведения в степень
double squareY = Math.Pow(userBy - userAy, 2);
double rootXY = Math.Sqrt(squareX + squareY);//корень квадратный Math.Sqrt
System.Console.WriteLine(Math.Round(rootXY, 3));//Math.Round(a,2) - округление, где 2 это сколько чисел после запятой оставить