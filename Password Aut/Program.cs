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
            int wrong = 0;
            for (int i = 0; i < 3; i++)
            {
                System.Console.WriteLine("Enter the Username");
                var user = Console.ReadLine();
                System.Console.WriteLine("Enter the Password");
                var pass = Console.ReadLine();

                if (pass == "letmein" && user == "root")
                {
                    wrong = 1;
                    System.Console.WriteLine("Username and password authenticated.. you may proceed");
                    break;
                }
            }

            if (wrong == 0)
            {
                System.Console.WriteLine("too many incorrect login attempts! Try again later!");
            }
        }
            
             
            
            


       
    }
}
