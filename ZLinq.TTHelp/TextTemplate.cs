using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using ZLinq.Common;

namespace ZLinq.TTHelp
{
    public static class TT
    {
        public static readonly int[] TestSizes = {1, 2, 3, 4, 100, Constants.SingleThreadExecutionThreshold*2};
        public static readonly string[] IntableTypes =
        {
            "sbyte",
            "byte",
            "short",
            "ushort",
            "int",
        };

        public static readonly string[] FloatTypes =
        {
            "float",
            "double",
            "decimal"
        };

        public static readonly Type[] IListTypes = {typeof (IEnumerable<>), typeof (ICollection<>), typeof (IList<>)};

        public static readonly string[] LongableTypes = IntableTypes.Concat(new[] { "uint", "long" }).ToArray();
        public static readonly string[] ULongableTypes = LongableTypes.Concat(new[] { "ulong" }).ToArray();
        public static readonly string[] NumberTypes = ULongableTypes.Concat(FloatTypes).ToArray();
        public static readonly string[] NumberTypesInt = {"int"};
        public static readonly string[] NullableNumberTypes = NumberTypes.Select(x => x + "?").ToArray();
        public static readonly string[] ListIList = {"List<T>", "IList<T>"};
        public static readonly string[] StandardLists = new [] { "T[]" }.Concat(ListIList).ToArray();
        public static readonly string[] StandardCollections = StandardLists.Concat(new[] { "ICollection<T>" }).ToArray();
        public static readonly string[] StandardEnumerables = StandardCollections.Concat(new[] { "IEnumerable<T>" }).ToArray();
        public static readonly string[] Unindexable = {"ICollection<T>", "IEnumerable<T>"};
        public static readonly string[] StandardInterfaces = new[] {"IList<T>"}.Concat(Unindexable).ToArray();
        public static readonly string[] CollectionClasses = { "T[]", "List<T>" };
        public static readonly string[] Foreachable = CollectionClasses.Concat(new[] {"IEnumerable<T>"}).ToArray();

        public static string[] ToInt(this IEnumerable<string> source) => source.Select(ToInt).ToArray();

        public static string ToInt(this string source)
        {
            const string replace = "int";
            return To(source, replace);
        }

        public static string To(this string source, string replace)
        {
            if (source.IndexOf('T') < 0)
                return source;
            return source.Replace("T", replace);
        }

        public static string[] WithNonGen(this string[] source)
        {
            return source.Concat(GetNonGen(source)).ToArray();
        }

        private static string[] GetNonGen(string[] source)
        {
            return source.Where(x=>x.StartsWith("I", false, CultureInfo.CurrentCulture)).Select(GetCollectionName).ToArray();
        }

        public static string LengthOrCount(this string typeName) => typeName.IndexOf('[') >= 0 ? "Length" : "Count";

        public static string ExplicitCastFromIntIfNeeded(this string typeName) => Array.IndexOf(NumberTypes, typeName) < 4 ? "(" + typeName + ")" : "";

        public static string GetCollectionName(this string collection)
        {
            if (IsArray(collection))
                return "Array";
            int startIndex = collection.IndexOf('<');
            if (startIndex < 0)
                return collection + "NonGen";
            return collection.Remove(startIndex);
        }

        private static bool IsArray(this string collection)
        {
            return collection.IndexOf('[') >= 0;
        }

        public static string ToArrayOrToList(this string collection) => GetCollectionName(collection) == "Array" ? "ToArray()" : "ToList()";

        public static string IsNotNull(this string paramName) => $"{paramName}.IsNotNull(\"{paramName}\");";

        public static string AssertFloatsRelative(string first, string second, string tolerance)
        {
            return $"Assert.IsTrue(Math.Abs(1 - {first}/(double){second}) < {tolerance}, $\"{first} = {{{first}}}\\t{second} = {{{second}}}\");";
        }

        public static string Cast(this string typeName) => typeName.IndexOfAny(new[] {'<', '['}) >= 0 ? string.Empty : "(T)";

        public static string GetConstraint(this string typeName) => typeName.IndexOfAny(new[] {'<', '['}) >= 0 ? "<T>" : string.Empty;

        public static string[] GetNullables(this IEnumerable<string> types) => types.Select(x => x + "?").ToArray();

        public static string AreEqual(string a, string b) => $@"Assert.IsTrue({a} == {b}, $""{a} ={{{a}}}\t{b} ={{{b}}}"");;";

        public static string AreNotEqual(string a, string b) => $@"Assert.IsFalse({a} == {b}, $""{a} ={{{a}}}\t{b} ={{{b}}}"");;";

        public static bool CannotBeRepresented(this string type, int value)
        {
            if (type.StartsWith("byte"))
                return value > byte.MaxValue;
            if (type.StartsWith("sbyte"))
                return value > sbyte.MaxValue;
            return false;
        }


        public static bool CanBeRepresented(this string type, int value) => !CannotBeRepresented(type, value);

        public static string GetNullableName(this string type)
        {
            int index = type.IndexOf('?');
            if (index < 0)
                return type;
            return type.Remove(index) + "Nullable";
        }

