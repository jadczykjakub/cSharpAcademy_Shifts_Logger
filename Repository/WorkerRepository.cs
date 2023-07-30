using cSharpAcademy_Shifts_Logger.Data;
using cSharpAcademy_Shifts_Logger.Interfaces;
using cSharpAcademy_Shifts_Logger.Models;

namespace cSharpAcademy_Shifts_Logger.Repository
{
    public class WorkerRepository : IWorkerRepository
    {
        private readonly DataContext _context;

        public WorkerRepository(DataContext context)
        {
            _context = context;
        }

        bool IWorkerRepository.AddWorker(Worker worker)
        {
            _context.Add(worker);
            return Save();
        }

        Worker IWorkerRepository.GetWorker(int id)
        {
            var worker = _context.Workers.FirstOrDefault(w => w.WorkerId == id);
            return worker;
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
