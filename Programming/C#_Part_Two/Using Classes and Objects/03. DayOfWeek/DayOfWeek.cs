﻿//Task 03. Write a program that prints to the console which day of the week is today. Use System.DateTime.

using System;

class DayOfWeek
{
    static void Main()
    {
        DateTime dateValue = DateTime.Now;
        Console.WriteLine(dateValue.ToString("dddd"));
    }
}
