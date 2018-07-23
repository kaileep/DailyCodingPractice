using System;
namespace DailySolution
{
    public class findAddition
    {
        const int LIMIT = 30;

        public findAddition()
        {
        }

        public int getLimit() {
            return LIMIT;
        }

        public bool FindAddition(int[] variables, int k_val, ref int num1, ref int num2)
        {
            for (int i = 0; i < variables.Length; i++)
            {
                for (int j = 0; j < variables.Length; j++)
                {
                    if (variables[i] + variables[j] == k_val)
                    {
                        //passes numbers added together to reference variables
                        num1 = variables[i];
                        num2 = variables[j];
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
