using Spring.Stereotype;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using FinalExam.Models;

namespace FinalExam.Repository
{
    [Component]
    public class EFContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<HotelOwner> Owners { get; set; }
        public virtual DbSet<Hotel> Hotels { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }

        public EFContext() : base("name=FinalDatabase") { }

    }
}