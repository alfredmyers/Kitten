``` ini

BenchmarkDotNet=v0.11.1, OS=Windows 10.0.17134.228 (1803/April2018Update/Redstone4)
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
Frequency=3515625 Hz, Resolution=284.4444 ns, Timer=TSC
.NET Core SDK=2.1.400
  [Host]     : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT


```
|         Method |                 list |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
|--------------- |--------------------- |-----------:|----------:|----------:|-------:|----------:|
|            Any | Syste(...)nt32] [47] | 12.2253 ns | 0.0380 ns | 0.0356 ns | 0.0095 |      40 B |
|            Any | Syste(...)nt32] [47] | 11.6618 ns | 0.1083 ns | 0.1013 ns | 0.0095 |      40 B |
| CountNotEqual0 | Syste(...)nt32] [47] |  0.0000 ns | 0.0000 ns | 0.0000 ns |      - |       0 B |
| CountNotEqual0 | Syste(...)nt32] [47] |  0.0000 ns | 0.0000 ns | 0.0000 ns |      - |       0 B |
