namespace Trening1
{
    internal class Program
    {
        static List<Phone> phones = new List<Phone>();
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("\n1. Create");
                Console.WriteLine("2. Read");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Delete");
                Console.WriteLine("0. Exit");

                Console.Write("Tanlang: ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1) CreatePhone();
                else if (choice == 2) ReadPhone();
                else if (choice == 3) UpdatePhone();
                else if (choice == 4) DeletePhone();
                else if (choice == 0) break;
            }





        }

        void CreatePhone()
        {
            Console.WriteLine("Enter Id : ");
            var id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Name : ");
            var name = Console.ReadLine();

            Console.WriteLine("Enter Price : ");
            var price = double.Parse(Console.ReadLine());

            Phone phone = new Phone
            {
                Id = id,
                Name = name,
                Price = price
            };
            phones.Add(phone);
            Console.WriteLine("Telephons added ");
        }

        void ReadPhone()
        {
            foreach (var phone in phones)
            {
                Console.WriteLine(phone);
            }
        }

        void UpdatePhone()
        {
            Console.WriteLine("Qaysi ID ni ozgartiramiza ? ");
            var id = int.Parse(Console.ReadLine());

            foreach (var phone in phones)
            {
                if(phone.Id == id)
                {
                    Console.Write("New name ");
                    phone.Name = Console.ReadLine();

                    Console.Write("New price ");
                    phone.Price = double.Parse(Console.ReadLine());

                    Console.WriteLine("Okay lets go ");
                    return;
                }
            }
            Console.WriteLine("topilmadi");
        }

        void DeletePhone()
        {
            Console.WriteLine("Qaysi ID ni ocrmamiz ");
            var id = int.Parse(Console.ReadLine());

            for(var i =  0; i < phones.Count; i++)
            {
                if(phones[i].Id == id)
                {
                    phones.RemoveAt(i);
                    Console.WriteLine("O'cirldi ");
                    return ;
                }
            }
            Console.WriteLine("Topilmadi");

        }








        static List<int> FillList(int length)
        {
            List<int> ints = new List<int>();
            for (int i = 0; i < length; i++)
            {
                Console.Write($"{i + 1} - enter num: ");
                var num = int.Parse(Console.ReadLine());
                ints.Add(num);

            }
            return ints;
        }
        static int GetCountOfEvenElements(List<int> numbers)
        {
            var evenCount = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenCount++;
                }
            }
            return evenCount;
        }
        static int GetCountOfOddElemets(List<int> numbers)
        {
            var oddCount = 0;
            foreach(int number in numbers)
            {
                if(number % 2 != 0)
                {
                    oddCount++;
                }
            }
            return oddCount;
        }



    }
}
