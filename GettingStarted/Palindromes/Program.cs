using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a phrase: ");
                var word = Console.ReadLine();
            char[] arr = word.ToCharArray();
            Array.Reverse(arr);
           // Console.WriteLine(arr);
            char[] arr2 = word.ToCharArray();
           // Console.WriteLine(arr2);
            if (arr == arr2)
            {
                Console.WriteLine("/" + word + "/" + " is a palindrome");
            }
            else
            {
                Console.WriteLine("/" + word + "/" + " is not a palindrome");
            }
            Console.WriteLine("hello");
            
        }
    }
}
