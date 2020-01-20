using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalExam.Models;

namespace FinalExam.Repository
{
    public class RoomRepository : CrudRepository<Room>
    {
        public override bool Delete(Room entity)
        {
            try
            {
                Context.Rooms.Remove(Context.Rooms.Find(entity.Id));
                Context.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public override Room Get(long id)
        {
            return Context.Rooms.Find(id);
        }

        public override List<Room> GetAll()
        {
            return Context.Rooms.ToList();
        }

        public override Room Save(Room entity)
        {
            Room newRoom = Context.Rooms.Add(entity);
            Context.SaveChanges();
            return newRoom;
        }

        public override Room Update(long id, Room entity)
        {
            Room roomToUpdate = Context.Rooms.Find(id);
            if (roomToUpdate != null)
            {
                Context.Entry(roomToUpdate).CurrentValues.SetValues(entity);
                Context.SaveChanges();
            }
            return entity;
        }
    }
}