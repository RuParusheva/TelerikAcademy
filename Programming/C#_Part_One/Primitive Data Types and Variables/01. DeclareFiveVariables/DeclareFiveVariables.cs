﻿/*Task 01. Declare five variables choosing for each of them the most appropriate 
of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent 
the following values: 52130, -115, 4825932, 97, -10000.*/

using System;

class DeclareFiveVariables
{
    static void Main()
    {
        ushort firstValue = 52130;
        sbyte secondValue = -115;
        uint thirdValue = 4825932;
        byte forthValue = 97;
        short fifthValue = -10000;
        Console.WriteLine("{0}, {1}, {2}, {3}, {4}", firstValue, secondValue, thirdValue, forthValue, fifthValue);
    }
}

