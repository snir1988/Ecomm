using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL;

namespace DAL
{
    public class UsersDAL
    {
        public static List<Users> GetAll()
        {
            return new List<Users>();
        }

        public static Users GetByID(int Uid)
        {
            return new Users();
        }

        public static int DeletByID(int Uid)
        {
            return 0;
        }
    }
}
