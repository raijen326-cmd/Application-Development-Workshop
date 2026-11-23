public class Player
{
    // Instance fields: each Player object has its own copy
    public string playerName;
    public int level;
    public int health;

    // Default constructor: has no parameters.
    // It only prints a message, so the fields keep their default values
    // (null for string, 0 for int).
    public Player()
    {
        Console.WriteLine("Default constructor has been called");
    }

    // Parameterized constructor: receives values and sets all three fields.
    // 'this' refers to the current object's field, which separates it
    // from the parameter that has the same name.
    public Player(string playerName, int level, int health)
    {
        this.playerName = playerName;
        this.level = level;
        this.health = health;
    }
}