using System;

namespace Euler.Challenges
{
    /// <summary>
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.
    /// The sum of these multiples is 23. Find the sum of all the multiples of 3 or 5 below 1000.
    /// URL: https://projecteuler.net/problem=1
    /// </summary>
    public class Problem1:IProblem
    {
        /// <summary>
        /// Returns a sum of all the multiples of 3 or 5 below 1000. Bruteforce.
        /// </summary>
        /// <returns>integer</returns>
        private int GetSum()
        {
            int sum = default;

            for(int counter = 1; counter < 1000; counter++)
            {
                bool isMultipleOfThree = (counter % 3 == 0);
                bool isMultipleOfFive = (counter % 5 == 0);

                if (isMultipleOfFive || isMultipleOfThree)
                {
                    sum += counter;
                }
            }
            return sum;
        }

        /// <summary>
        /// Returns a sum of all the multiples of 3 or 5 below 1000 - efficiently.
        /// </summary>
        /// <returns>integer</returns>
        private int GetSumEfficiently()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the solution of the problem.
        /// </summary>
        /// <returns>integer</returns>
        public object GetSolution()
        {
            return GetSum();
        }
    }
}
