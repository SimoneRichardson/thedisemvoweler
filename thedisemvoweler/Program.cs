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
            Console.WriteLine("Nickleback is my favorite band. Their songwriting can't be beat!");
            Disemvoweler("Nickleback is my favorite band.Their songwriting can't be beat!");
            Console.WriteLine("How many bears could bear grylls grill if bear grylls could grill bears?");
            Disemvoweler("How many bears could bear grylls grill if bear grylls could grill bears?");
            Console.WriteLine("Im a code ninja, baby. I make the functions and I make the calls.");
            Disemvoweler("Im a code ninja, baby. I make the functions and I make the calls.");
      
    

            
            //keep the console open
            Console.ReadKey();
        }
    }
}  
        
    
            static string Disemvoweler(string input)
            {
            // hold our output
            string vowels = "";
            string ReturnString ="";
            int numVowels = 0;
            for (int i = 0; i < inString.Length; i=i+1)

           //is it a vowel
            var c = inString[i];
            if (c == 'a' ||c == 'e' ||c== 'i' || c == 'o' || c == 'u')
            {
             vowels += c;
            { 
                else if (c == ' ' )
                {
                    numVowels += 1;{
                    }
                    else
                    {
                       ReturnString += c;
                }
            }
              return returnString;
         }
     

      
            
            
            
            
            
        
    

