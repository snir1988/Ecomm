using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EcomWebApi.controllers
{
    public class UsersController : ApiController
    {
        // GET: api/v1/Users
        public List<Users> Get()
        {
            return Users.GetAll();
        }

        // GET: api/Users/5
        public Users Get(int id)
        {
            return Users.GetByID(id);
        }

        // POST: api/Users
        public void Post([FromBody]Users value)
        {
             Users.Add(value);
        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody]Users value)
        {
             Users.Update(id, value);
        }

        // DELETE: api/Users/5
        public int Delete(int id)
        {
            return Users.DeletByID(id);
        }
    }
}
