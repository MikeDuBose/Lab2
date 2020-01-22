using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Line is only written once, upon execution of code.
            Console.WriteLine("Learn your squares and cubes!");
            //Calls the getInput() method.
            getInput();
        }
        private static string getInput()
        {
            //Ask user for a number > 0 and then calls the checkInput command, passing the input as a parameter.
            Console.Write("Please enter a number greater than 0:  ");
            string input = Console.ReadLine();
            checkInput(input);
            return input;
        }

        //Method to check the input
        private static bool checkInput(string input)
        {
            bool check = double.TryParse(input, out double a);
            //Checks to see if the input isn't a non-number and is above 0 and is below the maximum 32 byte signed 
            //integer size before being cubed.
            if (check && double.Parse(input) > 0 && double.Parse(input) <= 1290)
            {
                double number = double.Parse(input);
                createTable(number);
                getInput();
            }
            else
            {
                Console.WriteLine("This input is not acceptable.");
                getInput();
            }
            return check;
        }

        private static void createTable(double number)
        {
            //Initialize the headers
            int i = 1;
            Console.WriteLine($"\tNumber \t \tSquared \t \t Cubed");
            while (i <= number)
            {
                //Repeatedly calls a function to do the math based on the number the user has input (number -> i)
                doMath(i);
                i++;
            }
            proceed();

        }

        //Takes the user input applies the formula to the number before printing it back out to the console
        private static void doMath(double number)
        {
            double squared = number * number;
            double cubed = number * number * number;
            //Prints out the numbers as they are calculated.
            Console.WriteLine($"{number, 13} \t {squared, 13} \t \t {cubed, 13}");
        }

        private static void proceed()
        {
            Console.Write("Would you like to proceed?  Y/N:  ");
            string response = Console.ReadLine();
            response = response.ToLower();
            if (response == "y")
            {
                getInput();
            }
            else
            {
                System.Environment.Exit(0);

            }
        }
    }
}
