﻿using System;
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

        [Fact]
        public void IfCollectionContainsOddNumbersWeShouldReturnTrue()
        {
            int[] collection = new int[] { 1, 2, 3, 4 };

            Assert.True(SimpleOperations.ConstainsOddNumbers(collection));
        }

        [Fact]
        public void IfCollectionDoNotContainsOddNumbersWeShouldReturnFalse()
        {
            int[] collection = new int[] { 1, 5, 3, 7 };
            
            Assert.False(SimpleOperations.ConstainsOddNumbers(collection));
        }

        [Fact]
        public void IfCollectionContainsPrimeNumbersWeShouldReturnTrue()
        {
            int[] collection = new int[] { 2, 3, 5, 11 };

            Assert.True(SimpleOperations.ConstainsPrimes(collection));
        }

        [Fact]
        public void IfCollectionDoNotContainsPrimeNumbersWeShouldReturnFalse()
        {
            int[] collection = new int[] { 1, 6, 12, 9};

            Assert.False(SimpleOperations.ConstainsPrimes(collection));
        }
    }
}
