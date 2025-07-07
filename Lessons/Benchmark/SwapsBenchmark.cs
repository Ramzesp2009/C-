using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using Lesson_5;

namespace Benchmark
{
    [MemoryDiagnoser]
    public class SwapsBenchmark
    {
        [Benchmark]
        public void GenericSwapBenchmark()
        {
            double a = 1;
            double b = 5.3;
            SwapTestClass.GenericSwap(ref a, ref b);
        }

        [Benchmark]
        public void SwapBenchmark()
        {
            object p1 = 2;
            object p2 = 4;
            SwapTestClass.Swap(ref p1, ref p2);
        }
    }
}
