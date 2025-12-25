namespace Trening1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student.StudentId = Guid.NewGuid();
            student.FirstName = "Jon";
            student.LastName = "Ly";
            student.Phone = "+998887778877";
            student.Email = "li@gmail.com";
            student.Address = "Uzbekistan";

            student.PrintAllInfo();
            Console.WriteLine(student.Address);

            student.ToString();
            Console.WriteLine(student);
        }
    }
}
