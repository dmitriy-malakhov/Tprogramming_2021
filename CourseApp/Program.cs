﻿namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Hello world");
            Console.ReadLine();
            Function function = new Function();
            var start = new Calculation(function);

            var a = 7.2;
            var b = 4.2;
            var xs = 1.81;
            var xe = 5.31;
            var dx = 0.7;
            var listTaskB = new List<double>() { 2.4, 2.8, 3.9, 4.7, 3.16 };

            var listA = start.CalculationTask(a, b, xs, xe, dx);
            var listB = start.CalculationTask(a, b, listTaskB);

            Console.WriteLine("Task A:");
            OutputTask(listA);

            Console.WriteLine("Task B:");
            OutputTask(listB);
        }

        public static void OutputTask(List<double> listTask)
        {
            foreach (var y in listTask)
            {
                Console.WriteLine($"y = {y}");
            }
        }
    }
}
