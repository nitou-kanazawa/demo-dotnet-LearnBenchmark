using MyLib;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace DemoConsole
{
  public class Program
  {
    static void Main(string[] args)
    {

      BenchmarkRunner.Run<BenchmarkTest>();
    }
  }


  public class BenchmarkTest
  {
    [Benchmark]
    public void Sleep100ms() => Thread.Sleep(100);

    [Benchmark]
    public void Add()
    {
      var calucurator = new Caluculator();
      for (int i = 0; i < 10000; i++)
      {
        calucurator.Add(i, 1);
      }
    }

  }

}






