public class Program
{
    public static void Main(string[] args)
    {
        List<string> fruits = new List<string> { "Apple", "Mango", "Banana" };
        fruits.Add("Orange");
        fruits.Remove("Banana");
        
        Console.WriteLine("Fruits in the list:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
        
        Dictionary<int, string> fruitDict = new Dictionary<int, string>
        {
            { 1, "Apple" },
            { 2, "Mango" },
            { 3, "Banana" }
        };
        
        fruitDict.Add(4, "Orange");

        Console.WriteLine("\nFruit dictionary:");
        foreach (KeyValuePair<int, string> item in fruitDict)
        {
            Console.WriteLine("ID " + item.Key + " : " + item.Value);
        }
    }
}