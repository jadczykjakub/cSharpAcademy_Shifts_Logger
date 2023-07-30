using cSharpAcademy_Shifts_Logger.Models;

namespace cSharpAcademy_Shifts_Logger.Interfaces
{
    public interface IWorkerRepository
    {
        Worker GetWorker(int id);
        bool AddWorker(Worker worker);
    }
}
