using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

namespace BLL
{
    public class Category
    {
        public int Cid { get; set; }
        public string Cname { get; set; }
        public string Cdesc { get; set; }

        public static Category GetByID(int Cid)
        {
            return CategoryDAL.GetByID(Cid);
        }

        public static List<Category> GetAll()
        {
            return CategoryDAL.GetAll();
        }

        public int save()
        {
            return 0;
        }

        public static int DeletByID(int Cid)
        {
            return CategoryDAL.DeletByID(Cid);
        }
    }
}
