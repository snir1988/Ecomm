using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecomm.DALL
{
	public class Category
    {
        public static List<BLL.Category> GetAll()
        {
            return new List<BLL.Category>();
        }

        public static BLL.Category GetByID(int Cid)
        {
            return new BLL.Category();
        }

        public static int DeletByID(int Cid)
        {
            return 0;
        }
    }
}