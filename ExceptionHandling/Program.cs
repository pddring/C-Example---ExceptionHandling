using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = -1;
            bool valid = false;
            while(!valid) {
                Console.Write("Please enter your age: ");

                try
                {
                    age = int.Parse(Console.ReadLine());
                    if(age >= 0 && age <= 150)
                    {
                        valid = true;
                    }
                }
                catch
                {
                    Console.WriteLine("You didn't enter your age");
                }

            }
            Console.WriteLine("You are " + age + " years old");

            /*
             * Challenges:
             * 1a) Create a program which asks the user to type their age.
             *  It shouldn't crash, no matter what they type in
             *  
             * 1b) Create a program which keeps asking the user to type in their age
             * until they type in something between 0 and 150
             * 
             * 2a) Create a program which asks the user to type in a 16 digit credit card number
             *  It shouldn't crash, no matter what they type in
             *  
             * 2b) Create a program which keeps asking the user to type in a 16 digit card number
             * until they enter something valid
             * 
             * Don't use real credit card numbers
             * */
        }
    }
}
