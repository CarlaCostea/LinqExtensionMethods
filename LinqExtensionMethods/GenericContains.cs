using System;
using System.Collections.Generic;
using System.Text;

namespace LinqExtensionMethods
{
    public class GenericContains
    {
        public static bool GContains<T>(IEnumerable<T> elements, IGenericEqualityComparer<T> equalityComparer)
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
