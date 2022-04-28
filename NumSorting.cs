using System;
using System.Collections.Generic;

namespace NumberSorting
{
    //TODO:
    //Streamline the number requesting process?
    class NumSorting
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[10]; //the array used
            int tmpStorage; //In order to save numbers without risking overriding something

            Console.WriteLine("Enter the 10 sets of Numbers to sort:"); //ask user for the 10 numbers we'll use for the array
            for (int countNum = 0; countNum < 10; countNum++) //loop to ensure user inputs 10 numbers
                //theoretically here the user can input letters, or nothing which will cause this to crash
            {
                Console.Write("Enter element {0};", countNum + 1);
                numArray[countNum] = Convert.ToInt32(Console.ReadLine());
            }
                Console.WriteLine("\n\nYour original inputted Array: ");
                foreach (int valItem in numArray)
                {
                    Console.Write(" {0} ", valItem); //display the original array to the user
                }
                for (int sortPass = 0; sortPass <9;sortPass++) //loop to begin sorting
                {
                    for (int sortNum = 0; sortNum < 9; sortNum++)
                    {
                        if (numArray[sortNum] >numArray[sortNum + 1])
                        {
                            tmpStorage = numArray[sortNum]; //move values between saved ints for storage purposes
                            numArray[sortNum] = numArray[sortNum + 1];
                            numArray[sortNum + 1] = tmpStorage;
                        }
                    }
                    Console.Write("\n\nPass {0}:",sortPass+1);
                    foreach (int valItem in numArray)
                    {
                        Console.Write("{0} ", valItem); //display the attempts while passing
                    }
                }
                Console.WriteLine("\n\n The Sorted Array: ");
                foreach (int valItem in numArray)
                {
                    Console.Write("{0} ", valItem); //display the final sorted array
                }
            Console.ReadKey();
        }
    }
}

