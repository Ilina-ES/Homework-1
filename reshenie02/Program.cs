﻿//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (numberB > max) 
{
    max = numberB;
    if (max > numberC) 
    {
        System.Console.WriteLine(numberB+" максимальное число");
    }
    else
    {
        System.Console.WriteLine(numberC+" максимальное число");
    }
}
else
{
    if (numberC > max) 
    {
        System.Console.WriteLine(numberC+" максимальное число");
    }
    else
    {
        System.Console.WriteLine(numberA+" максимальное число");
    }
}