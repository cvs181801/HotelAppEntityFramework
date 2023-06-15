using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Microsoft.AspNetCore.Http;
using HotelAppEF.Models;

namespace HotelAppEF.Controllers
{
    public class ReservationController : Controller
    {
        [Route("api/[controller]")]
        //[ApiController]
        //public IActionResult Index()
        //{
            [HttpGet]
             public async Task<ActionResult<List<ResvModel>>> Get()
            {
                var stuff = new List<ResvModel>
                {
                    new ResvModel
                    {
                        GuestId = 1,
                        FirstName = "Freak",
                        LastName = "Er",
                        RoomNumber = "19",
                        RoomType = "Suite",
                        StartDate = DateTime.Now,
                        EndDate = DateTime.Now,
                        CheckedIn = false,
                        //ConfirmationNumber = '5d7ebb0f-78b7-47fb-b7d6-792938fca882'.ToString(),


                    }
                };
                
                return Ok(stuff);
            }
            
       // }
    }
}
