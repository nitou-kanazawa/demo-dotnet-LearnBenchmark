using MyLib;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using System.Reflection.Metadata;

namespace DemoConsole {
  public class Program {
    static void Main(string[] args) {

      BenchmarkRunner.Run<PrimeBenchmarks>();
    }
  }


  [MemoryDiagnoser]
  [MarkdownExporter, HtmlExporter]
  [Config(typeof(SlimConfig))]
  public class PrimeBenchmarks {

    private Calculator _calculator = new Calculator();

    [Params(100_000_039, 1_000_000_007, 10_000_000_019)] // すべて素数
    public long N;

    [Benchmark]
    public bool Naive_IsPrime() => _calculator.IsPrime(N);

    [Benchmark]
    public bool Optimized_IsPrime() => _calculator.IsPrimeOptimized(N);

    private class SlimConfig : ManualConfig {
      public SlimConfig() {
        AddJob(Job.Default
          .WithWarmupCount(1)     // ウォームアップの回数（デフォルトは1〜5）
          .WithIterationCount(3)  // 計測回数
          .WithInvocationCount(1) // 1回のイテレーション内で何回メソッドを呼ぶか。
          .WithUnrollFactor(1)    // ループの展開数
        );
      }
    }
  }

}






