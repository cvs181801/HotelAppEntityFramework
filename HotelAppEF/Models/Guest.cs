using HotelAppLibrary.Entities;

namespace HotelAppEF.Models
{
    public class GuestModel
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


    }
    /*public static explicit operator GuestThing(Guest obj)
    {
        GuestThing output = new GuestModel()
        {
            Id = GuestThing.Id,
            StartDate = GuestThing.StartDate,
            EndDate = GuestThing.EndDate,
            FirstName = GuestThing.FirstName,
            LastName = GuestThing.Lastname
        };
        return output;
    }*/
}
