// Задача 8
Console.WriteLine("Введите число:");
int numberN = int.Parse(Console.ReadLine () !);
int x = 1;
while (x < numberN)
{
    if ( x % 2 ==0)
    Console.WriteLine( x + " ");
    x = x + 1;
}
