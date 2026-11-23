// A record is a short way to create an immutable data class.
// The compiler automatically creates the properties (Title, Author, Price),
// a constructor, equality checking, ToString() and Deconstruct().
public record Book(string title, string author, double price);