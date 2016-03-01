using System;
using System.Diagnostics;

namespace ZConsole.General
{
    [DebuggerDisplay("[{StartIndex}, {EndIndex}]\tLength = {Length}")]
    internal class Range
    {
        public int StartIndex { get; }
        public int Length { get; }
        public int EndIndex => Length + StartIndex - 1;

        public Range(int startIndex, int length)
        {
            StartIndex = startIndex;
            Length = length;
        }

        private static Range FromIndex(int startIndex, int endIndex)
        {
            var length = endIndex - startIndex + 1;
            return new Range(startIndex, length);
        }

        public static Range[] FromArray<T>(T[] source)
        {
            return FromArray(source, Environment.ProcessorCount);
        }

        public static Range[] FromArray<T>(T[] source, int splitCount)
        {
            int partitionLength = (int)(source.Length / (double)splitCount);
            var result = new Range[splitCount];
            int start = 0;
            for (int i = 0; i < result.Length - 1; i++)
            {
                result[i] = new Range(start, partitionLength);
                start += partitionLength;
            }
            result[result.Length - 1] = new Range(start, source.Length - start);
            return result;
        }

        public Range Union(Range range)
        {
            var min = Math.Min(StartIndex, range.StartIndex);
            return new Range(min, Length + range.Length);
        }

        public Tuple<Range, Range> Split(int pivot)
        {
            var range1 = FromIndex(StartIndex, pivot - 1);
            var range2 = FromIndex(pivot, EndIndex);
            return new Tuple<Range, Range>(range1, range2);
        }
    }
}
