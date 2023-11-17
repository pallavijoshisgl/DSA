using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionProblem
{
    internal class Recursion_Prb
    {

        public static int GetNthFib(int n)
        {
            if(n<=2)
            {
                return n - 1;
            }

            return GetNthFib(n-1) + GetNthFib(n-2);
        }
        static void Main(string[] args)
        {
            int n = 6;
            int result=GetNthFib(n);
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
