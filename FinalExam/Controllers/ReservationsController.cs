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
using FinalExam.Models;
using FinalExam.Repository;

namespace FinalExam.Controllers
{
    public class ReservationsController : ApiController
    {
        private ReservationRepository reservationRepository = new ReservationRepository();

        // GET: api/Reservations
        public List<Reservation> GetReservations()
        {
            return reservationRepository.GetAll();
        }

        // GET: api/Reservations/5
        [ResponseType(typeof(Reservation))]
        public IHttpActionResult GetReservation(long id)
        {
            Reservation reservation = reservationRepository.Get(id);
            if (reservation == null)
            {
                return NotFound();
            }

            return Ok(reservation);
        }

        // PUT: api/Reservations/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutReservation(long id, Reservation reservation)
        {
            if (reservationRepository.Get(id) != null)
            {
                reservationRepository.Update(id, reservation);
                return Ok(reservation);
            }

            return NotFound();
        }

        // POST: api/Reservations
        [ResponseType(typeof(Reservation))]
        public IHttpActionResult PostReservation(Reservation reservation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            List<Reservation> otherReservations = reservationRepository.GetByRoomIdAndDates(reservation.Room.Id, reservation.CheckIn, reservation.CheckOut);

            if(otherReservations.Count == 0)
            {
                reservation.CreatedAt = DateTime.Now;
                reservation.UpdatedAt = DateTime.Now;

                return Ok(reservationRepository.Save(reservation));
            }
            else
            {
                return BadRequest("Room is already reserved");
            }


        }

        // DELETE: api/Reservations/5
        [ResponseType(typeof(Reservation))]
        public IHttpActionResult DeleteReservation(long id)
        {
            Reservation reservation = reservationRepository.Get(id);
            if (reservation != null)
            {
                reservationRepository.Delete(reservation);
            }
            else
            {
                return NotFound();
            }

            return Ok();
        }

    }
}