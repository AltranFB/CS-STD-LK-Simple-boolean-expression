using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBooleanExpression
{
    public class Solution
    {
        public static bool Test(int i, int j)
        {
            /**
             * Solution.Test(int i, int j) should return true if one of the arguments equals 1 or if their sum is equal to 1. 
             * For example:
             *  Solution.Test(1, 5) returns true
             *  Solution.Test(2, 3) returns false
             *  Solution.Test(-3, 4) returns true 
             */
            throw new NotImplementedException();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("First argument");
            var input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Second argument");
            var input2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The entries are {0}OK", Solution.Test(input1, input2) ? "" : "NOT ");
        }
    }
}