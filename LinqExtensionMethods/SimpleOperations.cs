using System;

namespace LinqExtensionMethods
{
    public class SimpleOperations
    {
        public static bool Contains(int[] elements, int value)
        {
            if (elements == null)
            {
                return false;
            }

            foreach (var element in elements)
            {
                if (element == value)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool ConstainsOddNumbers(int[] elements)
        {
            const int odd = 2;
            if (elements == null)
            {
                return false;
            }

            foreach (var element in elements)
            {
                if (element % odd == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool ConstainsPrimes(int[] elements)
        {
            if (elements == null)
            {
                return false;
            }

            foreach (var element in elements)
            {
                if (IsPrime(element))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool IsPrime(int element)
        {
            const int two = 2;

            if (element == two)
            {
                return true;
            }

            if (element == 1 || element % two == 0)
            {
                return false;
            }

            for (int div = 3; div < element; div += two)
            {
                if (element % div == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
