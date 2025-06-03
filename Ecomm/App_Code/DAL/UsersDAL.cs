using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient; 
using System.Linq;
using System.Web;
using System.Xml;
using BLL;
using static DATA;

namespace DAL
{
    public class UsersDAL
    {
        public static Users GetByID(int Uid)
        {
            string connstr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\שניר\\source\\repos\\Ecomm\\Ecomm\\App_Data\\EcommDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connstr); // יצירת אובייקט חיבור
            conn.Open();

            string sql = $"SELECT * FROM T_Users where Uid = {Uid}"; // שאילתה לפי מזהה
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader Dr = cmd.ExecuteReader();

            Users Tmp = null;

            if (Dr.Read() == true)
            {
                Tmp = new BLL.Users()
                {
                    Uid = (int)Dr["Uid"],
                    Email = (string)Dr["Email"],
                    Pass = (string)Dr["Pass"],
                    FullName = (string)Dr["FullName"],
                    Adress = (string)Dr["Adress"],
                    phone = (string)Dr["phone"]
                };
            }

            conn.Close(); // סגירת חיבור
            return Tmp;
        }

        
        public static List<Users> GetAll()
        {
            string connstr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\שניר\\source\\repos\\Ecomm\\Ecomm\\App_Data\\EcommDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();

            string sql = $"SELECT * FROM T_Users"; // מביא את כל המשתמשים
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader Dr = cmd.ExecuteReader();

            List<Users> lst = new List<BLL.Users>();

            while (Dr.Read() == true)
            {
                BLL.Users Tmp = new BLL.Users()
                {
                    Uid = (int)Dr["Uid"],
                    Email = (string)Dr["Email"],
                    Pass = (string)Dr["Pass"],
                    FullName = (string)Dr["FullName"],
                    Adress = (string)Dr["Adress"],
                    phone = (string)Dr["phone"]
                };

                lst.Add(Tmp);
            }

            conn.Close();
            return lst;
        }

       
        public static int Save(Users Tmp)
        {
            DbContext Db = new DbContext(); // יצירת אובייקט חיבור לבסיס הנתונים
            string Sql; // משתנה לאחסון שאילתא

            if (Tmp.Uid == -1) // הוספת משתמש חדש
            {
                Sql = $"Insert into T_Users (Email, Pass, FullName, Adress, phone) ";
                Sql += $"values (N'{Tmp.Email}', N'{Tmp.Pass}', N'{Tmp.FullName}', N'{Tmp.Adress}', N'{Tmp.phone}')";
            }
            else // עדכון משתמש קיים
            {
                Sql = $"Update T_Users Set ";
                Sql += $"Email=N'{Tmp.Email}',";
                Sql += $"Pass=N'{Tmp.Pass}',";
                Sql += $"FullName=N'{Tmp.FullName}',";
                Sql += $"Adress=N'{Tmp.Adress}',";
                Sql += $"phone=N'{Tmp.phone}' ";
                Sql += $"Where Uid={Tmp.Uid} ";
            }

            int RetVal = Db.ExecuteNonQuery(Sql); // הרצת השאילתה והחזרת מספר שורות שהושפעו

            if (Tmp.Uid == -1)
            {
                Sql = $"SELECT Max(Uid) FROM T_Users WHERE Email='{Tmp.Email}'"; // לשימוש עתידי אם תרצה להחזיר את ה-ID החדש
            }

            Db.Close(); // סגירת חיבור לבסיס הנתונים
            return RetVal;
        }

        public static int Add(Users Tmp)
        {
            DbContext Db = new DbContext(); // יצירת אובייקט חיבור לבסיס הנתונים

            string Sql = $"Insert into T_Users (Email, Pass, FullName, Adress, phone) ";
            Sql += $"values (N'{Tmp.Email}', N'{Tmp.Pass}', N'{Tmp.FullName}', N'{Tmp.Adress}', N'{Tmp.phone}')";

            int RetVal = Db.ExecuteNonQuery(Sql); // הרצת השאילתה והחזרת מספר שורות שהושפעו

            Db.Close(); // סגירת חיבור לבסיס הנתונים
            return RetVal; // החזרת תוצאה
        }

        public static int Update(Users Tmp)
        {
            DbContext Db = new DbContext(); // יצירת אובייקט חיבור לבסיס הנתונים

            string Sql = $"Update T_Users Set ";
            Sql += $"Email=N'{Tmp.Email}', ";
            Sql += $"Pass=N'{Tmp.Pass}', ";
            Sql += $"FullName=N'{Tmp.FullName}', ";
            Sql += $"Adress=N'{Tmp.Adress}', ";
            Sql += $"phone=N'{Tmp.phone}' ";
            Sql += $"Where Uid={Tmp.Uid}";

            int RetVal = Db.ExecuteNonQuery(Sql); // הרצת השאילתה והחזרת מספר שורות שהושפעו

            Db.Close(); // סגירת חיבור לבסיס הנתונים
            return RetVal; // החזרת תוצאה
        }


        public static int DeletByID(int Uid)
        {
            DbContext Db = new DbContext(); // יצירת אובייקט מסוג דאטה בייס
            string sql = $"DELETE FROM T_Users WHERE Uid={Uid}"; // שאילתת מחיקה
            int i = Db.ExecuteNonQuery(sql); // ביצוע השאילתה
            Db.Close(); // סגירת החיבור לבסיס הנתונים
            return i; // החזרת מספר השורות שנמחקו
        }

        public static Users CheckLogin(string Email, string Pass)
        {
            string connstr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\שניר\\source\\repos\\Ecomm\\Ecomm\\App_Data\\EcommDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();

            string sql = $"SELECT * FROM T_Users where Email=N'{Email}' or '1'='1' and Pass=N'{Pass}'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader Dr = cmd.ExecuteReader();

            Users Tmp = null;

            if (Dr.Read()) // ✅ התיקון הכי חשוב
            {
                Tmp = new BLL.Users()
                {
                    Uid = (int)Dr["Uid"],
                    Email = (string)Dr["Email"],
                    Pass = (string)Dr["Pass"],
                    FullName = (string)Dr["FullName"],
                    Adress = (string)Dr["Adress"],
                    phone = (string)Dr["phone"]
                };
            }

            conn.Close();
            return Tmp;
        }

    }
}

