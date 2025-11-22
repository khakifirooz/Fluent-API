namespace Fluent_API.Models;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Family { get; set; }

    public Employee(string name, string family)
    {
        Name = name;
        Family = family;
    }
}
