// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. 14212 -> нет ; 23432 -> да; 12821 -> да


Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());

if ((num / 10000) > 0 && (num / 10000) < 10)
{
    Console.WriteLine("Пятизначное число  " + num);
    int digit1 = num / 10000;
    int digit2 = num % 10000 / 1000;
    int digit4 = num / 10 % 10;
    int digit5 = num % 10;
    if (digit1 == digit5 && digit2 == digit4)
    {
        Console.WriteLine($"Число {num} является палиндромом");
    }
    else Console.WriteLine($"Число {num} не является палиндромом");
}
else while ((num / 10000) == 0 || (num / 10000) > 9)
    {
        Console.WriteLine("Введите пятизначное число корректно: ");
        num = int.Parse(Console.ReadLine());
    }
FindPalindrom(num);

void FindPalindrom(int number)
{
    Console.WriteLine("Пятизначное число  " + number);
    int digit1 = number / 10000;
    int digit2 = number % 10000 / 1000;
    int digit4 = number / 10 % 10;
    int digit5 = number % 10;
    if (digit1 == digit5 && digit2 == digit4)
    {
        Console.WriteLine($"Число {num} является палиндромом");
    }
    else Console.WriteLine($"Число {num} не является палиндромом");

}


