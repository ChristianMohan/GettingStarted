using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Largest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the first number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the second number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the third number: ");
            int n3 = Convert.ToInt32(Console.ReadLine());

            if(n1 > n2 && n1 > n3)
            {
                Console.WriteLine("the first number is the greatest");
            }
            if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine("The second number is the greatest");
            }
            if (n3 > n2 && n3 > n1)
            {
                Console.WriteLine("The third number is the greatest");
            }
        }
    }
}
