using HotelAppLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAppLibrary.DataAccess
{
    public class GuestContext : DbContext
    {
        public GuestContext(DbContextOptions options) : base(options) { }

        public DbSet<Guest> Guests { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }

        /*var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        var DbPath = System.IO.Path.Join(path, "blogging.db");*/
    }
}

//setting up data access layer
//models folder with models (back end to front end) (entities are back end to DB)
//how to inject the dependency into an angular front end ? ? 
//using asyncronous code in asp.net on the front end to help improve performance; other ways to improve performance
//.NET secrets manager