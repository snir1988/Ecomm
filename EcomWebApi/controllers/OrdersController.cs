using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
//using System.Web.Mvc;
using BLL;

namespace EcomWebApi.controllers
{
    public class OrdersController : ApiController
    {
        // GET: api/Orders
        public List<Order> Get()
        {
            return Order.GetAll();
        }

        // GET: api/Orders/5
        public Order Get(int id)
        {
            return Order.GetByID(id);
        }
    }
}