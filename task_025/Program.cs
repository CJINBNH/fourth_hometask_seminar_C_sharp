﻿// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();
Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result = result * A;
    }
     if (A == 1 || B == 0)
    {
        result = 1;
    }
    else if (B == 1)
    {
        result = A;
    }

Console.WriteLine(result);