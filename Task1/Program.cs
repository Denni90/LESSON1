﻿//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
Console.WriteLine("Введите данные");
Console.WriteLine("a= ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("b= ");
int numberB = Convert.ToInt32(Console.ReadLine());
int max = numberA;
int min = numberA;

if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberA < min) min = numberA;
if (numberB < min) min = numberB;

Console.WriteLine("Результат:");
Console.WriteLine("max =");
Console.WriteLine(max);  
Console.WriteLine("min =");
Console.WriteLine(min);