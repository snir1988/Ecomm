using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

//using System.Web.Mvc;
using BLL;

namespace EcomWebApi.controllers
{
    public class ProductsController : ApiController
    {
        // GET: api/Products
        public List<Product> Get()
        {
            return Product.GetAll();
        }

        // GET: api/Products/5
        public Product Get(int id)
        {
            return Product.GetByID(id);
        }
    }
}