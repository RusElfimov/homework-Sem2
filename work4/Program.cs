// Программа проверяет пятизначное число на палиндромом.    
Console.WriteLine("Введите пятизначное число");
int n = int.Parse(Console.ReadLine());
int first = (n/10000);
int second = (n/1000)%10;
int penultimate = (n%100)/10;
int last = (n%10);

if (first-last==0)
  if (second-penultimate==0)
  {
    Console.Write("Палиндром");
  }
  else 
  {
    Console.Write("Не палиндром");
  }
else
{
    Console.Write("Не палиндром");
}
