using System.Diagnostics.CodeAnalysis;

namespace lesson4.Models;

public class Animal
{
    public string Color { get; set; }
    public double Speed { get; set; }
    public double Weight { get; set; }
    public double Height { get; set; }

    public void Sound()
    {
        Console.WriteLine("Ovoz cqaradi");

    }

}



