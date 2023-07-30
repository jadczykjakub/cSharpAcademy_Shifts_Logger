using cSharpAcademy_Shifts_Logger.Interfaces;
using cSharpAcademy_Shifts_Logger.Models;
using Microsoft.AspNetCore.Mvc;

namespace cSharpAcademy_Shifts_Logger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShiftController : ControllerBase
    {
        private readonly IShiftRepository _shiftRepository;

        public ShiftController(IShiftRepository shiftRepository)
        {
            _shiftRepository = shiftRepository;
        }

        [HttpPost]
        public ActionResult<Shift> AddShift(Shift shift)
        {
            var calculatedShift = Helpers.GetValidShiftObject(shift);

            var addShift = _shiftRepository.AddShift(calculatedShift);

            if (!addShift)
            {
                return BadRequest("Invalid data provider");
            }

            return Ok(shift);
        }
    }
}
