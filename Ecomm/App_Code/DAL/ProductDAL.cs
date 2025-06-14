﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient; /// קישור לספריית השאילתות והעבודה מול בסיס נתונים
using System.Data; /// קישור לספריית עבודה  מול מבני נתונים שונים
using BLL;
using static DATA;

namespace DAL
{
    public class ProductDAL
    {
        public static Product GetByID(int Pid)
        {
            string connstr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\שניר\\source\\repos\\Ecomm\\Ecomm\\App_Data\\EcommDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            string sql = $"SELECT * FROM T_Product where Pid ={Pid}";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader Dr = cmd.ExecuteReader();
            Product Tmp = null;

            if (Dr.Read() == true)
            {
                Tmp = new BLL.Product()
                {
                    Pid = int.Parse(Dr["Pid"]+""),
                    Pname = Dr["Pname"]+"",
                    Price = float.Parse(Dr["Price"]+""),
                    Pdesc = (string)Dr["Pdesc"]
                };
            }
            conn.Close();
            return Tmp;
        }

        public static List<Product> GetAll()
        {
            DbContext db = new DbContext();
            string sql = $"SELECT * FROM T_Product";
            DataTable dt = db.Execute(sql);
            List<Product> lst = new List<Product>();

            for (int i=0; i<dt.Rows.Count;i++)
            {
                Product Tmp = new Product()
                {
                    Pid = Convert.ToInt32(dt.Rows[i]["Pid"]),
                    Pname = (string)dt.Rows[i]["Pname"],
                    Price = Convert.ToSingle(dt.Rows[i]["Price"]),
                    Pdesc = (string)dt.Rows[i]["Pdesc"],
                    Picname= (string)dt.Rows[i]["Picname"]
                };
                lst.Add(Tmp);
            }
            db.Close();
            return lst;
        }

        public static int Save(Product Tmp)
        {
            DbContext Db = new DbContext();
            string Sql;//שאילתה אותה יש להריץ מול בסיס הנתונים


            if (Tmp.Pid == -1)//במידה ונבצע הוספת חדש
            {
                Sql = $"Insert into T_product (Pname,Price,Pdesc,Picname,Status,Cid) values";
                Sql += $" (N'{Tmp.Pname}',{Tmp.Price},N'{Tmp.Pdesc}',N'{Tmp.Picname}',{Tmp.Status},{Tmp.Cid})";
            }
            else//עדכון מוצר חדש
            {
                Sql = $"Update T_product Set ";
                Sql += $"Pname=N'{Tmp.Pname}',";
                Sql += $"Price={Tmp.Price},";
                Sql += $"Pdesc=N'{Tmp.Pdesc}',";
                Sql += $"Picname=N'{Tmp.Picname}',";
                Sql += $"Status={Tmp.Status},";
                Sql += $"Cid={Tmp.Cid} ";
                Sql += $"Where Pid={Tmp.Pid} ";
            }
            int RetVal = Db.ExecuteNonQuery(Sql);
            if (Tmp.Pid == -1)
            {
                Sql = $"SELECT Max(Pid) From T_Product wHERE pNAME='{Tmp.Pname}'";
            }

            Db.Close(); //סגירת חיבור לבסיס הנתונים
            return RetVal;
        }


    public static int DeletByID(int Pid)//מוחקת את המוצר לפי קוד
        {
            DbContext Db = new DbContext();//יצירת אובייקט מסוג דאטה בייס
            string sql = $"DELETE FROM T_Product Where Pid={Pid}";//משפט השאילתא
            int i = Db.ExecuteNonQuery(sql);//מחזירה מספר שורות שהוסרו מהמסד נתונים
            Db.Close();//סגירת החיבור לבסיס הנתונים
            return i;//מחזירה את המוצר שנמחק
        }

    } 
}
