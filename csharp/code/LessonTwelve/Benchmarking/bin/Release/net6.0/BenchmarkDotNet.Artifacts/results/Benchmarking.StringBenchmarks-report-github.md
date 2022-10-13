``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22000.978/21H2)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.400
  [Host]     : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT AVX2  [AttachedDebugger]
  DefaultJob : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT AVX2


```
|                  Method |     Mean |   Error |  StdDev | Ratio |
|------------------------ |---------:|--------:|--------:|------:|
| StringConcatenationTest | 364.0 ns | 3.87 ns | 3.62 ns |  1.00 |
|       StringBuilderTest | 241.7 ns | 2.72 ns | 2.41 ns |  0.66 |
