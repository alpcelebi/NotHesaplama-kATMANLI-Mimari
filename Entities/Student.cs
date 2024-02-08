

namespace Entities;
public class Student
{
    public int StudentId { get; set; }
    public string FirstName { get; set; } = string.Empty; // veya null
    public string LastName { get; set; } = string.Empty; // veya null
    public double Grade1 { get; set; }
    public double Grade2 { get; set; }
    public double Grade3 { get; set; }
}
