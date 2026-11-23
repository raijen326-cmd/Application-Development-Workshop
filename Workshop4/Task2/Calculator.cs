public class Calculator
{
    // void method: prints a message, returns nothing
    public void PrintWelcome()
    {
        Console.WriteLine("Welcome to the Calculator");
    }

    // int return type: gives back the sum
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    // num2 is optional with default value 1
    public int Multiply(int num1, int num2 = 1)
    {
        return num1 * num2;
    }
}