using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalExam.Dto
{
    public class ReservationDto
    {
        public long Id { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public long UserId { get; set; }
        public string UserName { get; set; }
        public long RoomId { get; set; }
        public string RoomNumber { get; set; }
        public long HotelId { get; set; }
        public string HotelName { get; set; }
        public string CheckIn { get; set; }
        public string CheckOut { get; set; }

    }
}