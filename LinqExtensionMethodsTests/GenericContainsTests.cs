using System;
using System.Collections.Generic;
using System.Text;
using LinqExtensionMethods;
using Xunit;

namespace LinqExtensionMethodsTests_manual
{
    public class GenericContainsTests
    {
        [Fact]
        public void IfCollectionContainsValueWeShouldReturnTrue()
        {
            int[] collection = new int[] { 1, 2, 3, 4 };
            var value = 1;

            Assert.True(GenericContains.GContains(collection, new GenericExactEqualityComparer<int>(value)));
        }

        [Fact]
        public void IfCollectionDoNotContainsValueWeShouldReturnFalse()
        {
            int[] collection = new int[] { 1, 2, 3, 4 };
            int value = 0;

            Assert.False(GenericContains.GContains(collection, new GenericExactEqualityComparer<int>(value)));
        }

        [Fact]
        public void IfCollectionContainsStringValueWeShouldReturnTrue()
        {
            string[] collection = new string[] { "hello", "world"};
            var value = "hello";

            Assert.True(GenericContains.GContains(collection, new GenericExactEqualityComparer<string>(value)));
        }

        [Fact]
        public void IfCollectionDoNotContainsStringValueWeShouldReturnFalse()
        {
            string[] collection = new string[] { "hello", "world"};
            string value = "";

            Assert.False(GenericContains.GContains(collection, new GenericExactEqualityComparer<string>(value)));
        }
    }
}
