namespace Fluent_API.Models;

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Family { get; set; }

    public Person(string name, string family)
    {
        Name = name;
        Family = family;
    }

}
