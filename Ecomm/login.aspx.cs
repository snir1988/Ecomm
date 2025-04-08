using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Ecomm
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e) // כאשר לוחצים על כפתור התחברות
        {
            List<Users> LstUsers = new List<Users>(); //יצירת רשימה של משתמשים
            Users Tmp;
            Tmp = new Users()
            {
                Uid = 2,
                Email = "Sniravitan23@walla.com",
                Pass = "123",
                Adress = "male gat 30 Askelon",
                FullName = "Snir Avitan",
                phone = "052-7738443"
            };

            LstUsers.Add(Tmp);
            Tmp = new Users()
            {
                Uid = 3,
                Email = "ron@walla.com",
                Pass = "123",
                Adress = "levi 30 Askelon",
                FullName = "Ron Hrosh",
                phone = "050-77384243"

            };
            LstUsers.Add(Tmp);

            for (int i = 0; i < LstUsers.Count; i++) /// מעבר על כל רשימת המשתמשים
            {
                if (LstUsers[i].Email == TextEmail.Text && LstUsers[i].Pass == TextPass.Text) /// במידה והמייל והסיסמא שהזינו תואם למייל והסיסמא של המשתמש הנוכחי
                {
                    /// ניצור משתנה מסוג סשן ונשמור בתוכו את האובייקט של המשתמש
                    /// נעביר את המשתמש לדף הבית

                    Session["Login"] = LstUsers[i]; // שמירת אובייקט של המשתמש בתוך משתנה בתוך סשן
                    Response.Redirect("/AdminManage");
                    
                }

                /* if (TextEmail.Text == "abc" && TextPass.Text =="123") // בדיקת תקינות
                 {
                     Response.Redirect("default.aspx"); // אם תקין עבור לדף
                 } 
                 else
                 {
                     Response.Redirect("eror.aspx"); /// אם לא תקין עבור לדף הזה
                 }*/
            }
            Ltlmsg.Text = "שם משתמש/סיסמא אינם נכונים";    
        }
    }
}