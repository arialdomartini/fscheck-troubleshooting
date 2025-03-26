Run `dotnet test` to see the problem:

```
$ dotnet test
Restore complete (0.2s)
  Issue692 succeeded (0.2s) → bin\Debug\net8.0\Issue692.dll
[xUnit.net 00:00:00.00] xUnit.net VSTest Adapter v3.0.1+f8675c32e5 (64-bit .NET 8.0.14)
[xUnit.net 00:00:00.06]   Discovering: Issue692
[xUnit.net 00:00:00.10]   Discovered:  Issue692
[xUnit.net 00:00:00.11]   Starting:    Issue692
[xUnit.net 00:00:00.28]     Issue692.UnitTest1.Test2 [FAIL]
[xUnit.net 00:00:00.28]       System.InvalidOperationException : There is no currently active test.
[xUnit.net 00:00:00.28]       Stack Trace:
[xUnit.net 00:00:00.28]         C:\prg\fscheck-issues\issue-692\Test1.cs(14,0): at Issue692.UnitTest1.Test2()
[xUnit.net 00:00:00.28]            at System.RuntimeMethodHandle.InvokeMethod(Object target, Void** arguments, Signature sig, Boolean isConstructor)
[xUnit.net 00:00:00.28]            at System.Reflection.MethodBaseInvoker.InvokeWithNoArgs(Object obj, BindingFlags invokeAttr)
[xUnit.net 00:00:00.28]   Finished:    Issue692
  Issue692 test failed with 1 error(s) (1.0s)
    C:\prg\fscheck-issues\issue-692\Test1.cs(14): error TESTERROR:
      Issue692.UnitTest1.Test2 (2ms): Error Message: System.InvalidOperationException : There is no currently active test.
      Stack Trace:
         at Issue692.UnitTest1.Test2() in C:\prg\fscheck-issues\issue-692\Test1.cs:line 14
         at System.RuntimeMethodHandle.InvokeMethod(Object target, Void** arguments, Signature sig, Boolean isConstructor)
         at System.Reflection.MethodBaseInvoker.InvokeWithNoArgs(Object obj, BindingFlags invokeAttr)

Test summary: total: 2, failed: 1, succeeded: 1, skipped: 0, duration: 1.0s
Build failed with 1 error(s) in 1.9s
```
