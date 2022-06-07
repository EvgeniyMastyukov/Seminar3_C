//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит 
//расстояние между ними в 3D пространстве. A (3,6,8); B (2,1,-7), -> 15.84 
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введем координату x точки А: ");
int xA = int.Parse(Console.ReadLine());
Console.WriteLine("Введем координату y точки А: ");
int yA = int.Parse(Console.ReadLine());
Console.WriteLine("Введем координату z точки А: ");
int zA = int.Parse(Console.ReadLine());
Console.WriteLine("Введем координату x точки B: ");
int xB = int.Parse(Console.ReadLine());
Console.WriteLine("Введем координату y точки B: ");
int yB = int.Parse(Console.ReadLine());
Console.WriteLine("Введем координату z точки B: ");
int zB = int.Parse(Console.ReadLine());

double FindDist(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double dist = Math.Sqrt((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2)) 
    + (Math.Pow((z2 - z1), 2)));

    return dist;
}

double distance = FindDist(xA, xB, yA, yB, zA, zB);
Console.WriteLine("Расстояние между точками A и B = {0: 0.00}", distance);
