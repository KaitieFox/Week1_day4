using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_day4
{
    class Program
    {
        static void Main(string[] args)
        {
            //A string is a sequence of characters
            //inside a "double quotes"

            Console.WriteLine("This is a tab \t.");
            Console.WriteLine("This is a \"quote\".");
            Console.WriteLine("This is a backslash \\");
            Console.WriteLine("This is a \n new line.");
            Console.WriteLine("And this is a bell \a");

            string firstName = "Kait";
            string catName = "Rey";

            Console.WriteLine("\nMy name is {0} and my cat is {1}. \n", firstName, catName);

            //string bestFriends = firstName + " " + catName;
            // Console.WriteLine(bestFriends);


            string bestFriends = string.Concat(firstName, " ", catName);
            Console.WriteLine(bestFriends);

            Console.WriteLine(firstName.Length);
            Console.WriteLine(bestFriends.Length);

            //Replace
            string replaceTest = "Funny";
            Console.WriteLine("This is '{0}'.", replaceTest);
            replaceTest = replaceTest.Replace("n", "z");
            Console.WriteLine("But it really is '{0}'.", replaceTest);

         

            

            
        }
    }
}
