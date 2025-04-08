using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecomm.DALL
{
	public class Order
    {
        public static List<BLL.Order> GetAll()
        {
            return new List<BLL.Order>();
        }

        public static BLL.Order GetByID(int Oid)
        {
            return new BLL.Order();
        }

        public static int DeletByID(int Oid)
        {
            return 0;
        }
    }
}