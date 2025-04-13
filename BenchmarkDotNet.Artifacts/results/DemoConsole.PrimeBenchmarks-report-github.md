```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3775)
Intel Core i7-9700K CPU 3.60GHz (Coffee Lake), 1 CPU, 8 logical and 8 physical cores
.NET SDK 8.0.400
  [Host]     : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  Job-EVIRUB : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=3  UnrollFactor=1  
WarmupCount=1  

```
| Method            | N           | Mean             | Error           | StdDev         | Allocated |
|------------------ |------------ |-----------------:|----------------:|---------------:|----------:|
| **Naive_IsPrime**     | **10000000019** | **58,376,900.43 μs** | **3,419,161.02 μs** | **187,415.754 μs** |     **400 B** |
| Optimized_IsPrime | 10000000019 |        620.00 μs |        55.67 μs |       3.051 μs |     400 B |
| **Naive_IsPrime**     | **100000039**   |    **589,510.57 μs** |    **21,630.27 μs** |   **1,185.628 μs** |     **400 B** |
| Optimized_IsPrime | 100000039   |         71.33 μs |        14.63 μs |       0.802 μs |     400 B |
| **Naive_IsPrime**     | **1000000007**  |  **5,872,116.23 μs** |   **321,974.50 μs** |  **17,648.509 μs** |     **400 B** |
| Optimized_IsPrime | 1000000007  |        202.13 μs |        83.21 μs |       4.561 μs |     400 B |
