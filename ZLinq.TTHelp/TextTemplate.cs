using System;
using System.Linq;

namespace ZLinq.TTHelp
{
    public class TextTemplate
    {
        public static readonly string[] NumberTypes =
        {
            "sbyte",
            "byte",
            "short",
            "ushort",
            "int",
            "uint",
            "long",
            "ulong",
            "float",
            "double",
            "decimal"
        };

        public static readonly string[] NullableNumberTypes = NumberTypes.Select(x => x + "?").ToArray();

        public static readonly string[] ListIList = {"List<T>", "IList<T>"};
        public static readonly string[] CollectionsIList = new [] { "T[]" }.Concat(ListIList).ToArray();
        public static readonly string[] CollectionsIListInt = CollectionsIList.Select(x => x.Replace("T", "int")).ToArray();
        public static readonly string[] CollectionList = CollectionsIList.Concat(new[] { "ICollection<T>"}).ToArray();
        public static readonly string[] CollectionsListInt = CollectionList.Select(x => x.Replace("T", "int")).ToArray();
        public static readonly string[] EnumerablesList = CollectionList.Concat(new[] { "IEnumerable<T>" }).ToArray();
        public static readonly string[] EnumerablesListInt = EnumerablesList.Select(x => x.Replace("T", "int")).ToArray();


        public static string LengthOrCount(string typeName)
        {
            return typeName.IndexOf("[]", StringComparison.Ordinal) >= 0 ? "Length" : "Count";
        }

        public static string ExplicitCastFromIntIfNeeded(string typeName)
        {
            return Array.IndexOf(NumberTypes, typeName) < 4 ? "(" + typeName + ")" : "";
        }

        public static string GetCollectionName(string collection)
        {
            if (collection.IndexOf('[') >= 0)
                return "Array";
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
    }
}