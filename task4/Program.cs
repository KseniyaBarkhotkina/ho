﻿// Напишите программу, которая принимает на вход трёхзначное число и
// на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1000 && number > 99)
{
    int ost = number % 10;
    Console.WriteLine(ost);
}
else 
{
    Console.WriteLine("Введите трехзначное число");
}