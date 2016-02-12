using System;

namespace ZLinq.TTHelp
{
    public class Recursion
    {
        private readonly string _function;
        private readonly Func<int, string> _appFunc;

        public Recursion(string function, Func<int, string> appFunc)
        {
            _function = function;
            _appFunc = appFunc;
        }

        public string Apply(int n)
        {
            return Apply(0, n);
        }

        private string Apply(int k, int n)
        {
            var diff = n - k;
            if (diff == 0)
                return "0";
            if (diff == 1)
                return _appFunc(k);
            if (diff == 2)
                return $"{_function}({_appFunc(k)}, {_appFunc(k + 1)})";
            int half = (n + k) / 2;
            return $"{_function}({Apply(k, half)}, {Apply(half, n)})";
        }
    }
}
