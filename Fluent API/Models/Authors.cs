using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Fluent_API.Models;

public class Authors
{
    public int Id { get; set; }
    public int Age { get; set; }
    public string Name { get; set; }
}
