using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;

namespace ZLinq.Console
{
    public class MyConfig : ManualConfig
    {
        public MyConfig()
        {
            Add(Job.LegacyJitX64);
        }
    }
}