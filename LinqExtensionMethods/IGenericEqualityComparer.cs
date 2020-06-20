using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LinqExtensionMethods
{
    public interface IGenericEqualityComparer<in T>
    {
        bool Equals(T number);
    }
}
