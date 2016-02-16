
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Linq;


namespace ZLinq.Test.Helpers
{
    public static class Maxer
    {        
        
        public static sbyte GetMax(IEnumerable<sbyte> source)
        {
           if (!source.Any())
              return default(sbyte);
           var result = source.First();
           foreach(var x in source)
           {
                if (result < x)
                    result = x;
           }
           return result;
        }
        
        public static byte GetMax(IEnumerable<byte> source)
        {
           if (!source.Any())
              return default(byte);
           var result = source.First();
           foreach(var x in source)
           {
                if (result < x)
                    result = x;
           }
           return result;
        }
        
        public static short GetMax(IEnumerable<short> source)
        {
           if (!source.Any())
              return default(short);
           var result = source.First();
           foreach(var x in source)
           {
                if (result < x)
                    result = x;
           }
           return result;
        }
        
        public static ushort GetMax(IEnumerable<ushort> source)
        {
           if (!source.Any())
              return default(ushort);
           var result = source.First();
           foreach(var x in source)
           {
                if (result < x)
                    result = x;
           }
           return result;
        }
        
        public static int GetMax(IEnumerable<int> source)
        {
           if (!source.Any())
              return default(int);
           var result = source.First();
           foreach(var x in source)
           {
                if (result < x)
                    result = x;
           }
           return result;
        }
        
        public static uint GetMax(IEnumerable<uint> source)
        {
           if (!source.Any())
              return default(uint);
           var result = source.First();
           foreach(var x in source)
           {
                if (result < x)
                    result = x;
           }
           return result;
        }
        
        public static long GetMax(IEnumerable<long> source)
        {
           if (!source.Any())
              return default(long);
           var result = source.First();
           foreach(var x in source)
           {
                if (result < x)
                    result = x;
           }
           return result;
        }
        
        public static ulong GetMax(IEnumerable<ulong> source)
        {
           if (!source.Any())
              return default(ulong);
           var result = source.First();
           foreach(var x in source)
           {
                if (result < x)
                    result = x;
           }
           return result;
        }
        
        public static float GetMax(IEnumerable<float> source)
        {
           if (!source.Any())
              return default(float);
           var result = source.First();
           foreach(var x in source)
           {
                if (result < x)
                    result = x;
           }
           return result;
        }
        
        public static double GetMax(IEnumerable<double> source)
        {
           if (!source.Any())
              return default(double);
           var result = source.First();
           foreach(var x in source)
           {
                if (result < x)
                    result = x;
           }
           return result;
        }
        
        public static decimal GetMax(IEnumerable<decimal> source)
        {
           if (!source.Any())
              return default(decimal);
           var result = source.First();
           foreach(var x in source)
           {
                if (result < x)
                    result = x;
           }
           return result;
        }
        
        public static sbyte? GetMax(IEnumerable<sbyte?> source)
        {
           if (!source.Any())
              return default(sbyte?);
           var result = source.First();
           foreach(var x in source)
           {
                if (result < x || !result.HasValue)
                    result = x;
           }
           return result;
        }
        
        public static byte? GetMax(IEnumerable<byte?> source)
        {
           if (!source.Any())
              return default(byte?);
           var result = source.First();
           foreach(var x in source)
           {
                if (result < x || !result.HasValue)
                    result = x;
           }
           return result;
        }
        
        public static short? GetMax(IEnumerable<short?> source)
        {
           if (!source.Any())
              return default(short?);
           var result = source.First();
           foreach(var x in source)
           {
                if (result < x || !result.HasValue)
                    result = x;
           }
           return result;
        }
        
        public static ushort? GetMax(IEnumerable<ushort?> source)
        {
           if (!source.Any())
              return default(ushort?);
           var result = source.First();
           foreach(var x in source)
           {
                if (result < x || !result.HasValue)
                    result = x;
           }
           return result;
        }
        
        public static int? GetMax(IEnumerable<int?> source)
        {
           if (!source.Any())
              return default(int?);
           var result = source.First();
           foreach(var x in source)
           {
                if (result < x || !result.HasValue)
                    result = x;
           }
           return result;
        }
        
        public static uint? GetMax(IEnumerable<uint?> source)
        {
           if (!source.Any())
              return default(uint?);
           var result = source.First();
           foreach(var x in source)
           {
                if (result < x || !result.HasValue)
                    result = x;
           }
           return result;
        }
        
        public static long? GetMax(IEnumerable<long?> source)
        {
           if (!source.Any())
              return default(long?);
           var result = source.First();
           foreach(var x in source)
           {
                if (result < x || !result.HasValue)
                    result = x;
           }
           return result;
        }
        
        public static ulong? GetMax(IEnumerable<ulong?> source)
        {
           if (!source.Any())
              return default(ulong?);
           var result = source.First();
           foreach(var x in source)
           {
                if (result < x || !result.HasValue)
                    result = x;
           }
           return result;
        }
        
        public static float? GetMax(IEnumerable<float?> source)
        {
           if (!source.Any())
              return default(float?);
           var result = source.First();
           foreach(var x in source)
           {
                if (result < x || !result.HasValue)
                    result = x;
           }
           return result;
        }
        
        public static double? GetMax(IEnumerable<double?> source)
        {
           if (!source.Any())
              return default(double?);
           var result = source.First();
           foreach(var x in source)
           {
                if (result < x || !result.HasValue)
                    result = x;
           }
           return result;
        }
        
        public static decimal? GetMax(IEnumerable<decimal?> source)
        {
           if (!source.Any())
              return default(decimal?);
           var result = source.First();
           foreach(var x in source)
           {
                if (result < x || !result.HasValue)
                    result = x;
           }
           return result;
        }
        
    }
}