        public static string GetMaxValue(this string type)
        {
            string trimmedType = type.TrimEnd('?');
            if (Array.IndexOf(IntableTypes, trimmedType) >= 0)
                return trimmedType + ".MaxValue";
            return "int.MaxValue";
        }

        public static string GetSuffix(this string type)
        {
            switch (type)
            {
                case "IEnumerable<T>":
                    return "Seq";
                case "List<T>":
                    return "List";
                case "IList<T>":
                    return "IList";
                default:
                    return string.Empty;
            }
        }

        public static string New(this string type, string lengthOrCount)
        {
            if (IsArray(type))
            {
                return $"new T[{lengthOrCount}];";
            }
            return $"new List<T>({lengthOrCount});";
        }
        
        public static string InitForeach(this string type, string result, string lengthOrCount)
        {
            if (IsArray(type))
                return $"for (int i = 0; i < {result}.Length; i++)";
            return $"for (int i = 0; i < {lengthOrCount}; i++)";
        }

        public static string Set(this string type, string result, string value)
        {
            if (IsArray(type))
                return $"{result}[i] = {value};";
            return $"{result}.Add({value});";
        }

        public static string NewInitLoop(this string type, string result, string lengthOrCount, string value, string tabs)
        {
            string newBlock = New(type, lengthOrCount);
            string foreachBlock = InitForeach(type, result, lengthOrCount);
            string setBlock = Set(type, result, value);
            string rn = Environment.NewLine;
            return $"var {result} = {newBlock}{rn}{tabs}{foreachBlock}{rn}{tabs}{"    "}{setBlock}";
        }

        public static string Expand(this string type)
        {
            string expandNotNull = ExpandNotNull(type);
            if (type.EndsWith("?"))
                expandNotNull += "?";
            return "(" + expandNotNull + ")";
        }

        private static string ExpandNotNull(this string type)
        {
            return IsFloat(type) ? "double" : "long";
        }

        public static bool IsFloat(this string type)
        {
            return type.StartsWith("float") || type.StartsWith("decimal") || type.StartsWith("double");
        }

        public static string[] WithNullables(this string[] source)
        {
            return source.Concat(GetNullables(source)).ToArray();
        }

        public static string UnwrapNullable(this string type, string source)
        {
            if (!type.EndsWith("?"))
                return source;
            return $"({source} ?? 0)";
        }

        public static bool IsNullable(this string type) => type[type.Length - 1] == '?';

        public static string Envelope(this string shell, string value) => shell == string.Empty ? value : $"{shell}({value})";
        public static IEnumerable<int> Unroll = Enumerable.Range(0, Constants.Step);
        public static IEnumerable<int> UnrollInclusive = Enumerable.Range(0, Constants.Step + 1);
        public static string GetMaxNullable(string max, string candidate) => $"{candidate}.HasValue && ({GetMaxNullableNoCheck(max, candidate)})";
        public static string GetMaxNullableNoCheck(string max, string candidate) => $"{max} < {candidate} || !{max}.HasValue";

        public static string IsHigher(bool isNullable, string maxName, string candidate) => GetHigher(isNullable, maxName, candidate, GetMaxNullable);

        public static string IsHigherNoCheck(bool isNullable, string maxName, string candidate) => GetHigher(isNullable, maxName, candidate, GetMaxNullableNoCheck);

        private static string GetHigher(bool isNullable, string maxName, string candidate, Func<string, string, string> func)
        {
            return isNullable ? func(maxName, candidate) : maxName + " < " + candidate;
        }

        public static string GetCorrectTypeName(this Type type)
        {
            if (type.FullName == "System.Void")
                return "void";
            if (type.IsGenericParameter)
                return type.Name;
            var prefix = new StringBuilder();
            if (!string.IsNullOrEmpty(type.Namespace))
                prefix.Append(type.Namespace).Append('.');
            if (type.IsNested && type.DeclaringType != null)
                prefix.Append(type.DeclaringType.Name).Append('.');

            if (type.IsGenericType)
            {
                var mainName = type.Name.Substring(0, type.Name.IndexOf('`'));
                string args = string.Join(", ", type.GetGenericArguments().Select(GetCorrectTypeName).ToArray());
                return prefix.Append(mainName).Append('<').Append(args).Append('>').ToString();
            }

            if (type.IsArray)
                return GetCorrectTypeName(type.GetElementType()) + "[" + new string(',', type.GetArrayRank() - 1) + "]";

            return prefix.Append(type.Name).ToString();
        }

        public static string GetFineName(this Type type)
        {
            int startIndex = type.Name.IndexOf('`');
            if (startIndex < 0)
                return type.Name;
            return type.Name.Remove(startIndex);
        }

        public static string ToCollection(this string sourceType)
        {
            return $"To{GetCollectionName(sourceType)}();";
        }

        public static bool IsIndexable(this string type)
        {
            if (type.IndexOf('[') >= 0)
                return true;
            return type.StartsWith("List<") || type.StartsWith("IList<");
        }
    }
}