using System;
namespace ForCountTest;
class Program
{
    
    //TODO: Add exception manager and handling for invalid inputs or errors
    static void Main(string[] args)
    {
        //! This program puts examples to the utility of for loops, if you want to modify someting you can made it
        
        Console.WriteLine("1. Count up to a user-defined number with confirmation");
        Console.WriteLine("2. Multiply 7 up to 100");
        Console.WriteLine("What type of for Loop Example do you want to see?");
        
        int[] options = {1, 2};
        var user_selection  = Console.ReadLine();
        
        if (user_selection == "1") //TODO: Change this to, add every option in a single if and make the options variable work with options, objective: enhance program performance and legibility
        {
            Number();
        }
        else if (user_selection == "2")
        {
            MultipleOf7();
        }
        Console.WriteLine("End of program, press any key to exit...");
        Console.ReadKey();
    }
    static void Number ()
    {
        Console.WriteLine("Welcome, up to what number do you want to count?: ");
        var numbercount = Console.ReadLine();
        Console.WriteLine("You entered the number: " + numbercount + " " + "Confirm? (Y/N)");

        var confirm = Console.ReadLine();
        if (confirm == "Y" || confirm == "y")
        {
            for (int i = 1; i <= int.Parse(numbercount); i++)
            {
                Console.WriteLine("Printing... " + i); //* This will print up to the number that the user wants if you want you can change the message to something else, just be creative :)
            }
        }
        else
        {
            Console.WriteLine("Don't you want to see me print? :C. (Y/N)");
            var sub_answer = Console.ReadLine();
            if (sub_answer == "Y" || sub_answer == "y")
            {
                Console.WriteLine("Well, in that case open me again :D");
            }
            else
            {
                Console.WriteLine("Nooooooo how sad :C");
            }
        }
    }
    static void MultipleOf7()
    {
        for(int i = 0; i <= 101; i++)
        {
            Console.WriteLine("Multiplying... " + i * 7);
        }
    }
    
}
