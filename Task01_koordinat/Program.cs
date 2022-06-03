// Напишите программу, которая принимает на вход координаты точки (х и у), причем х не равно 0 
// и у не равен 0 и выдает номер четверти плоскости,в которой находится эта точка.
Console.Write("Введите значение х: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите значение y: ");
int y = int.Parse(Console.ReadLine());
if (x !=0 && y!=0)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("Это 1 четверть");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("Это 2 четверть");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("Это 3 четверть");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("Это 4 четверть");
    }
}
else Console.WriteLine("не удовдетворяет условиям задачи (x не равен 0) ");
