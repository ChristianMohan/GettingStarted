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
            int equation = Convert.ToInt32(math1);
            Console.WriteLine(math1);
          //  int first = Convert.ToInt32(math1.Substring(0, 1));
          //  int second = Convert.ToInt32(math1.Substring(1, 2));

        }
    }
}
