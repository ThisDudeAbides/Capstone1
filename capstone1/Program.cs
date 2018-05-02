using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capstone1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter a word");
                string input = Console.ReadLine();

                char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

                int index = input.IndexOfAny(vowels);
                // singling out situation where their are no vowels in word
                if (index != -1)
                {   // where word starts with vowel identified in index 
                    if (index == 0)
                    {
                        Console.WriteLine($"{input}way");
                    }
                    
                    else
                    {   // if word does not start with vowel then the word splits 
                        //
                        string end = input.Substring(index);
                        string begining = input.Substring(0, index);
                        Console.WriteLine($"{end}{begining}ay");
                                               
                    }
                    Console.WriteLine("would you like to continue translating? y/n");
                    string response = (Console.ReadLine());
                    if (response.ToLower() == "n")
                    {
                       break;
                    }

                }
                
            }
            Console.WriteLine("Thanks for playing, have a good day!");
        }
        
    }
}






        
    

