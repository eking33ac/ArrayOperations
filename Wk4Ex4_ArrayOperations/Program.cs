using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Wk4Ex4_ArrayOperations
{
    internal class Program
    {
        // Method to accept and validate integer input
        static int HandleIntInput(string aPrompt, string anErrorMessage = "Your input is invalid. Please enter a whole number.")
        {
            // initialize return value
            int returnValue = Int32.MaxValue;


            // processing


            // start of a do while loop to ensure the loop runs at least once
            do
            {
                // A try catch to ensure the user input is valid
                try
                {
                    // Ask user to input a number
                    Console.Write(aPrompt);
                    // Convert user input to a double, collect input from user and store it in the returnValue
                    returnValue = Convert.ToInt32(Console.ReadLine());
                }
                // if that doesn't work, output an error message
                catch (Exception e)
                {
                    // output an error message
                    Console.WriteLine(anErrorMessage);
                }
            }
            // loop until returnValue has a different value
            while (returnValue == Int32.MaxValue);
            // return returnValue
            return returnValue;
        }



        // method to get an array's length
        static int ArrayLength (int[] array)
        {
            // initialize return value
            int returnValue = 0;


            // processing


            // foreach statement to add each array element to a string list and have a line break afterwards
            foreach (int i in array)
            {
                // add each element to the string and insert a line break afterwards
                returnValue += 1;
            }


            // return returnValue
            return returnValue;
        }
        



        // method to print all array elements
        public static string PrintArray(int[] array)
        {
            // initialize return value
            string returnValue = "";


            // processing


            // foreach statement to add each array element to a string list and have a line break afterwards
            foreach (int i in array)
            {
                // add each element to the string and insert a line break afterwards
                returnValue += $"{i}\n";
            }


            // return returnValue
            return returnValue;
        }


        // method to calculate and print the sum of all elements
        public static int SumArray(int[] array)
        {
            // initialize return value
            int returnValue = 0;


            // processing


            // Declare variables
            int sum = 0;        // declare int variable to hold the sum of all elements in the array

            // for loop to go through the full array
            for (int i = 0; i < ArrayLength(array); i++)
            {
                // add each new value to the sum
                sum += array[i];
            }


            // set return value to the sum
            returnValue = sum;


            // return returnValue
            return returnValue;
        }



        // method to Find the max and min values in the array
        public static string GetMaxAndMinArray(int[] array)
        {
            // initialize return value
            string returnValue = "";


            // processing


            // Declare variables
            int max = Int32.MinValue;        // declare int variable to hold the max of all elements in the array
            int min = Int32.MaxValue;        // declare int variable to hold the min of all elements in the array

            // foreach loop to go through the full array
            foreach (int i in array)
            {
                // if the element is greater than the current max
                if (i > max)
                {
                    // replace max with new element number
                    max = i;
                }
            }
            
            // foreach loop to go through the full array
            foreach (int i in array)
            {
                // if the element is less than the current min
                if (i < min)
                {
                    // replace min with new element number
                    min = i;
                }
            }




            // set return value to the sum
            returnValue = $"Max Value: {max}\nMinimum Value: {min}";


            // return returnValue
            return returnValue;
        }




        // method to reverse the array and print it backwards
        public static string PrintReversedArray(int[] array)
        {
            // initialize return value
            string returnValue = "";


            // processing


            // Delcare variables
            int index = ArrayLength(array) - 1;      // Create an index variable to hold the max element in the array and be decreased from there


            // foreach statement to add each array element to a string list and have a line break afterwards
            foreach (int i in array)
            {
                // add each element to the string and insert a line break afterwards
                returnValue += $"{array[index]}\n";
                // decrement index
                index--;
            }


            // return returnValue
            return returnValue;
        }




        static void Main(string[] args)
        {
            // Declare Variables
            int selection = Int32.MaxValue;     // selection variable
            int[] array10 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // Initialize array of values from 1 to 10



            // Get the selection of an oporation to perform from the user. Account for possible errors with a do while loop.
            do
            {
                // Prompt user to choose an operation to perform on the array
                Console.WriteLine("Select a operation to perform on the sample array:");


                // Output the choices and their number values


                // Output to tell the user they can type 1 to see all elements
                Console.WriteLine("1. Print all array elements.");
                // Output to tell the user they can type 2 to see the sum of all elements
                Console.WriteLine("2. Print the sum of all array elements.");
                // Output to tell the user they can type 3 to see the max and minimum elements
                Console.WriteLine("3. Print the maximum and minimum values.");
                // Output to tell the user they can type 4 to see the whole array in reverse order
                Console.WriteLine("4. Print all array elements in reverse.");


                // Call the try catch in the Interger Conversion module
                // Validate user's input and store it in the selection variable
                selection = HandleIntInput("Your desired operation choice (1-4): ", "An error occured. Please ensure you enter a valid whole number.");

                // If the selection isn't between 1 and 4, change the input back to the while evaluation number to have them try again
                if (!(selection >= 1 && selection <= 4))
                {
                    // output a message to prompt user to re-enter the value as a number from 1 to 4
                    Console.WriteLine("Please input a value between 1 and 4.");
                    // set selection to the max integer value
                    selection = Int32.MaxValue;
                }
            }
            // continue loop while the selection is the max integer value
            while (selection == Int32.MaxValue);






            // use a switch case to perform an operation based on the selection
            switch (selection)
            {
                // Run this case if selection = 1
                case 1:
                    // Print all array elements
                    Console.WriteLine(PrintArray(array10));

                    // Jump out of switch here.
                    break;


                // Run this case if selection = 2
                case 2:
                    // print the sum of all array elements
                    Console.WriteLine(SumArray(array10));

                    // Jump out of switch here.
                    break;


                // Run this case if selection = 3
                case 3:
                    // output the max and min array elements
                    Console.WriteLine(GetMaxAndMinArray(array10));

                    // Jump out of switch here.
                    break;


                // Run this case if selection = 4
                case 4:
                    // Print all array elements in reverse
                    Console.WriteLine(PrintReversedArray(array10));

                    // Jump out of switch here.
                    break;


                default:
                    // Output a polite message in case of unforseen error.
                    Console.WriteLine("It seems something went wrong on our end. Please close the program and try again.");

                    // Jump out of switch here.
                    break;
            }



            // Thank user for using the program
            Console.WriteLine("Thank you for using this program! Come again!");


            // Pause at the end of program for user to read
            Console.ReadLine();
        }
    }
}
