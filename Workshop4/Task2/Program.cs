// Create an object of Calculator
Calculator calc = new Calculator();

// Call the void method
calc.PrintWelcome();

// Call Add and store the returned value
int sum = calc.Add(10, 5);
Console.WriteLine("Addition: " + sum);

// Call Multiply with both values
Console.WriteLine("Multiply (4 x 3): " + calc.Multiply(4, 3));

// Call Multiply with one value: num2 defaults to 1
Console.WriteLine("Multiply (7 x default 1): " + calc.Multiply(7));