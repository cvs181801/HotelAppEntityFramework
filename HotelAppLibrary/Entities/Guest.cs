using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAppLibrary.Entities
{
    public class Guest
    {
        [Key]
        public int Id { get; set; }
      
        public string FirstName { get; set; }
        public string LastName { get; set; }

        


    }
}
