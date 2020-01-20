using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalExam.Dto
{
    public class RoomDto
    {
        public long Id { get; set; }
        public long HotelId { get; set; }
        public string HotelName { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public int Number { get; set; }
        public int NumberOfBeds { get; set; }
        public int PricePerNight { get; set; }
        public List<ReservedDatesDto> reservedDates { get; set; }
    }
}