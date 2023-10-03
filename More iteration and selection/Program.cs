using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_and_selection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----------------------------------variable declaration-------------------------------------------

            int intIdentifier; //need appropriate variable identifiers
            string stringIdentifier = "hello world";

            //----------------------------------constant declaration-------------------------------------------

            const bool hulkAnger = true; //this is a constant so can never change
            bool hulkForm = false; //when you declare a value you must assign it a value

            //-------------------------------------assignment -------------------------------------------------

            intIdentifier = 4;
            stringIdentifier = Console.ReadLine(); //can assign a user's input

            //-------------------------------------iteration---------------------------------------------------

            for (int i = 1; i <= 10; i++) //i++ just means i+1, to increment different amounts use += or -+
            {
                Console.WriteLine(stringIdentifier);
                Console.WriteLine(intIdentifier);
            }

            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]); //this will output whole array
            }

            foreach (int num in nums) //goes in order and loops for each number in the array
            {
                Console.WriteLine(num);
            }

            foreach (char c in stringIdentifier)
            {
                Console.WriteLine(c); //this will output every character in the string on a new line
            }

            int n = 1;

            while (n < 10)
            {
                n++;
            }
            Console.WriteLine(n); //n will equal 10 at the end so 10 will be outputted

            //n = 1;
            //while (n>=1)
            //    {
            //    n++;
            //}
            //Console.WriteLine(n);
            //the code above will create an infinite loop

            n = 10;
            while (n < 10)
            {
                n++;
            }
            Console.WriteLine(n); //n is 10 as the loop does not run

            //n is 10
            do
            {
                n++;
            } while (n < 10);
            Console.WriteLine(n); //n is 11 as it looped once



            //--------------------------------------selection--------------------------------------------------




            //-----------------------------subroutine (procedure/function)-------------------------------------







            Console.ReadLine();
        }
    }
}
