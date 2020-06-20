using System;
using System.Collections.Generic;
using System.Text;
using LinqExtensionMethods; // la asta ma refeream :)
using Xunit;


namespace LinqExtensionMethodsTests
{
    public class SimpleOperationsTests
    {
        [Fact]
        public void IfCollectionContainsValueWeShouldReturnTrue()
        {
            int[] collection = new int[] { 1, 2, 3, 4 };
            int value = 1;

            Assert.True(SimpleOperations.Contains(collection, value));
        }

        [Fact]
        public void IfCollectionDoNotContainsValueWeShouldReturnFalse()
        {
            int[] collection = new int[] { 1, 2, 3, 4 };
            int value = 0;

            Assert.False(SimpleOperations.Contains(collection, value));
        }
    }
}
