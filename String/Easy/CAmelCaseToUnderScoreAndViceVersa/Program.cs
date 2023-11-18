using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAmelCaseToUnderScoreAndViceVersa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = "input_variable_java";
            string camelcasestring = UnderScoreToCamelCase(inputString);
            Console.WriteLine(camelcasestring);
            string ipStr = "aVariableIs";
            string underscorestring = CamelCaseToUnderScore(ipStr);
            Console.WriteLine(underscorestring);
            Console.WriteLine(ipStr);
            Console.ReadKey();
        }


        public static string CamelCaseToUnderScore(string inputstring)
        {
            StringBuilder result = new StringBuilder();

            foreach(char c in inputstring)
            {
                if(char.IsUpper(c))
                {
                    result.Append('_');
                    result.Append(char.ToLower(c));
                }
                else
                {
                    result.Append(c);
                }
            }
            return result.ToString();
        }
        public static string UnderScoreToCamelCase(string inputstring)
        {
            StringBuilder stringBuilder = new StringBuilder();
            bool capitalizeNext = false;
            foreach(char c in inputstring)
            {
                if(c == '_')
                {
                    capitalizeNext = true;
                }
                else
                {
                    stringBuilder.Append(capitalizeNext ? char.ToUpper(c) : c);
                    capitalizeNext = false;
                }
            }
            return stringBuilder.ToString();

        }
    }
}
