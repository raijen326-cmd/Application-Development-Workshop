using WorkshopWeek4;

Student s1 = new Student();
s1.Name = "Shreya";
s1.Age = 20;
s1.Course = "Computing";

Student s2 = new Student();
s2.Name = "Akriti";
s2.Age = 21;
s2.Course = "Networking";

Console.WriteLine("Student 1: " + s1.Name + ", " + s1.Age + ", " + s1.Course);
Console.WriteLine("Student 2: " + s2.Name + ", " + s2.Age + ", " + s2.Course);

// Static field is accessed through the class name, not an object
Console.WriteLine("College: " + Student.CollegeName);