using hmwrk8lesson.Models;

namespace hmwrk8lesson.CrudServices;

internal class PersonService : IPersonService
{
    List<Person> People;
    public PersonService()
    {
        People = new List<Person>();
    }

    public Guid Add(Person person)
    {
        person.PersonId = Guid.NewGuid();
        People.Add(person);
        return person.PersonId;
    }

    public bool Delete(Guid id)
    {
        foreach(var person in People)
        {
            if(person.PersonId == id)
            {
                People.Remove(person);
                return true;
            }
        }
        return false;
    }

    public List<Person> GetAll()
    {
        return People;
    }

    public Person? GetByPerson(Guid id)
    {
        foreach (var person in People)
        {
            if(person.PersonId == id)
            {
                return person;
            }
        }
        return null;
    }

    public bool Uptdate(Person newPerson)
    {
        foreach(var person in People)
        {
            if(newPerson.PersonId == person.PersonId)
            {
                person.PersonName = newPerson.PersonName;
                person.PersonNumber = newPerson.PersonNumber;
                person.WorkPerson = newPerson.WorkPerson;
                return true;
            }
        }
        return false;
    }
}
