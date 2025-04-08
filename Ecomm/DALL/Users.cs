using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL;

namespace Ecomm.DALL
{
    public class Users
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
}