using lesson_3.Models;
using lesson_3.Service;

namespace lesson_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RestoranService service = new RestoranService();
            while (true)
            {
                Console.WriteLine(" 1 - Create  ");
                Console.WriteLine(" 2 - Read ");
                Console.WriteLine(" 3 - Update ");
                Console.WriteLine(" 4 - Delete ");
                Console.WriteLine(" 5 - Read All ");
                Console.WriteLine(" 0 - Exit");

                var choice = int.Parse(Console.ReadLine());
                if(choice == 1)
                {
                    Restoran restoran = new Restoran();
                    restoran.RestoranName = Console.ReadLine();
                    restoran.Address = Console.ReadLine();
                    restoran.Capacity = int.Parse(Console.ReadLine());
                    restoran.WorkingPerople = int.Parse(Console.ReadLine());
                    restoran.MenuRestorant = Console.ReadLine();
                }
                else if(choice == 2)
                {

                }
            }

        }


    }
}
