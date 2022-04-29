using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
            // Create an integer Array of size 50
            var nums = new int[50];

            //Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(nums);

            //Print the first number of the array
            Console.WriteLine(nums[0]);

            //Print the last number of the array            
            Console.WriteLine(nums[nums.Length-1]);

            Console.WriteLine("All Numbers Original");
            //Use this method to print out your numbers from arrays or lists
            NumberPrinter(nums);
            Console.WriteLine("-------------------");

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */

            Console.WriteLine("All Numbers Reversed:");
            Array.Reverse(nums);
            NumberPrinter(nums);

            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(nums);

            Console.WriteLine("-------------------");

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(nums);
            NumberPrinter(nums);
            Console.WriteLine("-------------------");

            //Sort the array in order now
            /*      Hint: Array.____()      */
            Array.Sort(nums);
            Console.WriteLine("Sorted numbers:");
            NumberPrinter(nums);


            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List
            var likeThese = new List<int>();

            //Print the capacity of the list to the console
            Console.WriteLine(likeThese.Capacity);

            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(likeThese);

            //Print the new capacity
            Console.WriteLine(likeThese.Capacity);

            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            var goodInput = int.TryParse(Console.ReadLine(), out var search);
            while (goodInput == false)
            {
                Console.WriteLine("Come on now. You can choose a valid number. Try again.");
                goodInput = int.TryParse(Console.ReadLine(), out search);
            }
            NumberChecker(likeThese, search);
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //Print all numbers in the list
            NumberPrinter(likeThese);
            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(ref likeThese);
            NumberPrinter(likeThese);
            Console.WriteLine("------------------");

            //Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            likeThese.Sort();
            NumberPrinter(likeThese);
            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable
            var arrayedList = likeThese.ToArray();

            //Clear the list
            likeThese.Clear();
            

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }

        private static void OddKiller(ref List<int> numberList)
        {
            List<int> safeList = new List<int>(numberList);
            for (int i = 0; i < numberList.Count; i++)
            {
                if (numberList[i] % 2 != 0)
                {
                    safeList.Remove(numberList[i]);
                }
            }
            
            numberList = new List<int>(safeList);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            Console.WriteLine("It is " + $"{(numberList.Contains(searchNumber))}" + " that the number can be found here.");
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            while(numberList.Count < 50)
            {
                numberList.Add(rng.Next(0, 50));
            }
        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0, 50);
            }
        }        

        private static void ReverseArray(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
            
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
