using System;
// Exceeded requirements: 
// - Implemented the stretch challenge so the program only hides words that are not already hidden.
// - Used the verse range constructor (Proverbs 3:5-6) to demonstrate support for multi-verse scriptures.

class Program
{
    static void Main(string[] args)
    {
        // Create a scripture (you can change this to any scripture you want)
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding In all thy ways acknowledge him and he shall direct thy paths";
        Scripture scripture = new Scripture(reference, text);

        // Main loop
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit' to finish:");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            // Hide 3 random words each time (you can change the number)
            scripture.HideRandomWords(3);
        }

        // Final display when everything is hidden
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("All words are now hidden. Program ended.");
    }
}