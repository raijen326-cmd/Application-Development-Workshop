int marks;
int total;

// TryParse tries to convert the text to an int.
// It returns true if it worked, false if the input was invalid.
// 'out' stores the converted number in the variable.
Console.Write("Enter marks: ");
bool marksOk = int.TryParse(Console.ReadLine(), out marks);

Console.Write("Enter total: ");
bool totalOk = int.TryParse(Console.ReadLine(), out total);

// Only continue if both inputs were valid integers
if (marksOk && totalOk)
{
    // BREAKPOINT 1: put it on the next line (before the calculation)
    //double percentage = marks / total * 100;
    // BREAKPOINT 2: put it on the next line (after the calculation)
    double percentage = (double)marks / total * 100;
    Console.WriteLine("Percentage: " + percentage);
}
else
{
    Console.WriteLine("Invalid input. Please enter whole numbers only.");
}