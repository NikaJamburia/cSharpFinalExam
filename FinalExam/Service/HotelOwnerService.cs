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
    interface HotelOwnerService
    {
        List<HotelOwnerDto> GetAll();
        HotelOwnerDto GetById(long id);
        HotelOwnerDto Update(HotelOwnerDto hotelOwnerDto);
        bool Delete(long id);
        HotelOwnerDto Register(HotelOwnerRegistrationDto hotelOwnerRegistrationDto);
    }
}
