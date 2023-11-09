namespace JoesConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Question the user whether they want to change tracks
            Console.WriteLine("Would you like to change train tracks?");
            // recieve input
            string UserInput = Console.ReadLine();
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
                Console.WriteLine("Try again and input only Yes or No");
                UserInput = Console.ReadLine();
                if (UserInput.ToLower() != "yes" || UserInput.ToLower() != "no")
                {

                }
                else
                {
                    flag = true;
                }
            }
            while (flag == false);

            // While UserInput is not yes or no 
            // Ask user to input again yes or no
            // Ask the user to try again and input only Yes or No
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