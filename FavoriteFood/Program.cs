using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteFood
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is you favorite food?");
            var favFood = Console.ReadLine();
            {
                if (favFood == "Pizza")
                {
                    Console.WriteLine("Wrong!  That is a terrible choice and you should feel bad about yourself.   Your favorite should be pizza!");
                }
                else
                    Console.WriteLine("Most excellent and correct!  Pizza is indeed one of the best foods ever put on this earth.");
            }
        }

    }
}
