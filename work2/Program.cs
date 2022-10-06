//По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Введите первое число");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int n2 = int.Parse(Console.ReadLine());

if (n1==n2*n2)
{
    Console.Write("Первое число - квадрат второго");
}
else 
{
    Console.Write("Первое число не является квадратом второго");
} 