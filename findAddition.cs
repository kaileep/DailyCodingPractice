/*DAILY CODING PROJECT #1
 *Kailee Parkinson
 *Written July 20, 2018
 */
using System;
namespace DailySolution
{
    //Class findAddition
    //Description: Class houses method that figures out whether two numbers in an array add up to a value marked: k
    public class findAddition
    {
        //Limit of array size
        private const int LIMIT = 30;

        public findAddition()
        {
        }

        //getLimit method
        //returns array size limit
        public int getLimit() {
            return LIMIT;
        }

        //FindAddition Method
        //Parameters: array of integers, k value, reference to num1 and num2
        public bool FindAddition(int[] variables, int k_val, ref int num1, ref int num2)
        {
            for (int i = 0; i < variables.Length; i++)
            {
                for (int j = 0; j < variables.Length; j++)
                {
                    //if two numbers in the array equal the k value
                    if (variables[i] + variables[j] == k_val)
                    {
                        //passes numbers added together to reference variables
                        num1 = variables[i];
                        num2 = variables[j];
                        return true;
                    }
                }
            }
            //if the if case does not run, then no two values add up to the k value, and the method returns false
            return false;
        }
    }
}
