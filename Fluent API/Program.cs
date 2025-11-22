
using Fluent_API.Models;

var context = new AppDbContext();

//var emp1 = new Employee("mehrshad", "Kakifirooz");
//context.Employees.Add(emp1);

//var author1 = new Authors() { Name = "Abas", Age = 50 };
//var author2 = new Authors() { Name = "Afsin", Age = 45 };
//var author3 = new Authors() { Name = "Ramin", Age = 55 };
//context.Authors.AddRange(author1,author2,author3);

//context.SaveChanges();

//var result = context.Authors.First(x => x.Name == "Abas");
//Console.WriteLine(result.Name);

var result = context.Authors.ToList();
foreach (var item in result)
    Console.WriteLine($"name: {item.Name}");

//var result = context.Authors.Select(x => x.Age).Where(x => x >=50);
//foreach (var item in result)
//    Console.WriteLine(item);



Console.ReadKey();