﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAppLibrary.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public int RoomTypeId { get; set; }
        public string RoomNumber { get; set; }
    }
}
