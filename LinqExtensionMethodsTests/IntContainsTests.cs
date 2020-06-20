using System;
using System.Collections.Generic;
using System.Text;
using LinqExtensionMethods;
using Xunit;

namespace LinqExtensionMethodsTests_manual
{
    public class IntContainsTests
    {
        [Fact]
        public void IfCollectionContainsValueWeShouldReturnTrue()
        {
            int[] collection = new int[] { 1, 2, 3, 4 };
            int value = 1;

            Assert.True(IntContains.IContains(collection, new ExactEqualityComparer(value)));
        }

        [Fact]
        public void IfCollectionDoNotContainsValueWeShouldReturnFalse()
        {
            int[] collection = new int[] { 1, 2, 3, 4 };
            int value = 0;

            Assert.False(IntContains.IContains(collection, new ExactEqualityComparer(value)));
        }

        [Fact]
        public void IfCollectionContainsOddNumbersWeShouldReturnTrue()
        {
            int[] collection = new int[] { 1, 2, 3, 4 };

            Assert.True(IntContains.IContains(collection, new EvenEqualityComparer()));
        }

        [Fact]
        public void IfCollectionDoNotContainsOddNumbersWeShouldReturnFalse()
        {
            int[] collection = new int[] { 1, 5, 3, 7 };

            Assert.False(IntContains.IContains(collection, new EvenEqualityComparer()));
        }

        [Fact]
        public void IfCollectionContainsPrimeNumbersWeShouldReturnTrue()
        {
            int[] collection = new int[] { 2, 3, 5, 11 };

            Assert.True(IntContains.IContains(collection, new PrimeEqualityComparer()));
        }

        [Fact]
        public void IfCollectionDoNotContainsPrimeNumbersWeShouldReturnFalse()
        {
            int[] collection = new int[] { 1, 6, 12, 9 };

            Assert.False(IntContains.IContains(collection, new PrimeEqualityComparer()));
        }
    }
}
