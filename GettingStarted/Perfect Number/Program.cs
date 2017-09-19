using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Perfect Numbers are...");

            

            for(int final = 2; final < 1000; final++)
            {
                int check = 0; int tester = 1;
                for (tester = 1; tester < final; tester++)
                {
                    if(final % tester == 0)
                    {
                        check = check + tester;
                    }
                    

                   

                }
                if (check == final)
                {
                    Console.Write(final + " ");
                }
                

            }
        }
    }
}
