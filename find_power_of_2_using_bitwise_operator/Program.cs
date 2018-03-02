﻿/*
 *   C# Program to Find Power of 2 using Bitwise Operator
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace find_power_of_2_using_bitwise_operator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int num;
            Console.Write("Enter a number:");
            num = Convert.ToInt32(Console.ReadLine());
            bool result = ((num & -num) == num);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
