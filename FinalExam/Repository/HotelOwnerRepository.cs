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
    public class HotelOwnerRepository : CrudRepository<HotelOwner>
    {
        public override bool Delete(HotelOwner entity)
        {
            try
            {
                Context.Owners.Remove(Context.Owners.Find(entity.Id));
                Context.SaveChanges();

                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public override HotelOwner Get(long id)
        {
             return Context.Owners.Find(id);
        }

        public override List<HotelOwner> GetAll()
        {
            return Context.Owners.ToList();
        }

        public override HotelOwner Save(HotelOwner entity)
        {
           HotelOwner newOwner = Context.Owners.Add(entity);
            Context.SaveChanges();
            return newOwner;
        }

        public override HotelOwner Update(long id, HotelOwner entity)
        {
            HotelOwner ownerToUpdate = Context.Owners.Find(id);
            if(ownerToUpdate != null)
            {
                Context.Entry(ownerToUpdate).CurrentValues.SetValues(entity);
                Context.SaveChanges();
            }
            return entity;
        }
    }
}