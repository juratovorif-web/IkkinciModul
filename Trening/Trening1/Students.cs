using Microsoft.VisualBasic;

namespace Trening1;

internal class Student
{

    public Guid StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    

    public void PrintAllInfo()
    {
        Console.WriteLine($"ID {StudentId}");
        Console.WriteLine($"Firs {FirstName} and last {LastName}");
        Console.WriteLine($"Phone {Phone}");
        Console.WriteLine($"Email{Email}");
    }
    override public string ToString()
    {
        return $"ID {StudentId}\n FirstName {FirstName}\n Last {LastName}\n Email {Email}\n Phone {Phone}\n Adress{Address}";
    }

    


}
