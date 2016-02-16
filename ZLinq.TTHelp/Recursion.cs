using System;
using System.Text;

namespace ZLinq.TTHelp
{
    public class Recursion
    {
        private readonly string _function;
        private readonly Func<int, string> _appFunc;
        private readonly string _defaultVal;
        private readonly StringBuilder _builder;
        public Recursion(string function, Func<int, string> appFunc, string type)
        {
            _function = function;
            _appFunc = appFunc;
            _defaultVal = $"default({type})";
            _builder = new StringBuilder();
        }

        public string Apply(int n)
        {
            _builder.Clear();
            Apply(0, n);
            var result = _builder.ToString();
            return result;
        }

        private void Apply(int k, int n)
        {
            var diff = n - k;
            switch (diff)
            {
            case 0:
                _builder.Append(_defaultVal);
                return;
            case 1:
                _builder.Append(_appFunc(k));
                return;
            case 2:
                _builder.Append(_function)
                        .Append('(')
                        .Append(_appFunc(k))
                        .Append(", ")
                        .Append(_appFunc(k + 1))
                        .Append(')');
                return;
            }
            int half = (n + k) / 2;
            _builder.Append(_function).Append('(');
            Apply(k, half);
            _builder.Append(", ");
            Apply(half, n);
            _builder.Append(')');
        }
    }
}
