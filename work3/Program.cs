//Задать номер четверти, показать диапазоны для возможных координат.
Console.WriteLine("Ввести номер четверти в плоскости");
int N = int.Parse(Console.ReadLine());

if (N==1)
{
    Console.WriteLine("x>0, y>0");
} 

else if (N==2)
{
    Console.WriteLine("x<0, y>0");
} 

else if (N==3)
{
    Console.WriteLine("x<0, y<0");
} 

else if (N==4)
{
    Console.WriteLine("x>0, y<0");
} 

 
else 
{
    Console.WriteLine("Это не четверть");
}