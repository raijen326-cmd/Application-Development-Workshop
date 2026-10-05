public class task3
{
    public static void Main()
    {
        byte myByte = 10;
        short myShort = 1000;
        int myInt = 50000;
        long myLong = 9000000000L;
        float myFloat = 3.5f;
        double myDouble = 7.25;
        decimal myDecimal = 99.99m;
        char myChar = 'A';
        bool myBool = true;
        
        int number = 42;
        string numberText = number.ToString();

        string piText = "3.14";
        double piNumber = double.Parse(piText);

        Console.WriteLine("byte    : " + myByte);
        Console.WriteLine("short   : " + myShort);
        Console.WriteLine("int     : " + myInt);
        Console.WriteLine("long    : " + myLong);
        Console.WriteLine("float   : " + myFloat);
        Console.WriteLine("double  : " + myDouble);
        Console.WriteLine("decimal : " + myDecimal);
        Console.WriteLine("char    : " + myChar);
        Console.WriteLine("bool    : " + myBool);
        Console.WriteLine("int 42 to string : " + numberText);
        Console.WriteLine("string \"3.14\" to double : " + piNumber);
    }
}