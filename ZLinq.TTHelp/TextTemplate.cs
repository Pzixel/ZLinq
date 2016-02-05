﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ZLinq.TTHelp
{
    public class TT
    {
        public static readonly string[] IntableTypes =
        {
            "sbyte",
            "byte",
            "short",
            "ushort",
            "int",
        };

        public static readonly string[] LongableTypes = IntableTypes.Concat(new[]
                                                                            {

                                                                                "uint",
                                                                                "long",
                                                                            }).ToArray();


        public static readonly string[] FloatTypes =
        {
            "float",
            "double",
            "decimal"
        };


        public static readonly string[] NumberTypes = LongableTypes.Concat(FloatTypes.Concat(new[] {"ulong"})).ToArray();
        public static readonly string[] NumberTypesInt = {"int"};

        public static readonly string[] NullableNumberTypes = NumberTypes.Select(x => x + "?").ToArray();

        public static readonly string[] ListIList = {"List<T>", "IList<T>"};
        public static readonly string[] StandardLists = new [] { "T[]" }.Concat(ListIList).ToArray();
        public static readonly string[] StandardCollections = StandardLists.Concat(new[] { "ICollection<T>" }).ToArray();
        public static readonly string[] StandardEnumerables = StandardCollections.Concat(new[] { "IEnumerable<T>" }).ToArray();
        public static readonly string[] Unindexable = {"ICollection<T>", "IEnumerable<T>"};
        public static readonly string[] StandardInterfaces = new[] {"IList<T>"}.Concat(Unindexable).ToArray();
        public static readonly string[] Foreachable = {"T[]", "List<T>", "IEnumerable<T>" };

        public static string[] ToInt(IEnumerable<string> source) => source.Select(ToInt).ToArray();

        public static string ToInt(string source)
        {
            const string replace = "int";
            return To(source, replace);
        }

        public static string To(string source, string replace) => source.Replace("T", replace);

        public static string[] WithNonGen(string[] source)
        {
            var result = source.Where(x=>x.StartsWith("I", false, CultureInfo.CurrentCulture)).Select(GetCollectionName).ToArray();
            return source.Concat(result).ToArray();
        }

        public static string LengthOrCount(string typeName) => typeName.IndexOf('[') >= 0 ? "Length" : "Count";

        public static string ExplicitCastFromIntIfNeeded(string typeName) => Array.IndexOf(NumberTypes, typeName) < 4 ? "(" + typeName + ")" : "";

        public static string GetCollectionName(string collection)
        {
            if (collection.IndexOf('[') >= 0)
                return "Array";
            if (collection.IndexOf('<') < 0)
                return collection + "NonGen";
            return collection.Remove(collection.IndexOf('<'));
        }

        public static string ToArrayOrToList(string collection) => GetCollectionName(collection) == "Array" ? "ToArray()" : "ToList()";

        public static string IsNotNull(string paramName) => $"{paramName}.IsNotNull(\"{paramName}\");";

        public static string AssertFloatsRelative(string first, string second, string tolerance)
        {
            return $"Assert.IsTrue(Math.Abs(1 - {first}/(double){second}) < {tolerance}, $\"{first} = {{{first}}}\\t{second} = {{{second}}}\");";
        }

        public static string Cast(string typeName) => typeName.IndexOfAny(new[] {'<', '['}) >= 0 ? string.Empty : "(T)";

        public static string GetConstraint(string typeName) => typeName.IndexOfAny(new[] {'<', '['}) >= 0 ? "<T>" : string.Empty;

        public static string[] GetNullables(IEnumerable<string> types) => types.Select(x => x + "?").ToArray();

        public static string AreEqual(string a, string b) => $@"Assert.IsTrue({a} == {b}, $""{a} ={{{a}}}\t{b} ={{{b}}}"");;";

        public static string AreNotEqual(string a, string b) => $@"Assert.IsFalse({a} == {b}, $""{a} ={{{a}}}\t{b} ={{{b}}}"");;";

        public static bool CannotBeRepresented(string type, int value)
        {
            if (type.StartsWith("byte"))
                return value > byte.MaxValue;
            if (type.StartsWith("sbyte"))
                return value > sbyte.MaxValue;
            return false;
        }


        public static bool CanBeRepresented(string type, int value) => !CannotBeRepresented(type, value);

        public static string GetNullableName(string type)
        {
            int index = type.IndexOf('?');
            if (index < 0)
                return type;
            return type.Remove(index) + "Nullable";
        }

        public static string GetMaxValue(string type)
        {
            string trimmedType = type.TrimEnd('?');
            if (Array.IndexOf(IntableTypes, trimmedType) >= 0)
                return trimmedType + ".MaxValue";
            return "int.MaxValue";
        }
    }
}