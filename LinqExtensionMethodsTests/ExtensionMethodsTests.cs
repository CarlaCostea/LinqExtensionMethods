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

        [Fact]
        public void SelectMethodShouldThrowAnErrorWhenSourceIsNull()
        {
            int[] source = null;

            Assert.Throws<ArgumentNullException>(() => source.Select(n => n * n));
        }

        [Fact]
        public void SelectMethodShouldThrowAnErrorWhenSelectorIsNull()
        {
            var source = new int[] { 1, 2, 3, 4 };

            var selector = source.Select<int,int>(null);

            Assert.Throws<ArgumentNullException>(() => source.Select(n => n * n));
        }

        [Fact]
        public void SelectManyMethodShouldReturnAnIEnumerableTWhoseElementsAreTheResultOfInvokingTheOneToManyTransformFunctionOnEachElementOfSource()
        {
            List<string> nameList = new List<string>() { "Carla", "Cris" };
            IEnumerable<char> methodSyntax = nameList.SelectMany(x => x);

            Assert.Equal(new[] { 'C', 'a', 'r', 'l', 'a', 'C', 'r', 'i', 's' }, methodSyntax);
        }

        [Fact]
        public void WhereMethodShouldReturnAnIEnumerableTThatContainsElementsFromTheSourceThatSatisfyTheCondition()
        {
            var source = new int[] { 1, 2, 3, 4, 5, 6 };

            var result = source.Where(n => n % 2 == 0);

            Assert.Equal(new[] { 2, 4, 6 }, result);
        }

        [Fact]
        public void WhereMethodShouldThrowAnErrorWhenSourceIsNull()
        {
            int[] source = null;

            Assert.Throws<ArgumentNullException>(() => source.Where(n => n % 2 == 0));
        }

        [Fact]
        public void WhereMethodShouldThrowAnErrorWhenPredicateIsNull()
        {
            var source = new int[] { 1, 2, 3, 4, 5, 6 };

            Assert.Throws<ArgumentNullException>(() => source.Where(null));
        }

        [Fact]
        public void ToDictionaryMethodShouldReturnADictionaryTKeyTValueThatContainsValuesOfTypeTElementSelectedFromTheInputSource()
        {
            string[] str = new string[] { "Car", "Bus", "Bicycle" };
            var result = new Dictionary<string, bool>();

            result = str.ToDictionary(item => item, item => true);

            var enumerator = result.GetEnumerator();
            enumerator.MoveNext();

            Assert.Equal(new KeyValuePair<string,bool>("Car", true), enumerator.Current);
        }

        [Fact]
        public void ToDictionaryMethodShouldThrowAnErrorWhenSourceIsNull()
        {
            string[] source = null;

            Assert.Throws<ArgumentNullException>(() => source.ToDictionary(item => item, item => true));
        }

        [Fact]
        public void ToDictionaryMethodShouldThrowAnErrorWhenKeySelectorIsNull()
        {
            string[] source = new string[] { "Car", "Bus", "Bicycle" };

            Assert.Throws<ArgumentNullException>(() => source.ToDictionary<string, int, bool>(null, item => true));
        }

        [Fact]
        public void ToDictionaryMethodShouldThrowAnErrorWhenElementSelectorIsNull()
        {
            string[] source = new string[] { "Car", "Bus", "Bicycle" };

            Assert.Throws<ArgumentNullException>(() => source.ToDictionary<string, int, bool>(item => item.GetHashCode(), null));
        }
    }
}
