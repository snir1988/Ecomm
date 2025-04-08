using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DALL;

namespace Ecomm.BLL
{
	public class Order
    {
        public int Oid { get; set; }
        public int Uid { get; set; }
        public DateTime OrderDate { get; set; }
        public float Total { get; set; }

        public static Order GetByID(int Oid)
        {
            return new Order();
        }

        public static List<Order> GetAll()
        {
            return new List<Order>();
        }

        public int save()
        {
            return 0;
        }

        public static int DeletByID(int Oid)
        {
            return 0;
        }
    }
}