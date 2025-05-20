using System;
using BLL;
using System.Collections.Generic;

namespace Ecomm.AdminManage
{
    public partial class UserList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Users> lst = Users.GetAll();
                RptUsers.DataSource = lst;
                RptUsers.DataBind();
            }
        }
    }
}
