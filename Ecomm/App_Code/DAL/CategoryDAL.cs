using System;
using System.Collections.Generic;
using System.Data.SqlClient; 
using System.Linq;
using System.Web;
using BLL;
using static DATA;

namespace DAL
{
    public class CategoryDAL
    {
        public static Category GetByID(int Cid)
        {
            string connstr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\EcommDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();

            string sql = $"SELECT * FROM T_Category WHERE Cid = {Cid}";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader Dr = cmd.ExecuteReader();

            Category Tmp = null;

            if (Dr.Read() == true)
            {
                Tmp = new BLL.Category()
                {
                    Cid = (int)Dr["Cid"],
                    Cname = (string)Dr["Cname"],
                    Cdesc = (string)Dr["Cdesc"]
                };
            }

            conn.Close();
            return Tmp;
        }

        public static List<Category> GetAll()
        {
            string connstr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\EcommDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();

            string sql = $"SELECT * FROM T_Category";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader Dr = cmd.ExecuteReader();

            List<Category> lst = new List<BLL.Category>();

            while (Dr.Read() == true)
            {
                BLL.Category Tmp = new BLL.Category()
                {
                    Cid = (int)Dr["Cid"],
                    Cname = (string)Dr["Cname"],
                    Cdesc = (string)Dr["Cdesc"]
                };

                lst.Add(Tmp);
            }

            conn.Close();
            return lst;
        }

        public static int Save(Category Tmp)
        {
            DbContext Db = new DbContext(); // יצירת אובייקט חיבור
            string Sql;

            if (Tmp.Cid == -1) // הוספה
            {
                Sql = $"Insert into T_Category (Cname, Cdesc) ";
                Sql += $"values (N'{Tmp.Cname}', N'{Tmp.Cdesc}')";
            }
            else // עדכון
            {
                Sql = $"Update T_Category Set ";
                Sql += $"Cname = N'{Tmp.Cname}',";
                Sql += $"Cdesc = N'{Tmp.Cdesc}' ";
                Sql += $"Where Cid = {Tmp.Cid}";
            }

            int RetVal = Db.ExecuteNonQuery(Sql);

            if (Tmp.Cid == -1)
            {
                Sql = $"SELECT Max(Cid) FROM T_Category WHERE Cname = '{Tmp.Cname}'"; // אופציונלי: שליפת מזהה חדש
            }

            Db.Close();
            return RetVal;
        }

        
        public static int DeletByID(int Cid)
        {
            DbContext Db = new DbContext();
            string sql = $"DELETE FROM T_Category WHERE Cid = {Cid}";
            int i = Db.ExecuteNonQuery(sql);
            Db.Close();
            return i;
        }
    }
}
