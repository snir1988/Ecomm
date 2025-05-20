using System;
using System.Collections.Generic;
using BLL;

namespace Ecomm.AdminManage
{
    public partial class CategoryList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Category> lst = Category.GetAll();
                RptCategories.DataSource = lst;
                RptCategories.DataBind();
            }
        }
    }
}
