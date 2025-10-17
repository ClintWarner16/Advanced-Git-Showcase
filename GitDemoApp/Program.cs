using System;

namespace GitDemoApp
{
    class Program
    {
        // Line 11: Target line for the merge conflict
        private const string AppTitle = "The Official Name";

        static void Main(string[] args)
        {
            Console.WriteLine(AppTitle);
            DisplayWelcomeMessage();
        }

        static void DisplayWelcomeMessage()
        {
            // Line 20: Target line for the rebase/squash feature
            Console.WriteLine("Version 1.0: Basic structure.");
        }
    }
}