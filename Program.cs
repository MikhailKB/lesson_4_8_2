using System;
using static System.Console;

namespace lesson_4_8_2
{
    internal class Program
    {
        static void Main(string[] args)  // точка входа
        {
            WriteLine("\nВведите длину последовательности и нажмите\"Enter\": ");
            string sequences = ReadLine();
            int n = int.Parse(sequences);
            int[] numb = new int[n];
            WriteLine("\nВведите целые положительные или отрицательные числа и нажмите \"Enter\": ");
            int a = int.Parse(ReadLine()), min = int.MaxValue, val = 0;
            for (int i = 1; i < numb.Length; i++)
            {
                val = Int32.Parse(ReadLine());
                min = min > val ? val : min;
            }       
            WriteLine("min : " + min);
            ReadKey();
        }
        
    }
}