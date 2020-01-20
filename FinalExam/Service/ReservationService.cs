using Spring.Stereotype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalExam.Dto;

namespace FinalExam.Service
{
    [Service]
    public interface ReservationService
    {
        List<ReservationDto> GetAll();
        ReservationDto GetById(long id);
        ReservationDto Update(ReservationDto reservationDto);
        bool Delete(long id);
        ReservationDto Add(ReservationDto reservationDto);
    }
}