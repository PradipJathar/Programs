using System;
using System.Text;

namespace Palindrome_String
{
    class Program
    {
        // Rule 1 - The string should not be case sensitive.
        // Rule 2 - The string should not have punctuation or white space.

        static void Main(string[] args)
        {
           // User Input String
           Console.WriteLine("Let's begin !! ");
           Console.Write("Enter the string : ");
           string s = Console.ReadLine();     
                       
            if (s!="exit")
            {            
                if(IsPalindrome(s))
                {
                    Console.WriteLine("This is Palindrome String!!");
                }
                else
                {
                    Console.WriteLine("This is NOT Palindrome String.");
                }
            }
            else
            {
                Console.WriteLine("Good Bye..");
            }
        }


        static bool IsPalindrome(string str)
        {
            // Convert string to upper case.            
            str = str.ToUpper();

            // Use StringBuilder to remove Punctuation and WhiteSpace.
            StringBuilder sb = new StringBuilder();
                        
            foreach (char c in str)
            {
               if(!char.IsPunctuation(c) && !char.IsWhiteSpace(c))
               {
                sb.Append(c);
               }
            }

            str = sb.ToString();

             // Check whether the given string is palindrome or not.
            int i = 0, j = str.Length-1;
       
            while(i<=j)
            {
                if(str[i] != str[j])
                {
                    return false;        
                }
                i++;
                j--;
            }

            return true;
        }

    }
}
