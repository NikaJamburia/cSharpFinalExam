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
    public class HotelsController : ApiController
    {
        private HotelRepository hotelRepository = new HotelRepository();

        // GET: api/Hotels
        public List<Hotel> GetHotels()
        {
            return hotelRepository.GetAll();
        }

        // GET: api/Hotels/5
        [ResponseType(typeof(Hotel))]
        public IHttpActionResult GetHotel(long id)
        {
            Hotel hotel = hotelRepository.Get(id);
            if (hotel == null)
            {
                return NotFound();
            }

            return Ok(hotel);
        }

        // PUT: api/Hotels/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutHotel(long id, Hotel hotel)
        {
            if (hotelRepository.Get(id) != null)
            {
                hotelRepository.Update(id, hotel);
                return Ok(hotel);
            }

            return NotFound();
        }

        // POST: api/Hotels
        [ResponseType(typeof(Hotel))]
        public IHttpActionResult PostHotel(Hotel hotel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            hotel.CreatedAt = DateTime.Now;
            hotel.UpdatedAt = DateTime.Now;

            return Ok(hotelRepository.Save(hotel));
        }

        // DELETE: api/Hotels/5
        [ResponseType(typeof(Hotel))]
        public IHttpActionResult DeleteHotel(long id)
        {
            Hotel hotel = hotelRepository.Get(id);
            if (hotel != null)
            {
                hotelRepository.Delete(hotel);
            }
            else
            {
                return NotFound();
            }

            return Ok();
        }

    }
}