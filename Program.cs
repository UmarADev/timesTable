using System;

Console.WriteLine("Please give me two numbers:");
int firstNum = Convert.ToInt32(Console.ReadLine());
int secondNum = Convert.ToInt32(Console.ReadLine());

for (int i = firstNum; i <= secondNum; i++)
{
    for (int a = 1; a < 11; a++)
    {
        Console.WriteLine($"{i} * {a} = {a*i} \t");
    }
    Console.WriteLine();
}