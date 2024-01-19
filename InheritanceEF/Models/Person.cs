// Models/Person.cs
public class Person
{
    public int PersonId { get; set; }
    public string? Name { get; set; }
}

// Models/Student.cs
public class Student : Person
{
    public string? StudentId { get; set; }
    public int Grade { get; set; }
}

// Models/Teacher.cs
public class Teacher : Person
{
    public string? TeacherId { get; set; }
    public string? Subject { get; set; }
}
