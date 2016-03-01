namespace ZConsole.General
{
    internal struct Pivot
    {
        public int LeftBound { get; }
        public int RightBound { get; }
        public int Middle { get; }

        public Pivot(int leftBound, int rightBound, int middle)
        {
            LeftBound = leftBound;
            RightBound = rightBound;
            Middle = middle;
        }
    }
}
