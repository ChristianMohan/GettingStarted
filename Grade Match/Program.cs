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
            System.Console.WriteLine("Input the grade");

            var answer = System.Console.ReadLine();

            if(answer == "e")
            {
                System.Console.WriteLine("You have chosen : excellent");
            }
            else if (answer == "v")
            {
                System.Console.WriteLine("You have chosen : very good");
            }
            else if (answer == "g")
            {
                System.Console.WriteLine("You have chosen : good");
            }
            else if (answer == "a")
            {
                System.Console.WriteLine("You have chosen : average");
            }
            else if (answer == "f")
            {
                System.Console.WriteLine("You have chosen : fail");
            }

        }
    }
}
