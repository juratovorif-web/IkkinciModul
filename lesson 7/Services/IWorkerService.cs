using lesson_7.Models;
namespace lesson_7.Services
{
    public interface IWorkerService
    {
        public Guid AddWorker(Worker worker);
        public List<Worker> GetAllWorkers();
        public bool UpdateWorker(Worker worker);
        public bool DeleteWorker(Guid workerId);
        public Worker? GetByIdWorker(Guid workerId);

    }
}