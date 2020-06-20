using System;
using System.Collections.Generic;
using System.Text;

namespace LinqExtensionMethods
{
    public class PrimeEqualityComparer : IEqualityComparer
    {
        public bool Equals(int number) => SimpleOperations.IsPrime(number);
    }
}
