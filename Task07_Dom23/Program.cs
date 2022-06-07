// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 
// 1 до N.    5 -> 1, 8, 27, 64, 125. 3 -> 1, 8, 27 
Console.Write("Введите число (N): ");
int num = int.Parse(Console.ReadLine());

void GetCube(int number)
{
    Console.WriteLine("|{0,5}|{1,5}|", "число", "куб");
    for (int i = 1; i <= number; i++)
    {
        double result = Math.Pow(i, 3);
        Console.WriteLine("|{0,5}|{1,5}|", i, result);
    }

}
GetCube(num);
