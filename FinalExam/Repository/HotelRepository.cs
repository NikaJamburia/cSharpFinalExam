using Spring.Objects.Factory.Attributes;
using Spring.Stereotype;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using FinalExam.Models;

namespace FinalExam.Repository
{
    public class HotelRepository : CrudRepository<Hotel>
    {
        public override bool Delete(Hotel entity)
        {
            try
            {
                Context.Hotels.Remove(Context.Hotels.Find(entity.Id));
                Context.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public override Hotel Get(long id)
        {
            Hotel hotel = Context.Hotels.Find(id);
            Context.Entry(hotel).Reference(h => h.Owner).Load();
            return hotel;
        }

        public override List<Hotel> GetAll()
        {
            List<Hotel> hotels = Context.Hotels.ToList();
            foreach(Hotel hotel in hotels)
            {
                Context.Entry(hotel).Reference(h => h.Owner).Load();
            }

            return hotels;
        }

        public override Hotel Save(Hotel entity)
        {
            Hotel newHotel = Context.Hotels.Add(entity);
            Context.SaveChanges();
            return newHotel;
        }

        public override Hotel Update(long id, Hotel entity)
        {
            Hotel hotelToUpdate = Context.Hotels.Find(id);
            if (hotelToUpdate != null)
            {
                Context.Entry(hotelToUpdate).CurrentValues.SetValues(entity);
                Context.SaveChanges();
            }
            return entity;
        }
    }
}