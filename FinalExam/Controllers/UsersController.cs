using Spring.Objects.Factory.Attributes;
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
    public class UsersController : ApiController
    {
        private UserRepository userRepository = new UserRepository();

        // GET: api/Users
        public List<User> GetUsers()
        {
            return userRepository.GetAll();
        }

        // GET: api/Users/5
        [ResponseType(typeof(User))]
        public IHttpActionResult GetUser(long id)
        {
            User user = userRepository.Get(id);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        // PUT: api/Users/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUser(long id, User user)
        {
            userRepository.Update(id, user);

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Users
        [ResponseType(typeof(User))]
        public IHttpActionResult PostUser(User user)
        {
            user.CreatedAt = DateTime.Now;
            user.UpdatedAt = DateTime.Now;
            try
            {
                return Ok(userRepository.Save(user));
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // DELETE: api/Users/5
        [ResponseType(typeof(User))]
        public IHttpActionResult DeleteUser(long id)
        {
            User user = userRepository.Get(id);
            if(user != null)
            {
                userRepository.Delete(user);
            }
            else
            {
                return NotFound();
            }

            return Ok();
        }

    }
}