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
    }
}
