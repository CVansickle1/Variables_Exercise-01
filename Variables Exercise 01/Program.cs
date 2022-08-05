using System;

namespace Variables_Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Complete all of the TODO's for this exercise
            // - Once finished save, commit, and then push to GitHub!

            // TODO: Declare 3 constansts
            const string how = "I am";
            const string are = " doing just";
            const string you = " fine thank you.";


            #region Types
            string School = "TrueCoders";
            char myLang = 'C';
            int myClass = 29;
            double classStart = 10;
            decimal classEnd = 4;
            bool enroll;

            #endregion

            // TODO: Declare a variable for each of the types above
            // Make sure to use C# naming convention best practices 

            // TODO: Initialize each of the variables with a value

            // TODO: Write out each of the variables to the Console 
            Console.WriteLine("Hello how are you?");

            Console.WriteLine(how + are + you);

            Console.WriteLine($"You are in {School} class {myLang}-{myClass} Correct?");

            Console.WriteLine("Please use True/False: ");

            var inputString = Console.ReadLine();
            if (inputString == "True")
            {
                enroll = true;
            }
            else if (inputString == "False")
            {
                enroll = false;
            }
            else
            {
                enroll = false;
                Console.WriteLine("Please use True/False: ");
            }

            if (enroll == true)
            {
                Console.WriteLine($"Great! Class starts at {classStart}a and ends at {classEnd}p");
            }
            else if (enroll == false)
            {
                Console.WriteLine("Thats alright theres plenty of time to sign up!");
            }
            else
            {
                
            }
        }
    }
}
