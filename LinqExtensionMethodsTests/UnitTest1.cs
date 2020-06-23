using System;
using Xunit;
using LinqExtensionMethods;

namespace LinqExtensionMethodsTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestDelegateIsOdd()
        {
            DelegateForDebug.EqualsInt equals = DelegateForDebug.IsOdd;
            Assert.True(equals(3));
        }
    }
}
