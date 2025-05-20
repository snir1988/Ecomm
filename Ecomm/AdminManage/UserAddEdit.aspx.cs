using System;
using BLL;

namespace Ecomm.AdminManage
{
    public partial class UserAddEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string Uid = Request["Uid"]; // קבלת הפרמטר של מזהה המשתמש
                if (!string.IsNullOrEmpty(Uid))
                {
                    Users Tmp = Users.GetByID(int.Parse(Uid)); // שליפת משתמש לפי מזהה
                    if (Tmp != null)
                    {
                        TxtEmail.Text = Tmp.Email;
                        TxtPass.Text = Tmp.Pass;
                        TxtFullName.Text = Tmp.FullName;
                        TxtAdress.Text = Tmp.Adress;
                        TxtPhone.Text = Tmp.phone;
                        HidUid.Value = Tmp.Uid.ToString();
                    }
                }
            }
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            Users Tmp = new Users();

            Tmp.Uid = int.Parse(HidUid.Value); // אם חדש: -1, אחרת מזהה קיים
            Tmp.Email = TxtEmail.Text;
            Tmp.Pass = TxtPass.Text;
            Tmp.FullName = TxtFullName.Text;
            Tmp.Adress = TxtAdress.Text;
            Tmp.phone = TxtPhone.Text;

            Tmp.save(); // קריאה למתודת השמירה

            // הפניה חזרה לרשימת המשתמשים
            Response.Redirect("UserList.aspx");
        }
    }
}
