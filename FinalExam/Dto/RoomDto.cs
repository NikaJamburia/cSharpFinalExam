using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalExam.Dto
{
    [Serializable]
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

        public RoomDto(long id, long hotelId, string hotelName, string createdAt, string updatedAt, int number, int numberOfBeds, int pricePerNight)
        {
            Id = id;
            HotelId = hotelId;
            HotelName = hotelName;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Number = number;
            NumberOfBeds = numberOfBeds;
            PricePerNight = pricePerNight;
            reservedDates = new List<ReservedDatesDto>();
        }
    }
}