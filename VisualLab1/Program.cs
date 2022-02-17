using System;

namespace VisualLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num1 = { 5, 3, 4 };
            Console.WriteLine(HW1.QueueTime(num1, 1));
            int[] num2 = { 10, 2, 3, 3 };
            Console.WriteLine(HW1.QueueTime(num2, 2));
            int[] num3 = { 2, 3, 10 };
            Console.WriteLine(HW1.QueueTime(num3, 2));
        }
    }
}
