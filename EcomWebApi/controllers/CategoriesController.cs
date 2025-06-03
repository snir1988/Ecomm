using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL;
using System.Web.Http;


namespace EcomWebApi.controllers
{
    public class CategoriesController : ApiController
    {  // GET: api/Categories
        public List<Category> Get()
        {
            return Category.GetAll();
        }

        // GET: api/Categories/5
        public Category Get(int id)
        {
            return Category.GetByID(id);
        }
    }
}