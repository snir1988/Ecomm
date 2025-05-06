using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;


namespace BLL
{
    public class Product
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public float Price { get; set; }
        public string Pdesc { get; set; }

        public int Cid { get; set; }
        public string Picname { get; set; }
        public int Status { get; set; }

        public static Product GetByID(int Pid)
        {
            return ProductDAL.GetByID(Pid);
        }

        public static List<Product> GetAll()
        {
            return new List<Product>();
        }

        public int save()
        {
            return ProductDAL.Save(this);
        }

        public static int DeletByID(int Pid)
        {
            return 0;
        }
    }
}
