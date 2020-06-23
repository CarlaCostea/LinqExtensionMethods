using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace LinqExtensionMethods
{
    public static class ExtensionMethods
    {
        public static bool All<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            foreach (var element in source)
            {
                if (!predicate(element))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool Any<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
             if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

             foreach (var element in source)
            {
                if (predicate(element))
                {
                    return true;
                }
            }

             return false;
        }

        public static TSource First<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            foreach (var element in source)
            {
                if (predicate(element))
                {
                    return element;
                }
            }

            throw new InvalidOperationException();
        }

        public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (selector == null)
            {
                throw new ArgumentNullException(nameof(selector));
            }

            foreach (var element in source)
            {
                yield return selector(element);
            }
        }

        public static IEnumerable<TResult> SelectMany<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (selector == null)
            {
                throw new ArgumentNullException(nameof(selector));
            }

            foreach (var element in source)
            {
                foreach (var resultElement in selector(element))
                {
                    yield return resultElement;
                }
            }
        }
    }
}
