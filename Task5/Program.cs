public class Program
{
    public static void Main(string[] args)
    {
       
        DateTime birthDate = new DateTime(2007, 1, 27);
        DateTime today = DateTime.Now;

        
        TimeSpan ageSpan = today - birthDate;

        
        int ageInYears = (int)(ageSpan.TotalDays / 365.25);

       
        Console.WriteLine("Birthdate    : " + birthDate.ToString("dd MMM yyyy"));
        Console.WriteLine("Current date : " + today.ToString("dd MMM yyyy HH:mm"));
        Console.WriteLine("Age in years : " + ageInYears);

      
        DateTime newDate = birthDate.AddDays(10);
        Console.WriteLine("Birthdate + 10 days : " + newDate.ToString("dd MMM yyyy"));
    }
}