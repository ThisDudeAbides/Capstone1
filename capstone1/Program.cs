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

                if (index != -1)
                {
                    if (index == 0)
                    {
                        Console.WriteLine($"{input}way");
                    }

                    else 
                    {
                        string end = input.Substring(index);
                        string begining = input.Substring(0, index);
                        Console.WriteLine($"{end}{begining}ay");
                    }

                
                            
                }

                
            }
        
        }
    }
}






        
    

