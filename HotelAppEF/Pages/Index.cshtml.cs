
//using HotelAppEF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HotelAppLibrary.Entities;
using System.ComponentModel;
using HotelAppEF.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HotelAppEF.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly HotelAppLibrary.DataAccess.GuestContext _guestContext;


        public IndexModel(ILogger<IndexModel> logger, HotelAppLibrary.DataAccess.GuestContext guestContext) 
        {
            _logger = logger;
            _guestContext = guestContext;
        }

        public IList<Guest> Guests { get; set; }



        /*public async Task<Guest> OnGetAsync()
        {
            Guests = await _guestContext.Guests.ToListAsync();
            return (Guest)Guests; ///throws exception: Unsupported handler method return type 'System.Threading.Tasks.Task`1[HotelAppLibrary.Entities.Guest]'.
        }*/

        public void OnGet()
        {
            Guests = _guestContext.Guests.ToList();
        }
    }
}