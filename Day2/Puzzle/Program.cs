using System;
using System.Linq;

namespace Puzzle
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string[] lines = System.IO.File.ReadAllLines(@"Input.txt");
            CountValidPassword(lines);
        }

        public static int CountValidPassword(string[] lines)
        {
            return lines.ToList().FindAll(e =>
            {
                var s = e.Split(" ");
                var numbers = s[0].Split("-");
                var num = s[1].Replace(":", "");
                int total = s[2].Count(e => e.ToString() == num.ToString());
                return Convert.ToInt32(numbers[0]) <= total && Convert.ToInt32(numbers[1]) >= total;
            }).Count();
        }
    }
}
