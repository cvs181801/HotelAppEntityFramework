using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelWebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        [HttpGet] 
        public async Task<IActionResult> Get() ///where does the await go???
        {
            var reservations = new List<ReservationModel>
            {
                new ReservationModel
                {
                    GuestId = 1,
                    FirstName = "Freak",
                    LastName = "er",
                    RoomNumber = "19",
                    RoomType = "Suite",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,  //2023-05-29T12:01:19.0105988-07:00
                    CheckedIn = false,
                }
            };
            return Ok(reservations);
        }
    }
}
