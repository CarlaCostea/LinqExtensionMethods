using System;
using System.Collections.Generic;
using System.Text;

namespace LinqExtensionMethods
{
    public class GenericExactEqualityComparer<T> : IGenericEqualityComparer<T>
    {
        readonly T value;

        public GenericExactEqualityComparer(T value)
        {
            this.value = value;
        }

        public bool Equals(T number) => value.Equals(number);
    }
}
