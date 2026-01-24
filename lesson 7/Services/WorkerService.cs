using lesson_7.Models;

namespace lesson_7.Services;

public class WorkerService : IWorkerService
{
    List<Worker> Workers;
    public WorkerService()
    {
        Workers = new List<Worker>();
    }
    public Guid AddWorker(Worker worker)
    {
       worker.WorkerId = Guid.NewGuid();
        Workers.Add(worker);
        return worker.WorkerId;
    }

    public bool DeleteWorker(Guid workerId)
    {
        foreach(var worker in Workers)
        {
            if(worker.WorkerId == workerId)
            {
                Workers.Remove(worker);
                return true;
            }
        }
        return false;
    }

    public List<Worker> GetAllWorkers()
    {
       return Workers;
    }

    public Worker?GetByIdWorker(Guid workerId)
    {
        foreach(var worker in Workers)
        {
            if (worker.WorkerId == workerId)
            {
                return worker;
            }
        }
        return null;
    }

    public bool UpdateWorker(Worker newWorkers)
    {
        foreach( Worker worker in Workers)
        {
            if(newWorkers.WorkerId ==worker.WorkerId)
            {
                worker.WorkerName = newWorkers.WorkerName;
                worker.WorkerLastName = newWorkers.WorkerLastName;
                worker.WorkerLevel = newWorkers.WorkerLevel;
                return true;
            }
        }
        return false;
    }
}


