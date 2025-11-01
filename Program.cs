namespace ForCountTest;

class Program
{
    static void Main(string[] args)
    {
        //* Count up to a user-defined number with confirmation (This is my first time using the for loop) and publishing 

        Console.WriteLine("Welcome, up to what number do you want to count??: ");
        var user_input = Console.ReadLine();
        Console.WriteLine("You entered the number: " + user_input + " " + "Confirm? (Y/N)");

        var confirm = Console.ReadLine();
        if (confirm == "Y" || confirm == "y")
        {
            for (int i = 1; i <= int.Parse(user_input); i++)
            {
                Console.WriteLine("I'm printing bro, more patience: " + i); //* This will print up to the number that the user wants if you want you can change the message to something else, just be creative :)
            }
        }
        else
        {
            Console.WriteLine("Don't you want to see me print? :C. (Y/N)");
            var sub_answer = Console.ReadLine();
            if (sub_answer == "Y" || sub_answer == "y")
            {
                Console.WriteLine("Well, in that case open me again :DWell, in that case open the program again :D..");
            }
            else
            {
                Console.WriteLine("Nooooooo how sad :C");
            }
        }

        Console.WriteLine("End of program, press any key to exit...");
        Console.ReadKey();
    }
}
