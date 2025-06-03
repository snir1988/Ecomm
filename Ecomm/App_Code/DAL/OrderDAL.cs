using System; // מאפשר שימוש במחלקות בסיסיות כמו DateTime
using System.Collections.Generic; // מאפשר שימוש ברשימות
using System.Data.SqlClient; // ספרייה לעבודה מול מסד נתונים SQL Server
using System.Linq; // שימוש בפונקציות LINQ (כמו Where, Select – לא חובה פה)
using System.Web; // לתמיכה בפרויקטי ASP.NET ישנים
using BLL; // שימוש במחלקות הלוגיקה העסקית (Business Logic Layer)
using static DATA; // מאפשר שימוש במחלקת DbContext ללא הצורך לכתוב DATA.DbContext


namespace DAL // מרחב השמות של שכבת הגישה לנתונים (Data Access Layer)
{
    public class OrderDAL // מחלקה שמטפלת בגישה לנתוני הזמנות (Orders)
    {
        // פונקציה המחזירה הזמנה לפי מזהה (Oid)
        public static Order GetByID(int Oid)
        {
            // מחרוזת החיבור למסד הנתונים – בדיוק כמו בקבצי DAL אחרים
            string connstr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\שניר\\source\\repos\\Ecomm\\Ecomm\\App_Data\\EcommDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connstr); // יצירת אובייקט חיבור למסד
            conn.Open(); // פתיחת החיבור

            // יצירת שאילתת SQL לשליפת הזמנה לפי מזהה
            string sql = $"SELECT * FROM T_Orders WHERE Oid = {Oid}";
            SqlCommand cmd = new SqlCommand(sql, conn); // יצירת פקודת SQL לביצוע
            SqlDataReader Dr = cmd.ExecuteReader(); // הרצת השאילתה והחזרת תוצאות

            Order Tmp = null; // יצירת משתנה זמני שיכיל את ההזמנה שנשלפה

            // אם קיימת שורה – נבנה את האובייקט מהתוצאה
            if (Dr.Read() == true)
            {
                Tmp = new BLL.Order()
                {
                    Oid = (int)Dr["Oid"], // מזהה ההזמנה
                    Uid = (int)Dr["Uid"], // מזהה המשתמש שביצע את ההזמנה
                    OrderDate = (DateTime)Dr["OrderDate"], // תאריך ההזמנה
                    Total = Convert.ToSingle(Dr["Total"]) // סכום ההזמנה (המרה ל-float)
                };
            }

            conn.Close(); // סגירת החיבור למסד הנתונים
            return Tmp; // החזרת ההזמנה שנשלפה
        }


        // פונקציה המחזירה את כל ההזמנות מהמסד
        public static List<Order> GetAll()
        {
            string connstr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\שניר\\source\\repos\\Ecomm\\Ecomm\\App_Data\\EcommDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connstr); // יצירת אובייקט חיבור למסד
            conn.Open(); // פתיחת החיבור

            string sql = $"SELECT * FROM T_Orders"; // שאילתה לשליפת כל ההזמנות
            SqlCommand cmd = new SqlCommand(sql, conn); // הכנת פקודת SQL
            SqlDataReader Dr = cmd.ExecuteReader(); // הרצת הפקודה וקבלת תוצאות

            List<Order> lst = new List<BLL.Order>(); // יצירת רשימה לשמירת כל ההזמנות

            // לולאה שעוברת על כל השורות שהוחזרו מהמסד
            while (Dr.Read() == true)
            {
                BLL.Order Tmp = new BLL.Order()
                {
                    Oid = (int)Dr["Oid"], // מזהה הזמנה
                    Uid = (int)Dr["Uid"], // מזהה משתמש
                    OrderDate = (DateTime)Dr["OrderDate"], // תאריך ההזמנה
                    Total = Convert.ToSingle(Dr["Total"]) // סכום ההזמנה
                };

                lst.Add(Tmp); // הוספת ההזמנה לרשימה
            }

            conn.Close(); // סגירת החיבור למסד
            return lst; // החזרת כל ההזמנות
        }
        // פונקציה לשמירת הזמנה במסד (הוספה או עדכון)
        public static int Save(Order Tmp)
        {
            DbContext Db = new DbContext(); // יצירת חיבור למסד באמצעות DbContext
            string Sql; // מחרוזת שתכיל את השאילתה

            // בדיקה אם מדובר בהוספה (Oid = -1) או עדכון (Oid קיים)
            if (Tmp.Oid == -1)
            {
                // שאילתה להוספת הזמנה חדשה
                Sql = $"Insert into T_Orders (Uid, OrderDate, Total) ";
                Sql += $"values ({Tmp.Uid}, '{Tmp.OrderDate:yyyy-MM-dd}', {Tmp.Total})";
            }
            else
            {
                // שאילת עדכון להזמנה קיימת – בסגנון שאתה משתמש בו
                Sql = $"Update T_Orders Set ";
                Sql += $"Uid = {Tmp.Uid},";
                Sql += $"OrderDate = '{Tmp.OrderDate:yyyy-MM-dd}',";
                Sql += $"Total = {Tmp.Total} ";
                Sql += $"Where Oid = {Tmp.Oid}";
            }

            int RetVal = Db.ExecuteNonQuery(Sql); // ביצוע השאילתה והחזרת כמות השורות שהושפעו

            if (Tmp.Oid == -1)
            {
                // אופציונלי: אם נרצה לשלוף את המזהה של ההזמנה החדשה שנוספה
                Sql = $"SELECT Max(Oid) FROM T_Orders WHERE Uid = {Tmp.Uid}";
            }

            Db.Close(); // סגירת החיבור למסד הנתונים
            return RetVal; // החזרת מספר השורות שהשתנו
        }
        // פונקציה למחיקת הזמנה לפי מזהה
        public static int DeletByID(int Oid)
        {
            DbContext Db = new DbContext(); // יצירת חיבור למסד
            string sql = $"DELETE FROM T_Orders WHERE Oid = {Oid}"; // שאילתת מחיקה
            int i = Db.ExecuteNonQuery(sql); // ביצוע המחיקה והחזרת מספר השורות שנמחקו
            Db.Close(); // סגירת החיבור
            return i; // החזרת התוצאה
        }
    }
}
