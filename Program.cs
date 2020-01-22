using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn your squares and cubes!");
            getInput();
            //Call method to check the input
            //If it passes (bool check maybe?), then call the next method to create the table-like structure
            // \t is what I'm supposed to use to format the table (I assume)
        }

        //Method to get input
        private static string getInput()
        {
            Console.Write("Please enter a number greater than 0:  ");
            string input = Console.ReadLine();
            checkInput(input);
            return input;
        }

        //Method to check the input
        private static bool checkInput(string input)
        {
            bool check = double.TryParse(input, out double a);
            //Checks to see if the input isn't a non-number and is above 0
            if (check && double.Parse(input) > 0 && double.Parse(input) <= 1290)
            {
                double number = double.Parse(input);
                createTable(number);
                getInput();
                //Execute number and table process
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
                doMath(i);
                i++;
            }

        }

        //Method to do the math and print out the results
        private static void doMath(double number)
        {
            double squared = number * number;
            double cubed = number * number * number;
            Console.WriteLine($"{number, 13} \t {squared, 13} \t \t {cubed, 13}");
        }
    }
}
