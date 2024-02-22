using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneEdit
{
    internal class OneEditProgram
    {
        public static bool OneEditFn(string stringOne,string stringTwo)
        {
            if(Math.Abs(stringOne.Length - stringTwo.Length) > 1)
            {
                return false;
            }
            bool OneEdit = false;
            int indexOne = 0;
            int indexTwo = 0;

            while(indexOne < stringOne.Length && indexTwo < stringTwo.Length)
            {
                
                if (stringOne[indexOne] != stringTwo[indexTwo])
                {
                    if (OneEdit)
                        return false;
                    OneEdit = true;
                    if (stringOne.Length > stringTwo.Length)
                    {
                        indexOne++;
                    }
                    else if (stringTwo.Length > stringOne.Length)
                    {
                        indexTwo++;
                    }
                    else
                    {
                        indexOne++;
                        indexTwo++;
                    }
                }
                else
                {
                    indexOne++;
                    indexTwo++;
                }
            }
            


            return true;
        }
        static void Main(string[] args)
        {
            string stringOne = "hllo";
            string stringTwo = "hello";
            bool result=OneEditFn(stringOne, stringTwo);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
