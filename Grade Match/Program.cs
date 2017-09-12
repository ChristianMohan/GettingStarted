using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Match
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the grade");

            var answer = Console.ReadLine();

            if(answer == "e")
            {
                Console.WriteLine("You have chosen : excellent");
            }
            else if (answer == "v")
            {
                Console.WriteLine("You have chosen : very good");
            }
            else if (answer == "g")
            {
                Console.WriteLine("You have chosen : good");
            }
            else if (answer == "a")
            {
                Console.WriteLine("You have chosen : average");
            }
            else if (answer == "f")
            {
                Console.WriteLine("You have chosen : fail");
            }

        }
    }
}
