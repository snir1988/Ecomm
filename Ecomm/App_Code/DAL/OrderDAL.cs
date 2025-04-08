using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL;

namespace DAL
{
    public class OrderDAL
    {
        public static List<Order> GetAll()
        {
            return new List<Order>();
        }

        public static Order GetByID(int Oid)
        {
            return new Order();
        }

        public static int DeletByID(int Oid)
        {
            return 0;
        }
    }
}
