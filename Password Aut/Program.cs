using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Aut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Username");
            var user = Console.ReadLine();
            Console.WriteLine("Enter the Password");
            var pass = Console.ReadLine();

            if (pass == "letmein" && user == "root")
            {
                Console.WriteLine("Username and password authenticated.. you may proceed");
            }


        }
    }
}
