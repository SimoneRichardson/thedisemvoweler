using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thedisemvoweler
{
    class Program
    {
        static void Main(string[] args)
        {
            //call your  new disemvoweled function from your Main function

            disemvoweler("Nickleback is my favorite band.Their songwriting can't be beat!");
            disemvoweler("How many bears could bear grylls grill if bear grylls could grill bears?");
            disemvoweler("Im a code ninja, baby. I make the functions and I make the calls.");

            //Stop the program
            Console.ReadKey();
        }
        static void disemvoweler(string input) 
        {
            //Print the original
            Console.WriteLine("Original: " + input);

            string text = input.Replace(" ", " ");
            //Output will be final product
            string output = null;
            //vowel will count the vowels removed from text
            string vowel = null;
            //Change it into a list to check every letter
            List<char> letter = text.ToList();
            for (int i = 0; i < letter.Count(); i++)
            {
            
                 //Turn every letter to string 
                string letterString = letter[i].ToString();
                if (letterString=="a"|| letterString=="e"||letterString=="i"||letterString=="o"||letterString=="u")
                {
                //vowel variable will concentrate with vowels
                    vowel = vowel + letterString;
                //eliminate the string
                letterString = "";
                }
                else
                {
                //If the letter is not a vowel concatenate with the output
                    output = output + letterString;

               }
            }
            //Print out the product
            Console.WriteLine("disemvoweler: " + output);
            Console.WriteLine("Vowels are removed: " + vowel);
            Console.WriteLine();

        }
    }
}
    


      
            
            
            
            
            
        
    

