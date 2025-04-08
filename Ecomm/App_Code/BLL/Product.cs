using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DALL;

namespace BLL
{
    public class Product
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public float Price { get; set; }
        public string Pdesc { get; set; }

        public static Product GetByID(int Pid)
        {
            return new Product();
        }

        public static List<Product> GetAll()
        {
            return new List<Product>();
        }

        public int save()
        {
            return 0;
        }

        public static int DeletByID(int Pid)
        {
            return 0;
        }
    }
}