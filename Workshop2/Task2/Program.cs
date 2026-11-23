public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("PI = " + Circle.PI);

        //Circle.PI = 3.14159; //PI in circle class is declared as const therefore when I try to modify PI it throws an error.
    }
}