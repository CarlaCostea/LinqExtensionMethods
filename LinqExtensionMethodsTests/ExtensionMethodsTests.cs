using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using LinqExtensionMethods;
using Xunit;

namespace LinqExtensionMethodsTests_manual
{
    public class ExtensionMethodsTests
    {
        [Fact]
        public void AllMethodShouldReturnTrueWhenPredicateIsTrueForAllElementsInSource()
        {
            var source = new int[] { 1, 2, 3, 4, 5 };

            Assert.True(source.All(n => n <= 5));
        }

        [Fact]
        public void AllMethodShouldReturnFalseWhenPredicateIsNotTrueForAllElementsInSource()
        {
            var source = new int[] { 1, 2, 3, 4, 5 };

            Assert.False(source.All(n => n < 5));
        }

        [Fact]
        public void AllMethodShouldThrowAnErrorWhenSourceIsNull()
        {
            var source = new int[0];
            source = null;

            Assert.Throws<ArgumentNullException>(() => source.All(n => n < 5));
        }

        [Fact]
        public void AnyMethodShouldReturnTrueWhenPredicateIsTrueForAnyElementsInSource()
        {
            var source = new int[] { 1, 2, 3, 4, 5 };

            Assert.True(source.Any(n => n <= 3));
        }

        [Fact]
        public void AnyMethodShouldReturnFalseWhenPredicateIsFalseForAllElementsInSource()
        {
            var source = new int[] { 1, 2, 3, 4, 5 };

            Assert.False(source.Any(n => n > 5));
        }

        [Fact]
        public void AnyMethodShouldThrowAnErrorWhenSourceIsNull()
        {
            var source = new int[0];
            source = null;

            Assert.Throws<ArgumentNullException>(() => source.Any(n => n < 5));
        }

        [Fact]
        public void FirstMethodShouldReturnTheFirsElementInTheSourceForWhichThePredicateIsTrue()
        {
            var source = new int[] { 1, 2, 3, 4, 5 };

            Assert.Equal(4, source.First(n => n > 3));
        }

        [Fact]
        public void FirstMethodShouldThrowInvalidOperationExceptionWhenPredicateIsFalseForAllElementsInSource()
        {
            var source = new int[] { 1, 2, 3, 4, 5 };

            Assert.Throws<InvalidOperationException>(() => source.First(n => n > 5));
        }

        [Fact]
        public void FirstMethodShouldThrowAnErrorWhenSourceIsNull()
        {
            var source = new int[0];
            source = null;

            Assert.Throws<ArgumentNullException>(() => source.First(n => n < 5));
        }

        [Fact]
        public void SelectMethodShouldReturnAnIEnumerableTWhoseElementsAreTheResultOfInvokingTheTransformFunctionOnEachElementOfSource()
        {
            var source = new int[] { 1, 2, 3, 4 };

            var selector = source.Select(n => n * n);

            Assert.Equal(new[] { 1, 4, 9, 16 }, selector);
        }
    }
}
