using System.Text;

// ReSharper disable once CheckNamespace
namespace ZLinq
{
    public static partial class ZEnumerable
    {
        public static string ToStr<T>(this T[] source)
        {
            if (source == null)
                return string.Empty;
            if (source.Length == 0)
                return "[]";
            var sb = new StringBuilder(source.Length*4).Append('[');
            for (int i = 0; i < source.Length - 1; i++)
            {
                sb.Append(source[i]).Append(", ");
            }
            sb.Append(source[source.Length - 1]).Append(']');
            return sb.ToString();
        }
    }
}
