using lesson2hmwrk.Service;

namespace lesson2hmwrk
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CarService carService = new CarService();

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
                    Console.WriteLine("id");
                    Guid id = Guid.NewGuid();
                    Console.Write("Bend: ");
                    string brend = Console.ReadLine();

                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Color car: ");
                    string color = Console.ReadLine();

                    Console.Write("Price car: ");
                    decimal price = decimal.Parse(Console.ReadLine());

                    Console.Write("Years car: ");
                    int years = int.Parse(Console.ReadLine());

                    carService.Create(id, brend, name, color, price, years);
                    Console.WriteLine("Qo‘shildi");
                }
                else if (choice == 2)
                {
                    carService.GatAllCar();
                }
                else if (choice == 3)
                {
                    Console.Write("ID (GUID) kiriting: ");
                    Guid id = Guid.Parse(Console.ReadLine());

                    Console.Write("New brend: ");
                    string brend = Console.ReadLine();

                    Console.Write("New name: ");
                    string name = Console.ReadLine();

                    Console.Write("New color: ");
                    string color = Console.ReadLine();

                    Console.Write("New : ");
                    decimal price = decimal.Parse(Console.ReadLine());

                    Console.Write("New director name: ");
                    int years = int.Parse(Console.ReadLine());

                    carService.Update(id, brend, name, color, price, years);
                }
                else if (choice == 4)
                {
                    Console.Write("ID (GUID) kiriting: ");
                    Guid id = Guid.Parse(Console.ReadLine());

                    carService.Deleted(id);
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
