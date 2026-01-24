using hmwrk8lesson.Models;

namespace hmwrk8lesson.CrudServices
{
    public interface IPersonService
    {
        public Guid Add(Person person);
        public List<Person> GetAll();
        public bool Uptdate(Person person);
        public bool Delete(Guid id);
        public Person? GetByPerson(Guid id);
    }
}