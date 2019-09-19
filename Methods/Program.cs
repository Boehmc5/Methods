// Christopher Boehm
//Methods
//9/19/2019

using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
            {
            
            //calls the function get_Name
            get_Name();

            //pauses before the program ends 
            Console.ReadKey(true);
            }
       
        //creates method
        private static void get_Name()
            {
            // asks user to input name
            Console.WriteLine("Please enter your name:  ");

            string input = Console.ReadLine();

            //writes to screen the hello plus the users name
            Console.WriteLine("Hello " + input + "!");
            }    
   }
    
}

