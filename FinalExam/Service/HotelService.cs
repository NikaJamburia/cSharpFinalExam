using Spring.Stereotype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalExam.Dto;

namespace FinalExam.Service
{
    [Service]
    interface HotelService
    {
        List<HotelDto> GetAll();
        HotelDto GetById(long id);
        HotelDto Update(HotelDto hotel);
        bool Delete(long id);
        HotelDto Add(HotelDto hotel);
    }
}
