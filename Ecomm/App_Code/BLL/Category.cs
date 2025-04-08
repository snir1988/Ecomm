using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecomm.BLL
{
	public class Category
    {
        public int Cid { get; set; }
        public string Cname { get; set; }
        public string Cdesc { get; set; }

        public static Category GetByID(int Cid)
        {
            return new Category();
        }

        public static List<Category> GetAll()
        {
            return new List<Category>();
        }

        public int save()
        {
            return 0;
        }

        public static int DeletByID(int Cid)
        {
            return 0;
        }
    }
}
