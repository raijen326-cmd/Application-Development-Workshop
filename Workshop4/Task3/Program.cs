// Create an object of ParameterDemo
ParameterDemo demo = new ParameterDemo();

// ref: the variable must be given a value first, and the keyword 'ref' is needed in the call too
int myNumber = 5;
Console.WriteLine("Before Increase: " + myNumber);
demo.Increase(ref myNumber);
Console.WriteLine("After Increase: " + myNumber);

// out: declare the variable (no value needed), the method fills it in
string name;
demo.GetFullName(out name);
Console.WriteLine("Full name: " + name);

// params: pass as many numbers as you like, separated by commas
int result1 = demo.SumAll(1, 2, 3);
int result2 = demo.SumAll(10, 20, 30, 40, 50);
Console.WriteLine("Sum of 1, 2, 3: " + result1);
Console.WriteLine("Sum of 10 to 50: " + result2);