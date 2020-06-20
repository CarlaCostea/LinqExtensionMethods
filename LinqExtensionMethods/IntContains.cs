using System;
using System.Collections.Generic;
using System.Text;

namespace LinqExtensionMethods
{
    public class IntContains
    {
        public static bool GContains(int[] elements, IEqualityComparer equalityComparer)
        {
            if (elements == null || equalityComparer == null)
            {
                return false;
            }

            foreach (var element in elements)
            {
                if (equalityComparer.Equals(element))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
