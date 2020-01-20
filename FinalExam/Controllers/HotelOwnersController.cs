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
using FinalExam.Models;

namespace FinalExam.Controllers
{
    public class HotelOwnersController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/HotelOwners
        public IQueryable<HotelOwner> GetHotelOwners()
        {
            return db.HotelOwners;
        }

        // GET: api/HotelOwners/5
        [ResponseType(typeof(HotelOwner))]
        public IHttpActionResult GetHotelOwner(long id)
        {
            HotelOwner hotelOwner = db.HotelOwners.Find(id);
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
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != hotelOwner.Id)
            {
                return BadRequest();
            }

            db.Entry(hotelOwner).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HotelOwnerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/HotelOwners
        [ResponseType(typeof(HotelOwner))]
        public IHttpActionResult PostHotelOwner(HotelOwner hotelOwner)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.HotelOwners.Add(hotelOwner);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = hotelOwner.Id }, hotelOwner);
        }

        // DELETE: api/HotelOwners/5
        [ResponseType(typeof(HotelOwner))]
        public IHttpActionResult DeleteHotelOwner(long id)
        {
            HotelOwner hotelOwner = db.HotelOwners.Find(id);
            if (hotelOwner == null)
            {
                return NotFound();
            }

            db.HotelOwners.Remove(hotelOwner);
            db.SaveChanges();

            return Ok(hotelOwner);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool HotelOwnerExists(long id)
        {
            return db.HotelOwners.Count(e => e.Id == id) > 0;
        }
    }
}