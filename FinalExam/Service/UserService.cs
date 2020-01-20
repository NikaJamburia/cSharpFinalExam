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
    interface UserService
    {
        List<UserDto> GetAll();
        UserDto GetById(long id);
        UserDto Update(UserDto userDto);
        bool Delete(long id);
        UserDto Register(UserRegistrationDto reservationDto);
    }
}
