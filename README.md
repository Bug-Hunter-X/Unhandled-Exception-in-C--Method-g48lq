# Unhandled Exception in C# Method

This repository demonstrates a common error in C# programming: failing to handle potential exceptions. The `MyMethod` function in `bug.cs` attempts to divide two integers, but it does not check if the denominator is zero. If `b` is 0, a `DivideByZeroException` will occur. 

The `bugSolution.cs` file shows how to properly address this using a `try-catch` block, making the code more robust.