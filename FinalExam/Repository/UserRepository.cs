using Spring.Stereotype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalExam.Models;

namespace FinalExam.Repository
{
    public class UserRepository : CrudRepository<User>
    {
        public override bool Delete(User entity)
        {
            try
            {
                Context.Users.Remove(Context.Users.Find(entity.Id));
                Context.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public override User Get(long id)
        {
            return Context.Users.Find(id);
        }

        public override List<User> GetAll()
        {
            return Context.Users.ToList();
        }

        public override User Save(User entity)
        {
            User newUser = Context.Users.Add(entity);
            Context.SaveChanges();
            return newUser;
        }

        public override User Update(long id, User entity)
        {
            User usersToUpdate = Context.Users.Find(id);
            if (usersToUpdate != null)
            {
                usersToUpdate.Name = entity.Name;
                usersToUpdate.Email = entity.Email;
                usersToUpdate.UpdatedAt = DateTime.Now;
                Context.SaveChanges();
            }
            return entity;
        }
    }
}