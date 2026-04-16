using BenchmarkDotNet.Running;
using BenchmarkDotNet.Application;

namespace BenchmarkDotNet.Application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<AlgorithmTest>();
        }
    }
}