//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.WriteLine("Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N");
Console.WriteLine("a= ");
int numberA = Convert.ToInt32(Console.ReadLine());
int i = 0;

void program (int numberA) 
{
    for (i = 2; i <= numberA; i++)
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }  
}
program (numberA);