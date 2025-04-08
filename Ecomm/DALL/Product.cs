using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient; /// קישור לספריית השאיתות והעבודה מול בסיס נתונים
using System.Data; /// קישור לספריית עבודה  מול מבני נתונים שונים
using BLL;
using System.Security.Cryptography;



namespace DALL
{
	public class Product
	{
        public static BLL.Product GetByID(int Pid)
        {
            //// הפונקציה מקבלת קוד מוצר ומחזירה אובייקט עם פרטי המוצר אחרת תחזיר נאל

            //// נגדיר עבודה מול בסיס נתונים
            ///נגדיר מחזרוזת התחברות לבסיס נתונים
            ///ניצור אובייקט מסוג קונקשיין ונאתחל אותו במחרוזת התחברות
            ///נפתח את הקונקשן
            ///ניצור אובייקט מסוג פקודה ונאתחל אותו בקונקישיין ובמשפט שאילתא
            ///נפעיל את אובייקט הפקודה ונקבל את התוצאות שחזרו
            ///
            string connstr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\EcommDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connstr); // יצירת אובייקט מסוג קונקשן שמקבל מחרוזת התחברות לבסיס נתונים 
            conn.Open(); /// פתיחת הקונקשן לבסיס הנתונים , כעת יש לנו צינור לשאילתות
            string sql = $"SELECT * FROM T_Product where Pid ={Pid}";
            SqlCommand cmd = new SqlCommand(sql, conn); /// יצירת אובייקט פקדוה שמאותחל בשאילתא וקונקשין
            SqlDataReader Dr = cmd.ExecuteReader(); /// יצרנו אובייקט מסוג קורא נתונים והפעלנו שאילתא מול בסיס נתונים
           BLL.Product Tmp = null;

            if (Dr.Read() == true)
            {
                // המוצר נמצא
                Tmp =new  BLL.Product()
                {
                    Pid =(int) Dr["Pid"], /// יצירת אובייקט מסוג מוצר ומילוי השדות שלו  עם הערכים שנשלפים מהבסיס נתונים
                    Pname = (string)Dr["Pname"],
                    Price = (float)Dr["Price"],
                    Pdesc = (string)Dr["Pdesc"]
                };
            }
            conn.Close();
            return Tmp;
        }

        public static List<BLL.Product> GetAll()
        {
            string connstr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\EcommDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connstr); // יצירת אובייקט מסוג קונקשן שמקבל מחרוזת התחברות לבסיס נתונים 
            conn.Open(); /// פתיחת הקונקשן לבסיס הנתונים , כעת יש לנו צינור לשאילתות
            string sql = $"SELECT * FROM T_Product";
            SqlCommand cmd = new SqlCommand(sql, conn); /// יצירת אובייקט פקדוה שמאותחל בשאילתא וקונקשין
            SqlDataReader Dr = cmd.ExecuteReader(); /// יצרנו אובייקט מסוג קורא נתונים והפעלנו שאילתא מול בסיס נתונים
            List<BLL.Product> lst = new List<BLL.Product>();

            while (Dr.Read() == true)
            {
                // המוצר נמצא
                BLL.Product Tmp = new BLL.Product()
                {
                    Pid = (int)Dr["Pid"], /// יצירת אובייקט מסוג מוצר ומילוי השדות שלו  עם הערכים שנשלפים מהבסיס נתונים
                    Pname = (string)Dr["Pname"],
                    Price = (float)Dr["Price"],
                    Pdesc = (string)Dr["Pdesc"]
                };
                lst.Add(Tmp);
            }
            conn.Close();
            return lst;
        }
    }
}