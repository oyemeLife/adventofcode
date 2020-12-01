using System;

namespace Puzzle
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"-> {FindSumOfTwoNumbers(2020)}");
        }

        public static int FindSumOfTwoNumbers(int n)
        {
            string[] lines = System.IO.File.ReadAllLines(@"Input.txt");
            int result = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < lines.Length; j++)
                {
                    if ((Convert.ToInt32(lines[i]) + Convert.ToInt32(lines[j])) == n)
                    {
                        result = Convert.ToInt32(lines[i]) * Convert.ToInt32(lines[j]);
                        break;
                    }
                }
            }
            return result;
        }
    }
}
