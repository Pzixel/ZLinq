using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;

namespace ZConsole.Configs
{
    public class X64 : ManualConfig
    {
        public X64()
        {
            Add(Job.LegacyJitX64);
        }
    }
}