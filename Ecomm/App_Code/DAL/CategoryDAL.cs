using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

            string sql = $"SELECT * FROM Category WHERE Cid = {Cid}";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader Dr = cmd.ExecuteReader();

            Category Tmp = null;

            if (Dr.Read())
            {
                Tmp = new BLL.Category()
                {
                    Cid = (int)Dr["Cid"],
                    Cname = (string)Dr["Cname"],
                    Added = (DateTime)Dr["Added"]
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

            string sql = $"SELECT * FROM Category ORDER BY Added DESC";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader Dr = cmd.ExecuteReader();

            List<Category> lst = new List<BLL.Category>();

            while (Dr.Read())
            {
                BLL.Category Tmp = new BLL.Category()
                {
                    Cid = (int)Dr["Cid"],
                    Cname = (string)Dr["Cname"],
                    Added = (DateTime)Dr["Added"]
                };

                lst.Add(Tmp);
            }

            conn.Close();
            return lst;
        }

        public static int Save(Category Tmp)
        {
            DbContext Db = new DbContext();
            string Sql;

            if (Tmp.Cid == -1)
            {
                Sql = $"INSERT INTO Category (Cname, Added) ";
                Sql += $"VALUES (N'{Tmp.Cname}', '{Tmp.Added:yyyy-MM-dd HH:mm:ss}')";
            }
            else
            {
                Sql = $"UPDATE Category SET ";
                Sql += $"Cname = N'{Tmp.Cname}' ";
                Sql += $"WHERE Cid = {Tmp.Cid}";
            }

            int RetVal = Db.ExecuteNonQuery(Sql);
            Db.Close();
            return RetVal;
        }

        public static int DeletByID(int Cid)
        {
            DbContext Db = new DbContext();
            string sql = $"DELETE FROM Category WHERE Cid = {Cid}";
            int i = Db.ExecuteNonQuery(sql);
            Db.Close();
            return i;
        }
    }
}
