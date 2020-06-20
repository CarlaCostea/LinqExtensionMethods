using System;
using System.Collections.Generic;
using System.Text;

namespace LinqExtensionMethods
{
    public class EvenEqualityComparer : IEqualityComparer
    {
        const int Two = 2;

        public bool Equals(int number) => number % Two == 0;
    }
}
