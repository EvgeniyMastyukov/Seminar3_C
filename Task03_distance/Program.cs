//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и
//находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 . A (7,-5); B (1,-1) -> 7,21

double FindDist(int[] pointA, int[] pointB)
{
    double product = 0;
    for (int i = 0; i < 2; i++)
    {
        product = product + ((pointB[i] - pointA[i]) * (pointB[i] - pointA[i]));
    }
    double distance = Math.Sqrt(product);
    return distance;
}
Console.WriteLine("Введем координату x точки А: ");
int[] pointA = new int[2];
pointA[0] = int.Parse(Console.ReadLine());
Console.WriteLine("Введем координату y точки А: ");
pointA[1] = int.Parse(Console.ReadLine());
Console.WriteLine("Введем координату x точки B: ");
int[] pointB = new int[2];
pointB[0] = int.Parse(Console.ReadLine());
Console.WriteLine("Введем координату y точки B: ");
pointB[1] = int.Parse(Console.ReadLine());

double dis = FindDist(pointA, pointB);
Console.WriteLine("Расстояние между точкой A и B = {0: 0.00}", dis);




