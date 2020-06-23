using System;
using System.Collections.Generic;
using System.Text;

namespace LinqExtensionMethods
{
    public class DelegateForDebug
    {
        const int Two = 2;

        public delegate bool EqualsInt(int element);

        public delegate bool Equals<in T>(T element);

        public static bool IsOdd(int element) => element % Two == 1;
    }
}
