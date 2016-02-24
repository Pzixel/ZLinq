using BenchmarkDotNet.Attributes;

namespace ZLinq.Console
{
public class BencmarkBug
{
    [Params(3000, 5000, 8000, 10000)]
    public int Treshold { get; set; }

    [Benchmark]
    public object Foo()
    {
        return Treshold;
    }
}
}
