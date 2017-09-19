using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an expression: ");
            var math1 = Console.ReadLine();

            math1 = math1.Replace(" ", String.Empty);

            if (math1.Substring(0, 2).Contains(" ")
                {
                int first = Convert.ToInt32(math1.Substring(0, 1));
                else first = Convert.ToInt32(math1.Substring(0, 2));
                }
            if(math1.Substring(math1.Length - 2).Contains(" "))
            {
                int second = Convert.ToInt32(math1.Substring(2, 3));
            }
                
         //test

            Console.WriteLine(math1);
              
              int second = Convert.ToInt32(math1.Substring(2, 3));
            int result = first + second;
            Console.WriteLine("Result :" + result);
        }
    }
}
