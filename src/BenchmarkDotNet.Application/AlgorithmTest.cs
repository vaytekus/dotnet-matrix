using BenchmarkDotNet.Attributes;

namespace BenchmarkDotNet.Application;

public class AlgorithmTest
{
    [Benchmark]
    public void CalcDouble()
    {
        double firstDigit = 135d;
        double secondDigit = 134d;

        double result = firstDigit * secondDigit;
    }
}