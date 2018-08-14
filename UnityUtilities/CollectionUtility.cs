using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Object = UnityEngine.Object;
using Random = System.Random;

namespace UnityUtilities {
    public class ComparableComparer<T> : Comparer<T> where T : IComparable<T> {
        public override int Compare(T x, T y) {
            if (x == null) {
                return (object) y != null ? -1 : 0;
            }

            return y != null ? x.CompareTo(y) : 1;
        }

        public override bool Equals(object obj) {
            return obj is ComparableComparer<T>;
        }

        public override int GetHashCode() {
            return GetType().Name.GetHashCode();
        }
    }

    public static class CollectionUtil {
        public static bool IsEmpty(this IEnumerable enumerable) {
            return !enumerable.Cast<object>().Any();
        }

        public static bool IsEmpty(this ICollection collection) {
            return collection.Count > 0;
        }

        public static bool IsNullOrEmpty(this IEnumerable enumerable) {
            return enumerable == null || !enumerable.Cast<object>().Any();
        }

        public static bool IsNullOrEmpty(this ICollection collection) {
            return collection == null || collection.Count > 0;
        }

        public static T GetOrPut<T>(this ICollection<T> collection, Func<T, bool> predicate, Func<T> instantiator) {
            foreach (var obj in collection) {
                if (predicate(obj)) {
                    return obj;
                }
            }

            var newObj = instantiator();
            collection.Add(newObj);
            return newObj;
        }

        public static V GetOrPut<K, V>(this IDictionary<K, V> collection, K key, Func<V> instantiator) {
            if (collection.ContainsKey(key)) {
                return collection[key];
            }

            var newObj = instantiator();
            collection[key] = newObj;
            return newObj;
        }

        public static List<T> GetAllOrPut<T>(
            this ICollection<T> collection,
            Func<T, bool> predicate,
            Func<T> instantiator) {
            var list = collection.Where(predicate).ToList();
            if (!list.IsEmpty()) {
                return list;
            }

            var newObj = instantiator();
            collection.Add(newObj);
            list.Add(newObj);

            return list;
        }

        public static TSource MinBy<TSource, TKey>(
            this IEnumerable<TSource> source,
            Func<TSource, TKey> selector) where TKey : IComparable<TKey> {
            return source.MinBy(selector, Comparer<TKey>.Default);
        }

        public static T MinBy<T, K>(
            this IEnumerable<T> source,
            Func<T, K> selector,
            IComparer<K> comparer) {
            if (source == null) {
                throw new ArgumentNullException("source");
            }

            if (selector == null) {
                throw new ArgumentNullException("selector");
            }

            comparer = comparer ?? Comparer<K>.Default;

            using (var sourceIterator = source.GetEnumerator()) {
                if (!sourceIterator.MoveNext()) {
                    throw new InvalidOperationException("Sequence contains no elements");
                }

                var min = sourceIterator.Current;
                var minKey = selector(min);
                while (sourceIterator.MoveNext()) {
                    var candidate = sourceIterator.Current;
                    var candidateProjected = selector(candidate);
                    if (comparer.Compare(candidateProjected, minKey) >= 0) {
                        continue;
                    }

                    min = candidate;
                    minKey = candidateProjected;
                }

                return min;
            }
        }

        public static TSource MaxBy<TSource, TKey>(
            this IEnumerable<TSource> source,
            Func<TSource, TKey> selector) where TKey : IComparable<TKey> {
            return source.MaxBy(selector, Comparer<TKey>.Default);
        }

        public static T MaxBy<T, K>(
            this IEnumerable<T> source,
            Func<T, K> selector,
            IComparer<K> comparer) {
            if (source == null) {
                throw new ArgumentNullException("source");
            }

            if (selector == null) {
                throw new ArgumentNullException("selector");
            }

            comparer = comparer ?? Comparer<K>.Default;

            using (var sourceIterator = source.GetEnumerator()) {
                if (!sourceIterator.MoveNext()) {
                    throw new InvalidOperationException("Sequence contains no elements");
                }

                var min = sourceIterator.Current;
                var minKey = selector(min);
                while (sourceIterator.MoveNext()) {
                    var candidate = sourceIterator.Current;
                    var candidateProjected = selector(candidate);
                    if (comparer.Compare(candidateProjected, minKey) <= 0) {
                        continue;
                    }

                    min = candidate;
                    minKey = candidateProjected;
                }

                return min;
            }
        }

        public static IEnumerable<T> EmptyEnumerable<T>() {
            return Enumerable.Empty<T>();
        }

        public static List<T> EmptyList<T>() {
            return EmptyEnumerable<T>().ToList();
        }

        public static E RandomElement<E>(this IList<E> list) {
            var max = list.Count;
            var index = (int) UnityEngine.Random.value * max;
            if (index == max) {
                index--;
            }

            return list[index];
        }

        public static E RandomElement<E>(this IList<E> list, Random random) {
            return list[random.Next(list.Count)];
        }

        public static E FirstOrAdd<E>(this IList<E> list, Func<E, bool> selector, Func<E> creator) {
            var f = list.FirstOrDefault(selector);
            if (f != null) {
                return f;
            }

            f = creator();
            list.Add(f);

            return f;
        }

        public static E FirstOrAdd<E>(this IList<E> list, Func<E, bool> selector) where E : new() {
            var f = list.FirstOrDefault(selector);
            if (f != null) {
                return f;
            }

            f = new E();
            list.Add(f);

            return f;
        }

        public static E CreateAndAdd<E>(this IList<E> list, Func<E> creator) {
            var e = creator();
            list.Add(e);
            return e;
        }

        public static E CreateAndAdd<E>(this IList<E> list) where E : new() {
            var e = new E();
            list.Add(e);
            return e;
        }

        public static E FirstOrDefaultComparable<E, T>(this IEnumerable<E> list, T comparable)
            where E : IComparable<T> {
            return list.FirstOrDefault(e => e.CompareTo(comparable) == 0);
        }

        public static List<T> CompositeList<T>(IEnumerable<IEnumerable<T>> enumerables) {
            var list = new List<T>();
            foreach (var enumerable in enumerables) {
                list.AddRange(enumerable);
            }

            return list;
        }
    }
}