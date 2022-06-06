//Напишите прогу, которая на вход принимает число N и выдаете таблицу квадратов чисел 
//от 1 до N  5-> 1,4,9,16,25   2-> 1,4.
// Console.Write("Введите любое число N: ");
// int num = int.Parse(Console.ReadLine());
// for  (int i = 1; i<=num; i++)
// {
//     double sqrt = Math.Pow(i,2); //i*i;
//     Console.Write($" -> {sqrt}");
// }

Console.Write("Введите любое число N: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("|{0,5}|{1,5}|", "Число", "Квадрат");
for (int i = 1; i <= num; i++)
{
    Console.WriteLine("|{0,5}|{1,5}|", i, i * i);
}