
using HotelAppEF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;


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

        public List<Guest> Guests { get; set; }

        public async void OnGetAsync()
        {
            Guests = await _guestContext.Guests.ToListAsync();
        }
    }
}