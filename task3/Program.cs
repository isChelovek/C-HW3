﻿// Задача 23
// 
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

using System;
using static System.Console;

Clear();

Write("Введите число: ");
int n = int.Parse(ReadLine());
int i = 1;
while (i <= n)
{
    Write(Math.Pow(i, 3));
    Write(i < n ? ", " : ".");
    i++;
} 