using lesson2hmwrk.Service;

namespace lesson2hmwrk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SchoolService service = new SchoolService();

            while (true)
            {
                Console.WriteLine("\n1. Create");
                Console.WriteLine("2. Read");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Delete");
                Console.WriteLine("0. Exit");
                Console.Write("Tanlang: ");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 0)
                    break;

                if (choice == 1)
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Address: ");
                    string address = Console.ReadLine();

                    Console.Write("Students count: ");
                    int students = int.Parse(Console.ReadLine());

                    Console.Write("Teachers count: ");
                    int teachers = int.Parse(Console.ReadLine());

                    Console.Write("Director name: ");
                    string director = Console.ReadLine();

                    service.Create(name, address, students, teachers, director);
                    Console.WriteLine("Qo‘shildi");
                }
                else if (choice == 2)
                {
                    service.GetAll();
                }
                else if (choice == 3)
                {
                    Console.Write("ID (GUID) kiriting: ");
                    Guid id = Guid.Parse(Console.ReadLine());

                    Console.Write("New name: ");
                    string name = Console.ReadLine();

                    Console.Write("New address: ");
                    string address = Console.ReadLine();

                    Console.Write("New students count: ");
                    int students = int.Parse(Console.ReadLine());

                    Console.Write("New teachers count: ");
                    int teachers = int.Parse(Console.ReadLine());

                    Console.Write("New director name: ");
                    string director = Console.ReadLine();

                    service.Update(id, name, address, students, teachers, director);
                }
                else if (choice == 4)
                {
                    Console.Write("ID (GUID) kiriting: ");
                    Guid id = Guid.Parse(Console.ReadLine());

                    service.Delete(id);
                }
                else
                {
                    Console.WriteLine("Noto‘g‘ri tanlov");
                }
                
               Console.ReadKey();
               Console.Clear();
            }


        }
    }
}
