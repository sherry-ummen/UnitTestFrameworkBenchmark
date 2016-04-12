# UnitTestFrameworkBenchmark
Analyzing performance of various unit test framework

Results:

Visual Studio Unit test framework:
========== Discover test finished: 2000 found (0:00:00.8087906) ==========
—— Run test started ——
========== Run test finished: 2000 run (0:00:02.8345637) ==========

NUnit:
========== Discover test finished: 2000 found (0:00:01.0557401) ==========
—— Run test started ——
NUnit Adapter 3.0.9.0 executing tests is started
Running selected tests in %folder%\Benchmark\NUnit\bin\Debug\NUnit.dll
Loading tests from %folder%\Benchmark\NUnit\bin\Debug\NUnit.dll
NUnit Adapter 3.0.9.0 executing tests is finished
========== Run test finished: 2000 run (0:00:06.7883689) ==========

xUnit:
========== Discover test finished: 2000 found (0:00:07.2889078) ==========
—— Run test started ——
[xUnit.net 00:00:01.1945017] Starting: Benchmark
[xUnit.net 00:00:41.3330337] Finished: Benchmark
========== Run test finished: 2000 run (0:00:42.2229728) ==========
