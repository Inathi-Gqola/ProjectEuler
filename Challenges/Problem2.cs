﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Euler.Challenges
{
    /// <summary>
    /// Each new term in the Fibonacci sequence is generated by adding the previous two terms.
    /// By starting with 1 and 2, the first 10 terms will be:  1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ... 
    /// By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
    /// URL: https://projecteuler.net/problem=2
    /// </summary>
    class Problem2:IProblem
    {
        private int GetFibonacciSum(int limit = 4000000)
        {
            int first = 1;
            int second = 1;
            int buffer = 0;
            int totalEven = 0;

            while (buffer < limit)
            {
                if (IsEven(buffer))
                    totalEven += buffer;

                buffer = first + second;
                first = second;
                second = buffer;

               Trace.WriteLine($"{buffer}");

            }

            return totalEven;
        }

        /// <summary>
        /// Checks if a given number is even or odd.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private bool IsEven(int number)
        {
           return ((number % 2) == 0);
        }

        public object GetSolution()
        {
            return GetFibonacciSum();
        }
    }
}
