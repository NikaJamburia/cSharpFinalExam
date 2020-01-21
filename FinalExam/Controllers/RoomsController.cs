using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using FinalExam.Dto;
using FinalExam.Models;
using FinalExam.Repository;

namespace FinalExam.Controllers
{
    public class RoomsController : ApiController
    {
        private RoomRepository roomRepository = new RoomRepository();
        private ReservationRepository reservationRepository = new ReservationRepository();

        // GET: api/Rooms
        public List<RoomDto> GetRooms()
        {
            List<Room> rooms = roomRepository.GetAll();
            List<Reservation> roomReservations;
            List<RoomDto> roomDtos = new List<RoomDto>();

            foreach (Room room in rooms)
            {
                roomReservations = (reservationRepository.GetByRoom(room));
           
                roomReservations.ForEach(r =>
                {
                    RoomDto roomDto = new RoomDto(
                        room.Id,
                        room.hotel.Id,
                        room.hotel.Name,
                        room.CreatedAt.ToString(),
                        room.UpdatedAt.ToString(),
                        room.Number,
                        room.NumberOfBeds,
                        room.PricePerNight
                    );

                    ReservedDatesDto reservedDate = new ReservedDatesDto();
                    reservedDate.CheckIn = r.CheckIn.ToString();
                    reservedDate.CheckOut = r.CheckOut.ToString();
                    roomDto.reservedDates.Add(reservedDate);
                    roomDtos.Add(roomDto);
                   
                });

            }
            return roomDtos;

        }

        // GET: api/Rooms/5
        [ResponseType(typeof(Room))]
        public IHttpActionResult GetRoom(long id)
        {
            Room room = roomRepository.Get(id);
            if (room == null)
            {
                return NotFound();
            }

            return Ok(room);
        }

        // PUT: api/Rooms/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRoom(long id, Room room)
        {
            if (roomRepository.Get(id) != null)
            {
                roomRepository.Update(id, room);
                return Ok(room);
            }

            return NotFound();
        }

        // POST: api/Rooms
        [ResponseType(typeof(Room))]
        public IHttpActionResult PostRoom(Room room)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            room.CreatedAt = DateTime.Now;
            room.UpdatedAt = DateTime.Now;

            return Ok(roomRepository.Save(room));
        }

        // DELETE: api/Rooms/5
        [ResponseType(typeof(Room))]
        public IHttpActionResult DeleteRoom(long id)
        {
            Room room = roomRepository.Get(id);
            if (room != null)
            {
                roomRepository.Delete(room);
            }
            else
            {
                return NotFound();
            }

            return Ok();
        }

    }
}