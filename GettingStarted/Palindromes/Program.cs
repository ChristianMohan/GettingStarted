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

            for (int con = 1; con >= 1; con = con)
            {
                Console.WriteLine("Enter a phrase: ");
                String word = Console.ReadLine();
                String words = word.ToLower();


                words = words.Replace(" ", String.Empty);
                words = words.Replace("?", String.Empty);
                words = words.Replace(".", String.Empty);
                words = words.Replace(",", String.Empty);
                words = words.Replace("!", String.Empty);
                words = words.Replace(":", String.Empty);
                words = words.Replace(";", String.Empty);

                char[] arr = words.ToCharArray();
                Array.Reverse(arr);
                String rev = new String(arr);


                if (words == rev)

                    Console.WriteLine(words + " is a palindrome");

                else

                    Console.WriteLine(word + " is not a palindrome");
            }
            Console.WriteLine("hello");

            
        }
    }
}
