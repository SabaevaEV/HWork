﻿//Задача 4
Console.WriteLine("Введите три числа");
int numberA = int.Parse(Console.ReadLine () !);
int numberB = int.Parse(Console.ReadLine () !);
int numberC = int.Parse(Console.ReadLine () !);
int max = numberA;
if (numberB> max)
{
    max = numberB;
}
if (numberC > max)
{
  max = numberC; 
}
 Console.WriteLine ("Максимальное число - " + max);