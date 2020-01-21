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
    public class HotelOwnersController : ApiController
    {
        private HotelOwnerRepository ownerRepository = new HotelOwnerRepository();

        // GET: api/HotelOwners
        public List<HotelOwner> GetHotelOwners()
        {
            return ownerRepository.GetAll();
        }

        // GET: api/HotelOwners/5
        [ResponseType(typeof(HotelOwner))]
        public IHttpActionResult GetHotelOwner(long id)
        {
            HotelOwner hotelOwner = ownerRepository.Get(id);
            if (hotelOwner == null)
            {
                return NotFound();
            }

            return Ok(hotelOwner);
        }

        // PUT: api/HotelOwners/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutHotelOwner(long id, HotelOwner hotelOwner)
        {
            if(ownerRepository.Get(id) != null)
            {
                ownerRepository.Update(id, hotelOwner);
                return Ok(hotelOwner);
            }

            return NotFound();
        }

        // POST: api/HotelOwners
        [ResponseType(typeof(HotelOwner))]
        public IHttpActionResult PostHotelOwner(HotelOwner hotelOwner)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            hotelOwner.CreatedAt = DateTime.Now;
            hotelOwner.UpdatedAt = DateTime.Now;

            return Ok(ownerRepository.Save(hotelOwner));

        }

        // DELETE: api/HotelOwners/5
        [ResponseType(typeof(HotelOwner))]
        public IHttpActionResult DeleteHotelOwner(long id)
        {
            HotelOwner owner = ownerRepository.Get(id);
            if (owner != null)
            {
                ownerRepository.Delete(owner);
            }
            else
            {
                return NotFound();
            }

            return Ok();
        }

    }
}