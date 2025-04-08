using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

namespace BLL
{
    public class Users
    {
        public int Uid { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public string FullName { get; set; }
        public string Adress { get; set; }
        public string phone { get; set; }

        public static Users GetByID(int Uid)
        {
            return UsersDAL.GetByID(Uid);
        }

        public static List<Users> GetAll()
        {
            return UsersDAL.GetAll();
        }

        public int save()
        {
            return 0;
        }

        public static int DeletByID(int Uid)
        {
            return UsersDAL.DeletByID(Uid);
        }
    }
}
