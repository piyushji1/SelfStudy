
using Proxy;

Parallel.For(0, 10, i => OneFileATATimeProxy.AppendAllText("A.txt", i + ","));