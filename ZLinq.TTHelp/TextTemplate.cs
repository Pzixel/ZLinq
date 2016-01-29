using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ZLinq.TTHelp
{
    public class TextTemplate
    {
        public static readonly string[] LongableTypes =
        {
            "sbyte",
            "byte",
            "short",
            "ushort",
            "int",
            "uint",
            "long",
        };


        public static readonly string[] FloatTypes =
        {
            "float",
            "double",
            "decimal"
        };


        public static readonly string[] NumberTypes = LongableTypes.Concat(FloatTypes.Concat(new[] {"ulong"})).ToArray();

        public static readonly string[] NullableNumberTypes = NumberTypes.Select(x => x + "?").ToArray();

        public static readonly string[] ListIList = {"List<T>", "IList<T>"};
        public static readonly string[] StandardLists = new [] { "T[]" }.Concat(ListIList).ToArray();
        public static readonly string[] StandardCollections = StandardLists.Concat(new[] { "ICollection<T>" }).ToArray();
        public static readonly string[] StandardEnumerables = StandardCollections.Concat(new[] { "IEnumerable<T>" }).ToArray();
        public static readonly string[] Foreachable = {"T[]", "List<T>", "IEnumerable<T>" };

        public static string[] ToInt(IEnumerable<string> source)
        {
            return source.Select(x => x.Replace("T", "int")).ToArray();
        }

        public static string[] WithNonGen(string[] source)
        {
            var result = source.Where(x=>x.StartsWith("I", false, CultureInfo.CurrentCulture)).Select(GetCollectionName).ToArray();
            return source.Concat(result).ToArray();
        }

        public static string LengthOrCount(string typeName)
        {
            return typeName.IndexOf('[') >= 0 ? "Length" : "Count";
        }

        public static string ExplicitCastFromIntIfNeeded(string typeName)
        {
            return Array.IndexOf(NumberTypes, typeName) < 4 ? "(" + typeName + ")" : "";
        }

        public static string GetCollectionName(string collection)
        {
            if (collection.IndexOf('[') >= 0)
                return "Array";
            if (collection.IndexOf('<') < 0)
                return collection + "NonGen";
            return collection.Remove(collection.IndexOf('<'));
        }

        public static string ToArrayOrToList(string collection)
        {
            return GetCollectionName(collection) == "Array" ? "ToArray()" : "ToList()";
        }

        public static string IsNotNull(string paramName)
        {
            return $"{paramName}.IsNotNull(\"{paramName}\");";
        }

        public static string AssertFloatsRelative(string first, string second, string tolerance)
        {
            return $"Assert.IsTrue(Math.Abs(1 - {first}/(double){second}) < {tolerance}, $\"{first} = {{{first}}}\\t{second} = {{{second}}}\");";
        }

        public static string Cast(string typeName)
        {
            return typeName.IndexOfAny(new[] {'<', '['}) >= 0 ? string.Empty : "(T)";
        }

        public static string GetConstraint(string typeName)
        {
            return typeName.IndexOfAny(new[] {'<', '['}) >= 0 ? "<T>" : string.Empty;
        }
    }
}