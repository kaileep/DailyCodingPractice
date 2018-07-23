/*DAILY CODING PROJECT #1
 *Kailee Parkinson
 *Written July 20, 2018
 */

using System;

namespace DailySolution
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //initialize values and other class
            findAddition fa = new findAddition();
            string line;
            int[] vars = new int[fa.getLimit()];
            int count = 0;
            bool is_num;
            int k = 0;

            Console.WriteLine("Please enter all your numbers, pressing enter between each. Type '!' when done.");

            //records variables in array until limit is reached or ! is entered
            while(!(line = Console.ReadLine()).Equals("!") && count < fa.getLimit()) {
                is_num = Int32.TryParse(line, out vars[count]);
                count++;
            }

            Console.WriteLine("Please enter the value k:");

            //ensures that k is a number
            while(!(is_num = Int32.TryParse(Console.ReadLine(), out k))) {
                Console.WriteLine("The value k must be a number! Please try again.");
            }

            //these variables will have the numbers added together that equal k
            //or they will remain 0 if there is no matching k value
            int num1 = 0;
            int num2 = 0;

            //determines whether any two variables equal k when added together
            //is_included = true when two variables equal k, false when not
            bool is_included = fa.FindAddition(vars, k, ref num1, ref num2);

            if(is_included) {
                Console.WriteLine(num1 + " and " + num2 + " can be added to equal k!");
            }
            else {
                Console.WriteLine("No two numbers can be added to equal k!");
            }

            Console.ReadKey();
        }
    }
}
