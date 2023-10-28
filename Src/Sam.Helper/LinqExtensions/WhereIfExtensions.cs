using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Sam.Helper.LinqExtensions
{
    public static class WhereIfExtensions
    {
        public static IQueryable<T> WhereIf<T>(this IQueryable<T> query, bool condition, Expression<Func<T, bool>> predicate)
        {
            if (condition)
            {
                return query.Where(predicate);
            }
            return query;
        }

        public static IEnumerable<T> WhereIf<T>(this IEnumerable<T> collection, bool condition, Func<T, bool> predicate)
        {
            if (condition)
            {
                return collection.Where(predicate);
            }
            return collection;
        }

        public static ICollection<T> WhereIf<T>(this ICollection<T> collection, bool condition, Func<T, bool> predicate)
        {
            if (condition)
            {
                return collection.Where(predicate).ToList();
            }
            return collection;
        }

        public static List<T> WhereIf<T>(this List<T> list, bool condition, Func<T, bool> predicate)
        {
            if (condition)
            {
                return list.Where(predicate).ToList();
            }
            return list;
        }

        public static T[] WhereIf<T>(this T[] array, bool condition, Predicate<T> predicate)
        {
            if (condition)
            {
                return Array.FindAll(array, predicate);
            }
            return array;
        }

        public static HashSet<T> WhereIf<T>(this HashSet<T> set, bool condition, Func<T, bool> predicate)
        {
            if (condition)
            {
                var resultSet = new HashSet<T>();
                foreach (var item in set)
                {
                    if (predicate(item))
                    {
                        resultSet.Add(item);
                    }
                }
                return resultSet;
            }
            return set;
        }

    }
}
