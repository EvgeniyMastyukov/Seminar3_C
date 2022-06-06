//Напишите прогу, которая по заданному номеру четверти, показывает диапозон возможных 
//координат точек в этой  четверти (х и у).
Console.Write("Введите четверть координат: ");
int numCoord = int.Parse(Console.ReadLine());

void GetRange(int number)
{
    if(number == 1) Console.WriteLine("х = от 0 до ++. у = от 0 до ++ ");
    else if(number == 2) Console.WriteLine("х = от 0 до --. у = от 0 до ++ ");
    else if(number == 3) Console.WriteLine("х = от 0 до --. у = от 0 до -- ");
    else if(number == 4) Console.WriteLine("х = от 0 до ++. у = от 0 до -- ");
    
}
GetRange(numCoord);