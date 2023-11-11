using System.Security.Cryptography.X509Certificates;

namespace JoesConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Question the user whether they want to change tracks
            Console.WriteLine("Would you like to change train tracks?");
            // recieve input
            string UserInput;
            bool flag = false;
            // validate input
            // If User input not equal to Yes or No 
            //if (UserInput.ToLower() != "yes" || UserInput.ToLower() != "no")
            //{
            //    Console.WriteLine("Try again and input only Yes or No");
            //    UserInput = Console.ReadLine();
            //}

            do
            {
                UserInput = Console.ReadLine().Trim();

                if (UserInput.ToLower() == "yes" || UserInput.ToLower() == "no")
                {
                    flag = true;

                    ChangeTracks(UserInput);
                }
                else 
                {
                    Console.WriteLine("Try again and input only Yes or No");

                    flag = false; 
                }
            }
            while (flag == false);

            // While UserInput is not yes or no 
            // Ask user to input again yes or no
            // Ask the user to try again and input only Yes or No


            static void ChangeTracks(string UserInput)
            {

                if (UserInput.ToLower() == "yes")
                {
                    Console.WriteLine("Tracks have been changed");

                }
                else if (UserInput.ToLower() == "no")
                {
                    Console.WriteLine("Tracks have not been changed");

                }
                // output result
            }

        }
    }
}