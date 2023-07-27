using cSharpAcademy_Shifts_Logger.Data;
using cSharpAcademy_Shifts_Logger.Models;
using Microsoft.AspNetCore.Mvc;

namespace cSharpAcademy_Shifts_Logger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class WorkerController : ControllerBase
    {
        private readonly DataContext _context;

        public WorkerController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public ActionResult<Worker> GetWorker(int id)
        {
            var worker = _context.Workers.FirstOrDefault(w => w.WorkerId == id);

            if (worker == null)
            {
                return NotFound();
            }

            return Ok(worker);
        }


        [HttpPost]
        public ActionResult<Worker> AddWorker(Worker worker)
        {
            if (worker == null)
            {
                return BadRequest("Invalid data provided");
            }

            _context.Workers.Add(worker);
            _context.SaveChanges();

            return Ok(worker);
        }
    }
}