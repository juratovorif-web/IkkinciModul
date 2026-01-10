using lesson_3.Models;
using lesson_3.Service;

namespace lesson_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EarthService service = new EarthService();
            while (true)
            {
                Console.WriteLine("\n1. Create");
                Console.WriteLine("2. Read");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Delete");
                Console.WriteLine("5. ReadAll");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Tanlang");

                var choice = int.Parse(Console.ReadLine());
                if (choice == 0)
                {
                    break;
                }
                if (choice == 1)
                {
                    Earth earth = new Earth();
                    {
                        earth.EarthId = Guid.NewGuid();
                        Console.WriteLine("Countries : ");
                        earth.Countries = Console.ReadLine();
                        Console.WriteLine("Volume : ");
                        earth.Volume = double.Parse(Console.ReadLine());
                        Console.WriteLine("Population : ");
                        earth.Population = int.Parse(Console.ReadLine());
                        Console.WriteLine("IsDeveloped : ");
                        earth.IsDeveloped = bool.Parse(Console.ReadLine());

                    }
                    service.AddEarth(earth);
                    Console.WriteLine("Qowildi");
                }
                else if (choice == 2)
                {
                    Console.Write("Qidirilayotgan EarthId ni kiriting: ");
                    string inputId = Console.ReadLine() ?? "";

                    if (Guid.TryParse(inputId, out Guid searchGuid))
                    {
                        var result = service.GetByEarthId(searchGuid);

                        if (result != null)
                        {
                            service.GetString(result);
                        }
                        else
                        {
                            Console.WriteLine("Bunday ID li ma'lumot topilmadi.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Xato formatdagi ID kiritildi.");
                    }
                }
                else if (choice == 3)
                {
                    Earth earth = new Earth();
                    Console.WriteLine("Id enter : ");
                    Guid earthe = Guid.Parse(Console.ReadLine());
                    var data = service.GetByEarthId(earthe);

                    service.GetString(data);
               
                    Console.WriteLine("Countries : ");
                    earth.Countries = Console.ReadLine();
                    Console.WriteLine("Volume : ");
                    earth.Volume = double.Parse(Console.ReadLine());
                    Console.WriteLine("Population : ");
                    earth.Population = int.Parse(Console.ReadLine());
                    Console.WriteLine("IsDeveloped : ");
                    earth.IsDeveloped = bool.Parse(Console.ReadLine());

                    service.UpdateEarth(earthe, earth);
                }
                else if (choice == 4)
                {
                    Console.Write("ID (GUID) kiriting: ");
                    Guid id = Guid.Parse(Console.ReadLine());

                    service.DeleteEarth(id);
                }
                else if (choice == 5)
                {
                    var data = service.GetAllEarths();
                    if(data.Count == 0)
                    {
                        Console.WriteLine("Malumot yoq !");
                    }
                    foreach(var item in data)
                    {
                        Console.WriteLine(item.EarthId);
                        service.GetString(item);
                    }
                }
                else
                {
                    Console.WriteLine("no tonlov ");
                }

                Console.ReadKey();
                Console.Clear();
            }


        }

        
    }
}
