using lesson2hmwrk.Models;

namespace lesson2hmwrk.Service;

internal class SchoolService
{
    List<School> schools = new List<School>();
    int id = 1;

    // CREATE

    public void Create(string name, string address, Guid id, int students, int teachers, string director)
    {
        List<School> schools = new List<School>();
    }

        // CREATE
    public void Create(string name, string address, int students, int teachers, string director)
    {
        School school = new School();

        school.Id = Guid.NewGuid(); // 🔥 GUID
        school.Name = name;
        school.Address = address;
        school.StudetsCount = students;
        school.TeachersCount = teachers;
        school.DirectorName = director;

        schools.Add(school);
    }

    // READ
    public void GetAll()
    {
        if (schools.Count == 0)
        {
            Console.WriteLine("Maktab yo‘q");
            return;
        }

        for (int i = 0; i < schools.Count; i++)
        {
            Console.WriteLine(
                schools[i].Id + " | " +
                schools[i].Name + " | " +
                schools[i].Address + " | " +
                schools[i].StudetsCount + " | " +
                schools[i].TeachersCount + " | " +
                schools[i].DirectorName
            );
        }
    }

    // UPDATE
    public void Update(Guid id, string name, string address, int students, int teachers, string director)
    {
        for (int i = 0; i < schools.Count; i++)
        {
            if (schools[i].Id == id)
            {
                schools[i].Name = name;
                schools[i].Address = address;
                schools[i].StudetsCount = students;
                schools[i].TeachersCount = teachers;
                schools[i].DirectorName = director;

                Console.WriteLine("Update qilindi");
                return;
            }
        }

        Console.WriteLine("Bunday ID topilmadi");
    }

    // DELETE
    public void Delete(Guid id)
    {
        for (int i = 0; i < schools.Count; i++)
        {
            if (schools[i].Id == id)
            {
                schools.RemoveAt(i);
                Console.WriteLine("O‘chirildi");
                return;
            }
        }

        Console.WriteLine("Bunday ID topilmadi");
    }


}
