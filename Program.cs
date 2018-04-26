using System;

namespace Lab3_Squared_Cubed
{
    class Program
    {
        static void Main(string[] args)
        {

            string play;

            do
            {

                //Prompt user to declare integer
                Console.WriteLine("Enter an integer:");


                //Headers
                string column1 = "Number";
                Console.Write(column1.PadRight(16, ' '));

                string column2 = "Squared";
                Console.Write(column2.PadRight(16, ' '));

                Console.WriteLine("Cubed");


                //Declare and convert variable 
                int userInput = Convert.ToInt32(Console.ReadLine());

                //Display numbers
                for (int a = 1; a <= userInput; a++)

                {
                    //Prints range of numbers
                    Console.Write(a + "\t" + "\t");

                    //Prints squared numbers
                    Console.Write(a * a + "\t" + "\t");

                    //Prints cubed numbers
                    Console.WriteLine(a * a * a + "\t" + "\t");

                }

                //end of loop
                Console.WriteLine("Would you like to play again? (Y/N)");
                play = Console.ReadLine();

            }
            while (play == "y" || play == "Y");


        }
    }
}