using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL;

namespace DAL
{
    public class CategoryDAL
    {
        public static List<Category> GetAll()
        {
            return new List<Category>();
        }

        public static Category GetByID(int Cid)
        {
            return new Category();
        }

        public static int DeletByID(int Cid)
        {
            return 0;
        }
    }
}
