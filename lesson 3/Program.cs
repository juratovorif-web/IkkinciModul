using lesson_3.Models;
using lesson_3.Service;

namespace lesson_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            RestoranService Service = new RestoranService();
           
            while (true)
            {
                Console.WriteLine("1.Add \n2.GetAll \n3.Update \n4.Delete \n 0.Exit");
                Console.Write("Chosice: ");
                var choice = int.Parse(Console.ReadLine());

                if(choice == 0)
                {
                    break;
                }
                else if (choice == 1)
                {
                    Restoran restoran = new Restoran();

                    Console.Write("Name:");
                    restoran.RestoranName = Console.ReadLine();

                    Console.Write("Capacity: ");
                    restoran.Capacity = int.Parse(Console.ReadLine());

                    Console.Write("Working people: ");
                    restoran.WorkingPeople = int.Parse(Console.ReadLine());

                    Console.Write("Menu: ");
                    restoran.MenuRestorant = Console.ReadLine();    

                    Console.Write("Address: ");
                    restoran.Address = Console.ReadLine();

                    var id = Service.AddRestorant(restoran);
                    Console.WriteLine("Added id: " + id);
                }
                else if(choice == 2)
                {
                    foreach(var c in Service.GetAllRes())
                    {
                        Console.WriteLine($"{c.Id} | {c.RestoranName} | {c.MenuRestorant} | {c.Address} | {c.Capacity} | {c.WorkingPeople}");
                    }
                }
                else if( choice == 3)
                {
                    Console.WriteLine("id : ");
                    var id = int.Parse(Console.ReadLine());

                    Restoran newRestoran = new Restoran();

                    Console.Write("New name ");
                    newRestoran.RestoranName = Console.ReadLine();

                    Console.Write("New capacity ");
                    newRestoran.Capacity = int.Parse(Console.ReadLine());

                    Console.Write("New workingPeople ");
                    newRestoran.WorkingPeople = int.Parse(Console.ReadLine());

                    Console.Write("New menu ");
                    newRestoran.MenuRestorant = Console.ReadLine();

                    Console.Write("New address ");
                    newRestoran.Address = Console.ReadLine();

                    bool updated = Service.UpdateRestoran(id, newRestoran);
                    Console.WriteLine(updated ? "Updated" : "Not found");
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Id ");
                    var id = int.Parse(Console.ReadLine());

                    bool deleted = Service.DeleteRestoran(id);
                    Console.WriteLine(deleted ? "Deleted" : "Not found");
                }
                Console.ReadKey();
                Console.Clear();

            }
            
        }


    }
}
