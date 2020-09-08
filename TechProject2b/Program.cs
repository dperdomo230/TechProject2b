/* 
    Author: Daniel Perdomo
    Date: 9/7/2020
    Comments: This C# console application code demonstrates the use of conditional 
    statements after getting input from users.
*/

using System;

namespace TechProject2b
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input 
            Console.WriteLine("What grade do you expect to earn in ISM 4300? (please enter an integer value)");

            /* 
                Use the try catch block to validate user input. If the user provides bad input,
                the catch block will handle the error and a message will be displayed.
            */
            try
            {
                // This variable will gather user input
                string input = Console.ReadLine();

                // Input variable parsed to int data type
                int grade = int.Parse(input);

                // This variable will be used to store the letter grade depending on each integer value
                int grade_in_class = 0;

                /* 
                    This IF/ELSE IF/ELSE statement is used to conditionally test the users
                    input. Various options are available depending on the grade desired by the
                    user. Inside each IF/ELSE IF/ELSE there is a switch conditional statment 
                    that prompts the user to close the application.
                */
                if (grade <= 100 && grade >= 93)
                { 
                    // Display letter grade to user depending on input
                    Console.WriteLine("Your grade is an A.");
                    
                    /* Execute conditional statement to prompt the user to close
                       the console application after their grade is displayed 
                    */
                    switch (grade_in_class)
                    {
                        default:
                            Console.WriteLine("Press any key to exit the program.");
                            // Pauses the program until the user presses a key
                            Console.ReadKey(true);
                            break;
                    } // End of switch
                }
                else if (grade >= 90 && grade <= 92)
                {
                    // Display letter grade to user depending on input
                    Console.WriteLine("Your grade is an A-.");
                    
                    /* Execute conditional statement to prompt the user to close
                       the console application after their grade is displayed 
                    */
                    switch (grade_in_class)
                    {
                        default:
                            Console.WriteLine("Press any key to exit the program.");
                            // Pauses the program until the user presses a key
                            Console.ReadKey(true);
                            break;
                    } // End of switch
                }
                else if (grade >= 87 && grade <= 89)
                {
                    // Display letter grade to user depending on input
                    Console.WriteLine("Your grade is a B+.");

                    /* Execute conditional statement to prompt the user to close
                       the console application after their grade is displayed 
                    */
                    switch (grade_in_class)
                    {
                        default:
                            Console.WriteLine("Press any key to exit the program.");
                            // Pauses the program until the user presses a key
                            Console.ReadKey(true);
                            break;
                    } // End of switch
                }
                else if (grade >= 83 && grade <= 86)
                {
                    // Display letter grade to user depending on input
                    Console.WriteLine("Your grade is a B.");

                    /* Execute conditional statement to prompt the user to close
                       the console application after their grade is displayed 
                    */
                    switch (grade_in_class)
                    {
                        default:
                            Console.WriteLine("Press any key to exit the program.");
                            // Pauses the program until the user presses a key
                            Console.ReadKey(true);
                            break;
                    } // End of switch
                }
                else if (grade >= 80 && grade <= 82)
                {
                    // Display letter grade to user depending on input
                    Console.WriteLine("Your grade is a B-.");

                    /* Execute conditional statement to prompt the user to close
                       the console application after their grade is displayed 
                    */
                    switch (grade_in_class)
                    {
                        default:
                            Console.WriteLine("Press any key to exit the program.");
                            // Pauses the program until the user presses a key
                            Console.ReadKey(true);
                            break;
                    } // End of switch
                }
                else if (grade >= 77 && grade <= 79)
                {
                    // Display letter grade to user depending on input
                    Console.WriteLine("Your grade is a C+.");

                    /* Execute conditional statement to prompt the user to close
                       the console application after their grade is displayed 
                    */
                    switch (grade_in_class)
                    {
                        default:
                            Console.WriteLine("Press any key to exit the program.");
                            // Pauses the program until the user presses a key
                            Console.ReadKey(true);
                            break;
                    } // End of switch
                }
                else if (grade >= 73 && grade <= 76)
                {
                    // Display letter grade to user depending on input
                    Console.WriteLine("Your grade is a C.");

                    /* Execute conditional statement to prompt the user to close
                       the console application after their grade is displayed 
                    */
                    switch (grade_in_class)
                    {
                        default:
                            Console.WriteLine("Press any key to exit the program.");
                            // Pauses the program until the user presses a key
                            Console.ReadKey(true);
                            break;
                    } // End of switch
                }
                else if (grade >= 70 && grade <= 72)
                {
                    // Display letter grade to user depending on input
                    Console.WriteLine("Your grade is a C-.");

                    /* Execute conditional statement to prompt the user to close
                       the console application after their grade is displayed 
                    */
                    switch (grade_in_class)
                    {
                        default:
                            Console.WriteLine("Press any key to exit the program.");
                            // Pauses the program until the user presses a key
                            Console.ReadKey(true);
                            break;
                    } // End of switch
                }
                else if (grade >= 67 && grade <= 69)
                {
                    // Display letter grade to user depending on input
                    Console.WriteLine("Your grade is a D+.");

                    /* Execute conditional statement to prompt the user to close
                       the console application after their grade is displayed 
                    */
                    switch (grade_in_class)
                    {
                        default:
                            Console.WriteLine("Press any key to exit the program.");
                            // Pauses the program until the user presses a key
                            Console.ReadKey(true);
                            break;
                    } // End of switch
                }
                else if (grade >= 63 && grade <= 66)
                {
                    // Display letter grade to user depending on input
                    Console.WriteLine("Your grade is a D.");

                    /* Execute conditional statement to prompt the user to close
                       the console application after their grade is displayed 
                    */
                    switch (grade_in_class)
                    {
                        default:
                            Console.WriteLine("Press any key to exit the program.");
                            // Pauses the program until the user presses a key
                            Console.ReadKey(true);
                            break;
                    } // End of switch
                }
                else if (grade >= 60 && grade <= 62)
                {
                    // Display letter grade to user depending on input
                    Console.WriteLine("Your grade is a D-.");

                    /* Execute conditional statement to prompt the user to close
                       the console application after their grade is displayed 
                    */
                    switch (grade_in_class)
                    {
                        default:
                            Console.WriteLine("Press any key to exit the program.");
                            // Pauses the program until the user presses a key
                            Console.ReadKey(true);
                            break;
                    } // End of switch
                }
                else if (grade >= 0 && grade <= 59)
                {
                    // Display letter grade to user depending on input
                    Console.WriteLine("Your grade is an F.");

                    /* Execute conditional statement to prompt the user to close
                       the console application after their grade is displayed 
                    */
                    switch (grade_in_class)
                    {
                        default:
                            Console.WriteLine("Press any key to exit the program.");
                            // Pauses the program until the user presses a key
                            Console.ReadKey(true);
                            break;
                    } // End of switch
                }
                else
                {
                    Console.WriteLine("Please enter a value between 0 and 100.");
                    Console.WriteLine("Press any key to exit the program and try again.");
                    // Pauses the program until the user presses a key
                    Console.ReadKey(true);
                }
            } // End of try
            catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again.");
                Console.WriteLine("Press any key to exit the program.");
                Console.ReadKey(true);
            } // End of catch
        } // End of main
    } // End of class
} //End of namespace
