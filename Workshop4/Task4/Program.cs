// Object 1: uses the default constructor (prints the message)
Player p1 = new Player();

// Object 2: uses the parameterized constructor (sets the values)
Player p2 = new Player("Shreya", 5, 100);

// Print values of the first object (fields were never set, so defaults show)
Console.WriteLine("Player 1: Name = " + p1.playerName + ", Level = " + p1.level + ", Health = " + p1.health);

// Print values of the second object
Console.WriteLine("Player 2: Name = " + p2.playerName + ", Level = " + p2.level + ", Health = " + p2.health);