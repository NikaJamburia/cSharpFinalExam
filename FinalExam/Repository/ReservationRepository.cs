﻿using Spring.Objects.Factory.Attributes;
using Spring.Stereotype;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using FinalExam.Models;

namespace FinalExam.Repository
{
    public class ReservationRepository : CrudRepository<Reservation>
    {
        public override bool Delete(Reservation entity)
        {
            try
            {
                Context.Reservations.Remove(Context.Reservations.Find(entity.Id));
                Context.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<Reservation> GetByRoomIdAndDates(long RoomId, DateTime checkIn, DateTime checkOut)
        {
            return Context.Reservations.Where(r => r.Room.Id == RoomId && ((r.CheckIn >= checkIn && r.CheckIn <= checkOut) || (r.CheckOut >= checkIn && r.CheckOut <= checkOut))).ToList();
        }

        public override Reservation Get(long id)
        {
            return Context.Reservations.Find(id);
        }

        public override List<Reservation> GetAll()
        {
            return Context.Reservations.ToList();
        }

        public override Reservation Save(Reservation entity)
        {
            Reservation newReservation = Context.Reservations.Add(entity);
            Context.SaveChanges();
            return newReservation;
        }

        public override Reservation Update(long id, Reservation entity)
        {
            Reservation reservationToUpdate = Context.Reservations.Find(id);
            if (reservationToUpdate != null)
            {
                Context.Entry(reservationToUpdate).CurrentValues.SetValues(entity);
                Context.SaveChanges();
            }
            return entity;
        }

        public List<Reservation> GetByRoom(Room room)
        {
            return Context.Reservations.Where(r => r.Room.Id == room.Id).ToList();
        }
    }
}