using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_permutations
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Enter string");
            evaluateString(Console.ReadLine());

            Console.ReadLine();

        }

        static void evaluateString(string inputString)
        {

            Console.WriteLine(inputString);

            if (inputString.Length > 1)
            {
                for(int i = 1; i < inputString.Length; i++)
                {

                    Console.WriteLine(inputString.Substring(0, i));

                }

                evaluateString(inputString.Substring(1));

            }
        }
    }
}
