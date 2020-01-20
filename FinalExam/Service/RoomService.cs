using Spring.Stereotype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalExam.Dto;

namespace FinalExam.Service
{
    [Service]
    public interface RoomService
    {
        List<RoomDto> GetAll();
        RoomDto GetById(long id);
        RoomDto Update(RoomDto roomDto);
        bool Delete(long id);
        RoomDto add(RoomDto roomDto);
    }
}