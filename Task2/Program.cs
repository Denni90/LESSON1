//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.WriteLine("Введите данные");
Console.WriteLine("a= ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("b= ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("c= ");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;

if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;   
     
        
Console.WriteLine("Результат:");
Console.WriteLine("max =");
Console.WriteLine(max);