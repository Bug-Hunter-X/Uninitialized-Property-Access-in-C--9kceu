# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property before it has been initialized.  Uninitialized properties will have default values (0 for numbers, null for objects), which can lead to unexpected behavior or runtime errors. The `bug.cs` file contains the buggy code, and `bugSolution.cs` provides the corrected version.

## How to Reproduce

1. Clone this repository.
2. Compile and run `bug.cs`. Observe the output.
3. Compile and run `bugSolution.cs`. Observe the corrected output.

## Bug Description

The `MyMethod` function in `bug.cs` attempts to access and use `MyProperty` before a value has been assigned. This results in `value` being initialized to the default value (0) for integers.  This may not be the intended behavior. 

## Solution

The solution in `bugSolution.cs` initializes `MyProperty` before accessing it within the `MyMethod` function. This ensures predictable behavior and avoids unexpected results.