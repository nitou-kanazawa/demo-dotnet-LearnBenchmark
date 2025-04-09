```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3476)
Intel Core i7-9700K CPU 3.60GHz (Coffee Lake), 1 CPU, 8 logical and 8 physical cores
.NET SDK 8.0.400
  [Host]     : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2


```
| Method     | Mean           | Error       | StdDev      |
|----------- |---------------:|------------:|------------:|
| Sleep100ms | 108,854.263 μs | 680.3791 μs | 636.4270 μs |
| Add        |       2.165 μs |   0.0138 μs |   0.0123 μs |
