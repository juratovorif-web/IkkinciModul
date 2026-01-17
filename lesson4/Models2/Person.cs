using System;

namespace lesson4.Models2;

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public void PrintFullName()
    {
        Console.WriteLine($"Familya: {LastName}\nName: {FirstName}");
    }
}
