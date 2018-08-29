using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace EveryTimeYouListOfTAnyAKittenDies
{
    [MemoryDiagnoser]
    public class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Program>();
        }

        [Benchmark]
        [ArgumentsSource(nameof(Lists))]
        public bool Any(List<int> list) => list.Any();

        [Benchmark]
        [ArgumentsSource(nameof(Lists))]
        public bool CountNotEqual0(List<int> list) => list.Count != 0;

        public IEnumerable<List<int>> Lists()
        {
            yield return new List<int>();
            yield return new List<int> { 1 };
        }
    }
}
