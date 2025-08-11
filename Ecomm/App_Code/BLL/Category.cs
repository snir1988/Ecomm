using System;
using System.Collections.Generic;
using DAL;

namespace BLL
{
    public class Category
    {
        public int Cid { get; set; } // מזהה קטגוריה
        public string Cname { get; set; } // שם קטגוריה
        public DateTime Added { get; set; } // תאריך הוספה

        public static Category GetByID(int Cid)
        {
            return CategoryDAL.GetByID(Cid);
        }

        public static List<Category> GetAll()
        {
            return CategoryDAL.GetAll();
        }

        public int Save(Category c)
        {
            return CategoryDAL.Save(c);
        }

        public static int DeletByID(int Cid)
        {
            return CategoryDAL.DeletByID(Cid);
        }
    }
}
