using System;
using System.Collections.Generic;
using System.Text;

namespace LinqExtensionMethods
{
    public class ExactEqualityComparer : IEqualityComparer
    {
        readonly int value;

        public ExactEqualityComparer(int value)
        {
            this.value = value;
        }

        public bool Equals(int number) => number == value;
    }
}
