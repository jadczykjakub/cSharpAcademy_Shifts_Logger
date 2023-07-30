using cSharpAcademy_Shifts_Logger.Interfaces;
using cSharpAcademy_Shifts_Logger.Models;
using Microsoft.AspNetCore.Mvc;

namespace cSharpAcademy_Shifts_Logger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class WorkerController : ControllerBase
    {
        private readonly IWorkerRepository _workerRepository;


        public WorkerController(IWorkerRepository workerRepository)
        {
            _workerRepository = workerRepository;
        }

        [HttpGet("{id}")]
        public ActionResult<Worker> GetWorker(int id)
        {
            var worker = _workerRepository.GetWorker(id);

            if (worker == null)
            {
                return NotFound();
            }

            return Ok(worker);
        }


        [HttpPost]
        public ActionResult<Worker> AddWorker(Worker worker)
        {
            var addWorker = _workerRepository.AddWorker(worker);

            if (!addWorker)
            {
                return BadRequest("Invalid data provided");
            }

            return Ok(worker);
        }
    }
}