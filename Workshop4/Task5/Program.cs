// ---------- Part 1: Enum ----------
Console.Write("Enter the day (Example: Sunday): ");
string day = Console.ReadLine();

DayType dayType;

// Task says Friday or Saturday is the weekend
// ToLower() makes the check work for "friday", "FRIDAY", etc.
if (day.ToLower() == "friday" || day.ToLower() == "saturday")
{
    dayType = DayType.Weekend;
}
else
{
    dayType = DayType.Weekday;
}

Console.WriteLine("It is: " + dayType);

// ---------- Part 2: Record ----------
// Create the first Book object and assign values
Book book1 = new Book("C# Basics", "John Smith", 500.0);

// 'with' expression: makes a COPY of book1 with some values changed.
// book1 itself is not modified because records are immutable.
Book book2 = book1 with { title = "Advanced C#", price = 750.0 };

// Print the first object
Console.WriteLine("Book 1: " + book1);

// Deconstruct the second object into three separate variables
var (title, author, price) = book2;
Console.WriteLine("Book 2 Title: " + title);
Console.WriteLine("Book 2 Author: " + author);
Console.WriteLine("Book 2 Price: " + price);