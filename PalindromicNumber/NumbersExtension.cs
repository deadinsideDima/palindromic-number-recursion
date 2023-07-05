using System;

namespace PalindromicNumberTask
{
    /// <summary>
    /// Provides static method for working with integers.
    /// </summary>
    public static class NumbersExtension
    {
        /// <summary>
        /// Determines if a number is a palindromic number, see https://en.wikipedia.org/wiki/Palindromic_number.
        /// </summary>
        /// <param name="number">Verified number.</param>
        /// <returns>true if the verified number is palindromic number; otherwise, false.</returns>
        /// <exception cref="ArgumentException"> Thrown when source number is less than zero. </exception>
        public static bool IsPalindromicNumber(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Number less than zero", nameof(number));
            }

            int[] array = new int[10];
            int count = 9;
            while (number > 9)
            {
                array[count] = number % 10;
                number /= 10;
                count--;
            }

            array[count] = number;
            int count2 = 9;
            while (count < count2)
            {
                if (array[count] != array[count2])
                {
                    return false;
                }

                count++;
                count2--;
            }

            return true;
        }
    }
}
