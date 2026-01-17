using System.Collections.Concurrent;

namespace lesson4.Models2;

class Employee : Person
{
    public decimal Salary { get; set; }

    public void Salarys()
    {
        Console.WriteLine($"Daxod: {Salary}");
    }
}
