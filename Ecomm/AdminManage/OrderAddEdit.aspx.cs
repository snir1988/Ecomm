using System;
using System.Collections.Generic;
using BLL;
using DAL;

namespace Ecomm.AdminManage
{
    public partial class OrderAddEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Users> lstUsers = Users.GetAll();
                DDLUsers.DataSource = lstUsers;
                DDLUsers.DataTextField = "FullName";
                DDLUsers.DataValueField = "Uid";
                DDLUsers.DataBind();

                string strId = Request["Oid"];
                if (!string.IsNullOrEmpty(strId))
                {
                    int id = int.Parse(strId);
                    Order o = Order.GetByID(id);
                    if (o != null)
                    {
                        HidOid.Value = o.Oid.ToString();
                        DDLUsers.SelectedValue = o.Uid.ToString();
                        TxtTotal.Text = o.Total.ToString();
                    }
                }
            }
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            Order o = new Order()
            {
                Oid = int.Parse(HidOid.Value),
                Uid = int.Parse(DDLUsers.SelectedValue),
                OrderDate = DateTime.Now,
                Total = float.Parse(TxtTotal.Text)
            };

            OrderDAL.Save(o); // שמירה
            Response.Redirect("OrderList.aspx");
        }
    }
}
